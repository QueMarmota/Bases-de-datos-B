using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;


namespace ProyectoBasesDeDatosDistribuidas
{
    public partial class Venta : Form
    {//lista que contiene el id_proveedor y nombre
        List<string> listaidProductoNombrePrecioCantidad = new List<string>();
        decimal total;
        //varaibles para sql
        SqlConnection cnSQL; //conexion
        SqlCommand cmd; //comando
        SqlDataAdapter da; //select
        DataTable dt; //datos a tabla
        SqlDataReader dr;///le lo que devuelve la consulta

        //Variables para postgres
        string parametros = "Server=localhost;Port=5432;User id=postgres;Password=root;Database=Sitio2";
        DataSet datos = new DataSet();
        DataTable dtNPG = new DataTable();
        NpgsqlConnection conNPG = new NpgsqlConnection();
        public Venta()
        {
            InitializeComponent();
            total = 0;
            //Conexion a SQL SERVER SITIO1
            try
            {
                cnSQL = new SqlConnection(@"Data Source=DESKTOP-D898I0K\SQLEXPRESS;initial catalog=Sitio1; integrated Security=true");
                cnSQL.Open();
                //MessageBox.Show("abierto");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error con la conexion a la base de datos" + ex.ToString());
            }
            //COONEXION A POSTGERSQL SITIO2

            conNPG.ConnectionString = parametros;
            try
            {
                conNPG.Open();
            }
            catch (Exception error)
            {

                MessageBox.Show("Error en la conexion con NpgSQL" + error.Message);
            }
            //PARA CARGAR LISTA DE PRODUCTOS
            //Validacion en esquema de localizacion---------------------------------------------------------------------------------------------------------------
            //variables necesarias para sacar datos del esquema de localizacion
            List<string> idFragmentos = new List<string>();
            List<string> nombreTablaBDFragmento = new List<string>();
            string nombreTablaGeneral = "";
            string tipoFragmento = "";
            List<string> sitios = new List<string>();
            List<string> condicion = new List<string>();
            SitioCentral st = new SitioCentral();
            st.LeeEsquemaLocalizacion("Producto", ref idFragmentos, ref nombreTablaBDFragmento, ref nombreTablaGeneral, ref sitios, ref tipoFragmento, ref condicion);
            //carga una lista con id y nombre de los productos
            SqlDataAdapter daProducto = new SqlDataAdapter("Select * from " + nombreTablaBDFragmento.ElementAt(0) + "", cnSQL);
            DataTable dtProducto = new DataTable();
            daProducto.Fill(dtProducto);
            // For each row, print the values of each column.
            foreach (DataRow row in dtProducto.Rows)
            {
                listaidProductoNombrePrecioCantidad.Add(row[dtProducto.Columns[0]].ToString() + "," + row[dtProducto.Columns[1]].ToString() + "," + row[dtProducto.Columns[2]].ToString() + "," + row[dtProducto.Columns[4]].ToString());
            }

            cargaCOMBOListBoxInventarioProductos();
            cargaTabla();

        }
        private void mezcaBDNormalDelSitio(List<string> sitios, List<string> nombreTablaBDFragmento)
        {

            switch (sitios.ElementAt(0))
            {
                case "1":
                    //codigo para hacer el select al sitio1
                    da = new SqlDataAdapter("Select * from " + nombreTablaBDFragmento.ElementAt(0) + "", cnSQL);
                    dt = new DataTable();
                    da.Fill(dt);
                    //dt.Columns.RemoveAt(0);//Para quitar el campo RFC
                    dataGridViewVenta.DataSource = dt;
                    //para esconder el campor id
                    dataGridViewVenta.Columns[0].Visible = false;

                    break;


                case "2":
                    //Codigo para hacer el select from a al sitio2             
                    NpgsqlDataAdapter add = new NpgsqlDataAdapter("select * from " + nombreTablaBDFragmento.ElementAt(0) + "", conNPG);
                    dtNPG = new DataTable();
                    add.Fill(dtNPG);
                    dataGridViewVenta.DataSource = dtNPG;
                    //para esconder el campor id
                    dataGridViewVenta.Columns[0].Visible = false;
                    break;
            }

        }
        public void MezclaBDReplica(List<string> nombreTablaBDFragmento)
        {

            //codigo para hacer el select al sitio1
            da = new SqlDataAdapter("Select * from " + nombreTablaBDFragmento.ElementAt(0) + "", cnSQL);
            dt = new DataTable();
            da.Fill(dt);
            //dt.Columns.RemoveAt(0);//Para quitar el campo RFC
            dataGridViewVenta.DataSource = dt;
            //para esconder el campor RFC
            dataGridViewVenta.Columns[0].Visible = false;
        }


        private void cargaTabla()
        {
            try
            {
                //Validacion en esquema de localizacion---------------------------------------------------------------------------------------------------------------
                //variables necesarias para sacar datos del esquema de localizacion
                List<string> idFragmentos = new List<string>();
                List<string> nombreTablaBDFragmento = new List<string>();
                string nombreTablaGeneral = "";
                string tipoFragmento = "";
                List<string> sitios = new List<string>();
                List<string> condicion = new List<string>();
                SitioCentral st = new SitioCentral();
                st.LeeEsquemaLocalizacion("Venta", ref idFragmentos, ref nombreTablaBDFragmento, ref nombreTablaGeneral, ref sitios, ref tipoFragmento, ref condicion);
                switch (tipoFragmento)
                {
                    //si es horizontal tiene las mismas columnas y solo hacemos merge en las rows
                    case "Horizontal":


                        break;
                    case "Vertical":

                        break;
                    case "Replica":
                        MezclaBDReplica(nombreTablaBDFragmento);
                        break;

                    default:
                        mezcaBDNormalDelSitio(sitios, nombreTablaBDFragmento);
                        break;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo actualizar" + ex);
            }
        }

        private void Venta_Load(object sender, EventArgs e)
        {

        }

        private void cargaCOMBOListBoxInventarioProductos()
        {

            foreach (var item in listaidProductoNombrePrecioCantidad)
            {
                //id producto , nombre , precio , cantidad en el stock
                string[] temp = item.Split(',');
                listBoxInventario.Items.Add(temp.ElementAt(1)+" x"+temp.ElementAt(3));
                
            }
          
        }

        private void listBoxInventario_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //codigo para restar un producto en la lista stock
                string dato = listBoxInventario.Items[listBoxInventario.SelectedIndex].ToString();
                string[] nombreycantidad = dato.Split('x');
                int cantidadmenos1 = Int32.Parse(nombreycantidad.ElementAt(1)) - 1;
                if (cantidadmenos1 == 0)// si el producto llega a la cantidad de 0 se elimina
                {
                    listBoxInventario.Items.RemoveAt(listBoxInventario.SelectedIndex);
                }
                else//se agrega a la lista el producto con una unidad menos
                    listBoxInventario.Items[listBoxInventario.SelectedIndex] = nombreycantidad.ElementAt(0) + "x" + cantidadmenos1.ToString();
                
                //codigo para mandar a la lista carrito el producto con el numero de veces que lo solicito (agregar al carrito)
                //Buscar el producto tecleado y la cantidad para sacar la diferencia y mandar la cantidad de productos a vender
                string nombreProd = nombreycantidad.ElementAt(0).Trim();
                string infodelproducto = listaidProductoNombrePrecioCantidad.Find(x => x.Contains(nombreProd));
                string[] arraytemp = infodelproducto.Split(',');
                int cantidadTotal = Convert.ToInt32(arraytemp.ElementAt(3))-cantidadmenos1;
                string productoEnCarrito = nombreProd + " x" + cantidadTotal;//aqui se saca la diferencia osea resto el total menos los que llevaS
                if (listBoxCarrito.FindString(nombreProd, 0) != -1)//si en el carrito ya exite el producto remplazamos la cadena
                {
                    listBoxCarrito.Items[listBoxCarrito.FindString(nombreProd, 0)] = productoEnCarrito;
                }
                else //si no existe se agrega
                {
                    listBoxCarrito.Items.Add(productoEnCarrito);
                }

                //codigo para aumentar total
                total += Convert.ToDecimal(arraytemp[2]);
                //richTextBoxTotal.SelectionColor = Color.Lime;

                //richTextBoxTotal.SelectionFont = new Font("Verdana", 15, FontStyle.Regular);
                //richTextBoxTotal.SelectionColor = Color.Lime;

                richTextBoxTotal.Text = "$"+total.ToString();

                //para quitar la selccion
               // listBoxInventario.ClearSelected();

            }
            catch (Exception)
            {
                
              
            }
            
        }

        private void listBoxCarrito_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //listBoxCarrito.Items.RemoveAt(listBoxCarrito.SelectedIndex);
                //listBoxCarrito.Items.Add(dato);

                //codigo para restar un producto en la lista carrito
                string dato = listBoxCarrito.Items[listBoxCarrito.SelectedIndex].ToString();
                string[] nombreycantidad = dato.Split('x');
                int cantidadmenos1 = Int32.Parse(nombreycantidad.ElementAt(1)) - 1;
                if (cantidadmenos1 == 0)// si el producto llega a la cantidad de 0 se elimina
                {
                    listBoxCarrito.Items.RemoveAt(listBoxCarrito.SelectedIndex);
                }
                else//se modifica la lista del producto con una unidad menos
                    listBoxCarrito.Items[listBoxCarrito.SelectedIndex] = nombreycantidad.ElementAt(0) + "x" + cantidadmenos1.ToString();

                //codigo para mandar a la lista stock el producto con el numero de veces que lo solicito (agregar al carrito)
                //Buscar el producto tecleado y la cantidad para sacar la diferencia y mandar la cantidad de productos a vender
                string nombreProd = nombreycantidad.ElementAt(0).Trim();
                string infodelproducto = listaidProductoNombrePrecioCantidad.Find(x => x.Contains(nombreProd));
                string[] arraytemp = infodelproducto.Split(',');
                int cantidadTotal = Convert.ToInt32(arraytemp.ElementAt(3)) - cantidadmenos1;
                string productoEnCarrito = nombreProd + " x" + cantidadTotal;//aqui se saca la diferencia osea resto el total menos los que llevaS
                if (listBoxInventario.FindString(nombreProd, 0) != -1)//si en el carrito ya exite el producto remplazamos la cadena
                {
                    listBoxInventario.Items[listBoxInventario.FindString(nombreProd, 0)] = productoEnCarrito;
                }
                else //si no existe se agrega
                {
                    listBoxInventario.Items.Add(productoEnCarrito);
                }

                //Codigo para disminuir total
                //codigo para aumentar total
                total -= Convert.ToDecimal(arraytemp[2]);
                richTextBoxTotal.Text = "$"+total.ToString();
            }
            catch (Exception)
            {

         
            }
            
        }

        private void richTextBoxTotal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {

        }
    }
}
