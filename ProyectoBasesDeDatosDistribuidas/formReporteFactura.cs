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

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProyectoBasesDeDatosDistribuidas
{
    public partial class formReporteFactura : Form
    {

        List<int> listPrimaryKeysProveedor;
        string[] TuplaPDFProveedor = new string[1];
        List<string[]> listaProductosDelProveedor = new List<string[]>();
        List<string> ProveedorEnLista = new List<string>();
        List<string> ProductoEnLista = new List<string>();
        List<string> VentaEnLista = new List<string>();
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

        public formReporteFactura()
        {
            InitializeComponent();
           // this.StartPosition = FormStartPosition.Manual;
           // this.Location = new Point(-5000, -5000);//para que no aparezca en la pantalla
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
            cargaTablaProveedor();//carga datagridproveedor
            cargaTablaProductos();//carga datagrdproductos
            cargaTablaVentas();//carga el datagridventas
            //cargar el listview
            cargaListView();
        }
        public struct VariablesNecesariasParaEsquemaLocalizacion//estructura para evitar estar repitiendo codigo
        {
            //Validacion en esquema de localizacion---------------------------------------------------------------------------------------------------------------
            //variables necesarias para sacar datos del esquema de localizacion
            public List<string> idFragmentos;
            public List<string> nombreTablaBDFragmento;
            public string nombreTablaGeneral;
            public string tipoFragmento;
            public List<string> sitios;
            public List<string> condicion;
            public SitioCentral st;
            public void DeclaraVariables()
            {

                this.idFragmentos = new List<string>();
                this.nombreTablaBDFragmento = new List<string>();
                this.nombreTablaGeneral = "";
                this.tipoFragmento = "";
                this.sitios = new List<string>();
                this.condicion = new List<string>();
                this.st = new SitioCentral();
            }

        }       
        private void cargaTablaVentas()
        {
            try
            {
                //Validacion en esquema de localizacion---------------------------------------------------------------------------------------------------------------
                //variables necesarias para sacar datos del esquema de localizacion
                VariablesNecesariasParaEsquemaLocalizacion v = new VariablesNecesariasParaEsquemaLocalizacion();
                v.DeclaraVariables();
                v.st.LeeEsquemaLocalizacion("Venta", ref v.idFragmentos, ref v.nombreTablaBDFragmento, ref v.nombreTablaGeneral, ref v.sitios, ref v.tipoFragmento, ref v.condicion);
                switch (v.tipoFragmento)
                {
                    //si es horizontal tiene las mismas columnas y solo hacemos merge en las rows
                    case "Horizontal":


                        break;
                    case "Vertical":

                        break;
                    case "Replica":
                        MezclaBDReplicaVenta(v.nombreTablaBDFragmento);
                        break;

                    default:
                        mezcaBDNormalDelSitioVenta(v.sitios, v.nombreTablaBDFragmento);
                        break;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo actualizar" + ex);
            }
        }
        private void mezcaBDNormalDelSitioVenta(List<string> sitios, List<string> nombreTablaBDFragmento)
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
        public void MezclaBDReplicaVenta(List<string> nombreTablaBDFragmento)
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
        private void cargaTablaProductos()
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
                st.LeeEsquemaLocalizacion("Producto", ref idFragmentos, ref nombreTablaBDFragmento, ref nombreTablaGeneral, ref sitios, ref tipoFragmento, ref condicion);
                switch (tipoFragmento)
                {
                    //si es horizontal tiene las mismas columnas y solo hacemos merge en las rows
                    case "Horizontal":


                        break;
                    case "Vertical":

                        break;
                    case "Replica":
                        MezclaBDReplicaProducto(nombreTablaBDFragmento);
                        break;

                    default:
                        mezcaBDNormalDelSitioProducto(sitios, nombreTablaBDFragmento);
                        break;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo actualizar" + ex);
            }
        }
        private void mezcaBDNormalDelSitioProducto(List<string> sitios, List<string> nombreTablaBDFragmento)
        {

            switch (sitios.ElementAt(0))
            {
                case "1":
                    //codigo para hacer el select al sitio1
                    da = new SqlDataAdapter("Select * from " + nombreTablaBDFragmento.ElementAt(0) + "", cnSQL);
                    dt = new DataTable();
                    da.Fill(dt);
                    //dt.Columns.RemoveAt(0);//Para quitar el campo RFC
                    dataGridViewProducto.DataSource = dt;
                    //para esconder el campor id
                    dataGridViewProducto.Columns[0].Visible = false;
                    //para esconder el campo id venta
                    dataGridViewProducto.Columns[6].Visible = false;

                    break;


                case "2":
                    //Codigo para hacer el select from a al sitio2             
                    NpgsqlDataAdapter add = new NpgsqlDataAdapter("select * from " + nombreTablaBDFragmento.ElementAt(0) + "", conNPG);
                    dtNPG = new DataTable();
                    add.Fill(dtNPG);
                    dataGridViewProducto.DataSource = dtNPG;
                    //para esconder el campor id
                    dataGridViewProducto.Columns[0].Visible = false;
                    //para esconder el campo id venta
                    dataGridViewProducto.Columns[6].Visible = false;
                    break;
            }

        }
        public void MezclaBDReplicaProducto(List<string> nombreTablaBDFragmento)
        {

            //codigo para hacer el select al sitio1
            da = new SqlDataAdapter("Select * from " + nombreTablaBDFragmento.ElementAt(0) + "", cnSQL);
            dt = new DataTable();
            da.Fill(dt);
            //dt.Columns.RemoveAt(0);//Para quitar el campo RFC
            dataGridViewProducto.DataSource = dt;
            //para esconder el campor RFC
            dataGridViewProducto.Columns[0].Visible = false;
            //para esconder el campo id venta
            dataGridViewProducto.Columns[6].Visible = false;
        }
        private void cargaListView()//aqui se cargan todas las listas
        {
            listBoxVenta.Items.Clear();
            VentaEnLista.Clear();
            ProductoEnLista.Clear();
            ProveedorEnLista.Clear();
            //cargamos la lista de ventas
            foreach (DataGridViewRow row in dataGridViewVenta.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    listBoxVenta.Items.Add("id Venta :  " + row.Cells[0].Value.ToString() + " , Fecha :  " + row.Cells[1].Value.ToString().Substring(0,10));
                    string dato = row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString() + "," + row.Cells[2].Value.ToString() + "," + row.Cells[3].Value.ToString() + "," + row.Cells[4].Value.ToString() + "," + row.Cells[5].Value.ToString() + "";
                    VentaEnLista.Add(dato);
                }
                //More code here
            }

            //cargamos lista producto
            foreach (DataGridViewRow row in dataGridViewProducto.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    string dato = row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString() + "," + row.Cells[2].Value.ToString() + "," + row.Cells[3].Value.ToString() + "," + row.Cells[4].Value.ToString() + "," + row.Cells[5].Value.ToString() + "," + row.Cells[6].Value.ToString() + "";
                    ProductoEnLista.Add(dato);
                }
                //More code here
            }
            //cargamos lista proveedor
            foreach (DataGridViewRow row in dataGridViewProveedor.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    string dato = row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString() + "," + row.Cells[2].Value.ToString() + "," + row.Cells[3].Value.ToString() + "," + row.Cells[4].Value.ToString() + "," + row.Cells[5].Value.ToString() + "";
                    ProveedorEnLista.Add(dato);
                }
                //More code here
            }
        }

        private void cargaTablaProveedor()
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
                st.LeeEsquemaLocalizacion("Proveedor", ref idFragmentos, ref nombreTablaBDFragmento, ref nombreTablaGeneral, ref sitios, ref tipoFragmento, ref condicion);

                switch (tipoFragmento)
                {
                    case "Horizontal":
                        MezclaBDHorizontal();
                        break;
                    case "Vertical":
                        MezclaBDVertical();

                        break;
                    case "Replica":

                        break;

                    default:
                        break;

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo actualizar" + ex);
            }
        }
        private void MezclaBDVertical()
        {
            /*CODIGO PARA ITERAR LAS CELDAS DE UN DATATABLE POR RENGLONES
          int numberOfColumns = dt.Columns.Count;

           // go through each row
           foreach (DataRow dr in dt.Rows)
           {
               // go through each column in the row
               for (int i = 0; i < numberOfColumns; i++)
               {
                   // access cell as set or get
                   // dr[i] = "something";
                   // string something = Convert.ToString(dr[i]);
               }
           }
           */
            NpgsqlDataAdapter add;
            //codigo para hacer el select al sitio1
            da = new SqlDataAdapter("Select * from Proveedor1 ORDER BY id_Proveedor DESC", cnSQL);
            dt = new DataTable();
            da.Fill(dt);
            //dt.Columns.RemoveAt(0);//Para quitar el campo RFC
            dataGridViewProveedor.DataSource = dt;


            //Codigo para hacer el select from a al sitio2             
            add = new NpgsqlDataAdapter("select * from Proveedor2 ORDER BY id_Proveedor DESC", conNPG);
            //add.Fill(datos);
            dtNPG = new DataTable();
            add.Fill(dtNPG);
            // dtNPG.Columns.RemoveAt(0);//para quitar el campo RFC

            // dt.Merge(dtNPG);

            //Hacer merge entre los dos select del sito1 y el sitio2
            foreach (var column in dtNPG.Columns)
            {
                if (column.ToString().Contains("id"))//esto con la finalidad de corregir por q el ide copia el daato en las celdas que se llaman igual
                    dt.Columns.Add(column.ToString() + "2");
                else
                    dt.Columns.Add(column.ToString());
            }

            int numberOfColumns = dt.Columns.Count;
            int contadorRows = 0;
            //para esconder el campor id
            // dataGridViewProveedor.Columns[0].Visible = false;
            // dataGridViewProveedor.Columns[4].Visible = false;

            // go through each row
            int contadorPK = 0;
            listPrimaryKeysProveedor = new List<int>();
            foreach (DataRow dr in dt.Rows)
            {
                // go through each column in the row
                for (int i = dtNPG.Columns.Count; i < numberOfColumns - 1; i++)//-1 por q adelante le sumo mas 1
                {
                    // access cell as set or get
                    var dato = dtNPG.Rows[contadorRows][(i - dtNPG.Columns.Count)];
                    if (contadorPK == 0)//se agrega la llave primaria a la lista global para evaluar una autonumerica programada
                    {
                        listPrimaryKeysProveedor.Add(Convert.ToInt32(dato));
                    }
                    contadorPK++;
                    dr[i + 1] = dato;//+| para evitar q copie el idproveedor de la base de datos de npg
                    //string something = Convert.ToString(dr[i+2]);
                }
                contadorRows++;
            }

            //dt tiene los campos del sitio1 y del sitio2           
            dataGridViewProveedor.DataSource = dt;


            //para esconder el campor id
            dataGridViewProveedor.Columns[0].Visible = false;
            dataGridViewProveedor.Columns[4].Visible = false;



        }
        private void MezclaBDHorizontal()
        {
            NpgsqlDataAdapter add;
            //codigo para hacer el select al sitio1
            da = new SqlDataAdapter("Select * from Proveedor1", cnSQL);
            dt = new DataTable();
            da.Fill(dt);
            //dt.Columns.RemoveAt(0);//Para quitar el campo RFC
            dataGridViewProveedor.DataSource = dt;


            //Codigo para hacer el select from a al sitio2             
            add = new NpgsqlDataAdapter("select * from Proveedor2", conNPG);
            //add.Fill(datos);
            dtNPG = new DataTable();
            add.Fill(dtNPG);
            // dtNPG.Columns.RemoveAt(0);//para quitar el campo RFC

            //Hacer merge entre los dos select del sito1 y el sitio2
            for (int i = 0; i < dtNPG.Rows.Count; i++)
            {
                dt.ImportRow(dtNPG.Rows[i]);
            }

            //dt tiene los campos del sitio1 y del sitio2
            dataGridViewProveedor.DataSource = dt;

            //para esconder el campor id
            dataGridViewProveedor.Columns[0].Visible = false;

        }
        private void formReporteFactura_Load(object sender, EventArgs e)
        {

        }

        private void listBoxVenta_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //obtener la tupla para el proveedor
                TuplaPDFProveedor = new string[1];
                listaProductosDelProveedor.Clear();
                string datoVenta = listBoxVenta.Items[listBoxVenta.SelectedIndex].ToString();
                string[] cadtemp = datoVenta.Split(' ');//cadtem[4] tieme el id de la venta el cul se buscara en id producto
                string[] tupla = ProductoEnLista.Find(x => x.Contains(cadtemp[4])).Split(',');//regresa el proveedor con todos sus datos necesarios
                TuplaPDFProveedor = tupla;//tenemos la tupla del proveedor del cual se vendieron sus productos
                //buscar los productos de ese proveedor
                foreach (DataGridViewRow row in dataGridViewProducto.Rows)
                {
                    //if para evitar que se meta cuando es null
                    if (row.Cells[1].Value != null)
                    {
                        //si el producto es del proveedor que se le hara el reporte
                        if (row.Cells[5].Value.ToString().Contains(TuplaPDFProveedor[0]))
                        {
                            string dato = row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString() + "," + row.Cells[2].Value.ToString() + "," + row.Cells[3].Value.ToString() + "," + row.Cells[4].Value.ToString() + "," + row.Cells[5].Value.ToString() + "," + row.Cells[6].Value.ToString() + "";
                            listaProductosDelProveedor.Add(dato.Split(','));//se agrega el producto a la lista
                        }
                    }
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error en listbox");

            }
        }
    }
}
