﻿using System;
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
        bool banderaNoPermiteModificarListBox = false;
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

            CargalistaidProductoNombrePrecioCantidad();
            cargaCOMBOListBoxInventarioProductos();
            cargaTabla();

        }
        private void CargalistaidProductoNombrePrecioCantidad()
        {

            //PARA CARGAR LISTA DE PRODUCTOS
            //Validacion en esquema de localizacion---------------------------------------------------------------------------------------------------------------
            //variables necesarias para sacar datos del esquema de localizacion
            listaidProductoNombrePrecioCantidad = new List<string>();
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
            listBoxInventario.Items.Clear();
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
                if (banderaNoPermiteModificarListBox)//si esta activada la bandera es por que se quiere pasar un producto del carrito al stock y no se puede
                {
                    MessageBox.Show("No se puede agregar mas Productos!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }
                else
                {
                    if (cantidadmenos1 == 0)// si el producto llega a la cantidad de 0 se elimina
                    {
                        listBoxInventario.Items.RemoveAt(listBoxInventario.SelectedIndex);
                    }
                    else//se agrega a la lista el producto con una unidad menos
                        listBoxInventario.Items[listBoxInventario.SelectedIndex] = nombreycantidad.ElementAt(0) + "x" + cantidadmenos1.ToString();

                    //codigo para mandar a la lista carrito el producto con el numero de veces que lo solicito (agregar al carrito)
                    //Buscar el producto tecleado y la cantidad para sacar la diferencia y mandar la cantidad de productos a vender
                    //Voy a buscar en el carrito si ya existe el producto del infentario
                    string productoEnCarritoTemp = "";
                    foreach (string productoCarrito in listBoxCarrito.Items)
                    {
                        if (productoCarrito.Contains(nombreycantidad.ElementAt(0)))
                            productoEnCarritoTemp = productoCarrito;
                    }
                    if (productoEnCarritoTemp != "")//si ya existe hay q sumarle una unidad a ese producto
                    {
                        string nombreProd = productoEnCarritoTemp.Split('x').ElementAt(0).ToString().Trim();
                        string infodelproducto = listaidProductoNombrePrecioCantidad.Find(x => x.Contains(nombreProd));
                        string[] arraytemp2 = infodelproducto.Split(',');//se obtiene toda la info del producto para obtener su precio mas adelante
                        string[] arraytemp = productoEnCarritoTemp.Split('x');
                        int cantidadTotal = Convert.ToInt32(arraytemp.ElementAt(1)) + 1;
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
                        total += Convert.ToDecimal(arraytemp2[2]);
                        //richTextBoxTotal.SelectionColor = Color.Lime;

                        //richTextBoxTotal.SelectionFont = new Font("Verdana", 15, FontStyle.Regular);
                        //richTextBoxTotal.SelectionColor = Color.Lime;

                        richTextBoxTotal.Text = "$" + total.ToString();

                        //para quitar la selccion
                        // listBoxInventario.ClearSelected();
                    }
                    else//si no existe se agrega por primera vez
                    {
                        string nombreProd = nombreycantidad.ElementAt(0).Trim();
                        string infodelproducto = listaidProductoNombrePrecioCantidad.Find(x => x.Contains(nombreProd));
                        string[] arraytemp = infodelproducto.Split(',');
                        int cantidadTotal = 1;
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

                        richTextBoxTotal.Text = "$" + total.ToString();

                        //para quitar la selccion
                         listBoxInventario.ClearSelected();
                    }
                }
                listBoxInventario.ClearSelected();

            }
            catch (Exception)
            {
                
              
            }
            
        }

        private void LimpiaListBoxCarrito()
        {
            int conttemp = 0;
            do
	        {
                string item = this.listBoxCarrito.Items[conttemp].ToString();
	            if (item == "")
                {
                    listBoxCarrito.Items.Remove(item);
                }
                conttemp++;

            } while (conttemp != this.listBoxCarrito.Items.Count && conttemp < this.listBoxCarrito.Items.Count);
                

	        
            
        }

        private void listBoxCarrito_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //listBoxCarrito.Items.RemoveAt(listBoxCarrito.SelectedIndex);
                //listBoxCarrito.Items.Add(dato);
                CargalistaidProductoNombrePrecioCantidad();
                LimpiaListBoxCarrito();
                //codigo para restar un producto en la lista carrito
                string dato = listBoxCarrito.Items[listBoxCarrito.SelectedIndex].ToString();
                string[] nombreycantidad = dato.Split('x');
                int cantidadmenos1 = Int32.Parse(nombreycantidad.ElementAt(1)) - 1;

                if (banderaNoPermiteModificarListBox)//si esta activada la bandera es por que se quiere pasar un producto del carrito al stock y no se puede
                {
                    MessageBox.Show("No se aceptan devoluciones!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
                else
                {
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
                        int cantidadTotal = 0;
                        if (cantidadmenos1 == 0)
                        {
                            cantidadTotal = Convert.ToInt32(arraytemp.ElementAt(3));
                        }
                        else
                            cantidadTotal = Convert.ToInt32(arraytemp.ElementAt(3)) - cantidadmenos1;
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
                        richTextBoxTotal.Text = "$" + total.ToString();
                        listBoxCarrito.ClearSelected();
                    
                   
                }
                listBoxCarrito.ClearSelected();
            }
            catch (Exception)
            {

         
            }
            
        }

        private void richTextBoxTotal_TextChanged(object sender, EventArgs e)
        {
           
        }
        private bool validaDatosEntrada()
        {
            if (textBoxDescripcionVenta.Text == "" || dateTimePickerFecha.Text == "" || listBoxCarrito.Items.Count <= 0 )
            {
                MessageBox.Show("Error de datos");
                return false;
            }

            return true;
        }
        private void limpiaCampos()
        {

            textBoxDescripcionVenta.Clear();
            richTextBoxTotal.Clear();
            dateTimePickerFecha.Value = DateTime.Now;
            listBoxCarrito.Items.Clear();

        }
        private int calculaCantidadProductos()
        { 
        
            int cantidad =0;

            foreach (string  producto in listBoxCarrito.Items)
            {
                string[] nombreycant = producto.Split('x');
                cantidad += Int32.Parse(nombreycant.ElementAt(1).ToString());
            }

            return cantidad;
        
        }
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if (!validaDatosEntrada())
                return;

            try
            {

                banderaNoPermiteModificarListBox = false;
                string fechaVenta = dateTimePickerFecha.Value.ToString("yyyy-MM-dd");
                string descripcion = textBoxDescripcionVenta.Text;
                string productos="";
                string quitarPrecio = "";
                string idproductonombreyNuevaCantidad = "";
                int cont = 1;
                List<string> listaDeProductoActualizado = new List<string>();
                foreach (string  producto in listBoxCarrito.Items)
                {
                    if (cont == listBoxCarrito.Items.Count)//para que no agrege una , al final

                    {
                        productos += producto ;
                        string[] nombreProdycantidadCarrito = producto.Split('x');//nombre y cantidad EN EL CARRITO
                        string nombreProducto = nombreProdycantidadCarrito.ElementAt(0).Trim();
                        string infodelproducto = listaidProductoNombrePrecioCantidad.Find(x => x.Contains(nombreProducto));
                        if (infodelproducto == null)
                            continue;
                        string[] idnombrecantidad = infodelproducto.Split(',');
                        List<string> listTemporal = new List<string>(idnombrecantidad);
                        listTemporal.RemoveAt(2);//para quitar el campo precio
                       // idnombrecantidad = idnombrecantidad.Where(w => w != idnombrecantidad[2]).ToArray(); 
                        int cantidadAModificarDelProducto = Int32.Parse(listTemporal.ElementAt(2)) - Int32.Parse(nombreProdycantidadCarrito.ElementAt(1));//el total de la cantidad del producto mas lo q se solicito en el carrito
                        idproductonombreyNuevaCantidad = listTemporal[0] + "," + listTemporal[1] + "," + cantidadAModificarDelProducto.ToString();
                        
                    }
                    else
                    {
                        productos += producto + ",";
                        string[] nombreProdycantidadCarrito = producto.Split('x');//nombre y cantidad
                        string nombreProducto = nombreProdycantidadCarrito.ElementAt(0).Trim();
                        string infodelproducto = listaidProductoNombrePrecioCantidad.Find(x => x.Contains(nombreProducto));
                        if (infodelproducto == null)
                            continue;
                        string[] idnombrecantidad = infodelproducto.Split(',');
                        List<string> listTemporal = new List<string>(idnombrecantidad);
                        listTemporal.RemoveAt(2);//para quitar el campo precio
                        // idnombrecantidad = idnombrecantidad.Where(w => w != idnombrecantidad[2]).ToArray(); 
                        int cantidadAModificarDelProducto = Int32.Parse(listTemporal.ElementAt(2)) - Int32.Parse(nombreProdycantidadCarrito.ElementAt(1));//el total de la cantidad del producto mas lo q se solicito en el carrito
                        idproductonombreyNuevaCantidad = listTemporal[0] + "," + listTemporal[1] + "," + cantidadAModificarDelProducto.ToString();
                    }
                    listaDeProductoActualizado.Add(idproductonombreyNuevaCantidad);
                    cont++;
                }

                string totalS = richTextBoxTotal.Text.ToString();
                totalS = totalS.Remove(0,1);//hay q quitar el signo de pesos si no no lo converte a decimal
                decimal total = decimal.Parse(totalS);
                int cantidadProductos = calculaCantidadProductos();
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
                    case "Horizontal":
                        //si es insercion se hace en el sitio de la condicion          

                        break;
                    case "Vertical":

                        break;
                    case "Replica":
                        //insertar en ambos sitios
                        //si es insercion se hace en el sitio de la condicion
                        try
                        {
                            if (sitios.ElementAt(0).Contains("1"))
                            {
                                //Insercion en sql server sitio1
                                string consulta = "Insert into " + nombreTablaBDFragmento.ElementAt(0).ToString() + " values('" + fechaVenta + "','" + descripcion + "','" + productos + "'," + cantidadProductos + "," + total + ")";
                                cmd = new SqlCommand(consulta, cnSQL);
                                cmd.ExecuteNonQuery();
                                cargaTabla();
                                limpiaCampos();
                                //fin de insercion

                                //Insercion en NPG sitio2
                                NpgsqlCommand command = new NpgsqlCommand("Insert into " + nombreTablaBDFragmento.ElementAt(1).ToString() + " (fecha,descripción,productos,cantidad,total) values('" + fechaVenta +"','" + descripcion + "','" + productos + "'," + cantidadProductos + "," + total + ")", conNPG);
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                //Insercion en sql server sitio1
                                string consulta = "Insert into " + nombreTablaBDFragmento.ElementAt(1).ToString() + " values('" + fechaVenta + "','" + descripcion + "','" + productos + "'," + cantidadProductos + "," + total + ")";
                                cmd = new SqlCommand(consulta, cnSQL);
                                cmd.ExecuteNonQuery();
                                cargaTabla();
                                limpiaCampos();
                                //fin de insercion

                                //Insercion en NPG sitio2
                                NpgsqlCommand command = new NpgsqlCommand("Insert into " + nombreTablaBDFragmento.ElementAt(0).ToString() + " (fecha,descripción,productos,cantidad,total) values('" + fechaVenta + "','" + descripcion + "','" + productos + "'," + cantidadProductos + "," + total + ")", conNPG);
                                command.ExecuteNonQuery();
                            }



                        }
                        catch (Exception error)
                        {

                            MessageBox.Show("ERROR al insertar : " + error.Message);
                        }

                        break;

                    default:
                        switch (sitios.ElementAt(0))
                        {
                            case "1":
                                //Insercion en sql server
                                string consulta = "Insert into " + nombreTablaBDFragmento.ElementAt(0).ToString() + " values('" + fechaVenta + "','" + descripcion + "','" + productos + "'," + cantidadProductos + "," + total + ")";
                                cmd = new SqlCommand(consulta, cnSQL);
                                cmd.ExecuteNonQuery();
                                cargaTabla();
                                limpiaCampos();

                                break;


                            case "2":

                                NpgsqlCommand command = new NpgsqlCommand("Insert into " + nombreTablaBDFragmento.ElementAt(0).ToString() + " (fecha,descripción,productos,cantidad,total) values('" + fechaVenta + "','" + descripcion + "','" + productos + "'," + cantidadProductos + "," + total + ")", conNPG);
                                command.ExecuteNonQuery();
                                cargaTabla();
                                limpiaCampos();
                                //si se inserto hacer la actualizacion en la tabla productos--------------
                                //Validacion en esquema de localizacion---------------------------------------------------------------------------------------------------------------
                                //variables necesarias para sacar datos del esquema de localizacion
                                idFragmentos = new List<string>();
                                nombreTablaBDFragmento = new List<string>();
                                nombreTablaGeneral = "";
                                tipoFragmento = "";
                                sitios = new List<string>();
                                condicion = new List<string>();
                                st = new SitioCentral();
                                st.LeeEsquemaLocalizacion("Producto", ref idFragmentos, ref nombreTablaBDFragmento, ref nombreTablaGeneral, ref sitios, ref tipoFragmento, ref condicion);
                                switch (tipoFragmento)
                                {
                                    case "Horizontal":

                                        break;
                                    case "Vertical":

                                        break;
                                    case "Replica":

                                        if (sitios.ElementAt(0).Contains("1"))
                                        {
                                            foreach (string item in listaDeProductoActualizado)
                                            {
                                                if (item.Split(',').ElementAt(2) != "0")
                                                {
                                                    string consultaS = "UPDATE " + nombreTablaBDFragmento[0].ToString() + " SET cantidad=" + item.Split(',').ElementAt(2) + "  WHERE id_Producto = " + item.Split(',').ElementAt(0) + "";
                                                    cmd = new SqlCommand(consultaS, cnSQL);
                                                    cmd.ExecuteNonQuery();
                                                    //modificar en postgresql
                                                    command = new NpgsqlCommand("UPDATE " + nombreTablaBDFragmento[1].ToString() + " SET cantidad=" + item.Split(',').ElementAt(2) + "  WHERE id_Producto = " + item.Split(',').ElementAt(0) + "", conNPG);
                                                    command.ExecuteNonQuery();
                                                }
                                                else
                                                //se elimina el producto si se vendio toda la cantidad
                                                {
                                                    string consultaS = "DELETE FROM " + nombreTablaBDFragmento[0].ToString() + " WHERE id_Producto = " + item.Split(',').ElementAt(0) + "";
                                                    cmd = new SqlCommand(consultaS, cnSQL);
                                                    cmd.ExecuteNonQuery();
                                                    //modificar en postgresql
                                                    command = new NpgsqlCommand("DELETE FROM " + nombreTablaBDFragmento[1].ToString() + " WHERE id_Producto = " + item.Split(',').ElementAt(0) + "", conNPG);
                                                    command.ExecuteNonQuery();

                                                }
                                            }
                                            
                                        }
                                        else
                                        {


                                            foreach (string item in listaDeProductoActualizado)
                                            {
                                                if (item.Split(',').ElementAt(2) != "0")
                                                {
                                                    string consultaS = "UPDATE " + nombreTablaBDFragmento[1].ToString() + " SET cantidad=" + item.Split(',').ElementAt(2) + "  WHERE id_Producto = " + item.Split(',').ElementAt(0) + "";
                                                    cmd = new SqlCommand(consultaS, cnSQL);
                                                    cmd.ExecuteNonQuery();
                                                    //modificar en postgresql
                                                    command = new NpgsqlCommand("UPDATE " + nombreTablaBDFragmento[0].ToString() + " SET cantidad=" + item.Split(',').ElementAt(2) + "  WHERE id_Producto = " + item.Split(',').ElementAt(0) + "", conNPG);
                                                    command.ExecuteNonQuery();
                                                }
                                                else
                                                //se elimina el producto si se vendio toda la cantidad
                                                {
                                                    string consultaS = "DELETE FROM " + nombreTablaBDFragmento[1].ToString() + " WHERE id_Producto = " + item.Split(',').ElementAt(0) + "";
                                                    cmd = new SqlCommand(consultaS, cnSQL);
                                                    cmd.ExecuteNonQuery();
                                                    //modificar en postgresql
                                                    command = new NpgsqlCommand("DELETE FROM " + nombreTablaBDFragmento[0].ToString() + " WHERE id_Producto = " + item.Split(',').ElementAt(0) + "", conNPG);
                                                    command.ExecuteNonQuery();

                                                }
                                            }


                                        }
                                        break;

                                    default:

                                        switch (sitios.ElementAt(0))
                                        {
                                            case "1":
                                                foreach (string item in listaDeProductoActualizado)
                                                {
                                                    if (item.Split(',').ElementAt(2) != "0")
                                                    {
                                                        string consultaS = "UPDATE " + nombreTablaBDFragmento[0].ToString() + " SET cantidad=" + item.Split(',').ElementAt(2) + "  WHERE id_Producto = " + item.Split(',').ElementAt(0) + "";
                                                        cmd = new SqlCommand(consultaS, cnSQL);
                                                        cmd.ExecuteNonQuery();
                                                       
                                                    }
                                                    else
                                                    //se elimina el producto si se vendio toda la cantidad
                                                    {
                                                        string consultaS = "DELETE FROM " + nombreTablaBDFragmento[0].ToString() + " WHERE id_Producto = " + item.Split(',').ElementAt(0) + "";
                                                        cmd = new SqlCommand(consultaS, cnSQL);
                                                        cmd.ExecuteNonQuery();
                                                        

                                                    }
                                                }


                                                break;


                                            case "2":
                                                foreach (string item in listaDeProductoActualizado)
                                                {
                                                    if (item.Split(',').ElementAt(2) != "0")
                                                    {
                                                        
                                                        //modificar en postgresql
                                                        command = new NpgsqlCommand("UPDATE " + nombreTablaBDFragmento[0].ToString() + " SET cantidad=" + item.Split(',').ElementAt(2) + "  WHERE id_Producto = " + item.Split(',').ElementAt(0) + "", conNPG);
                                                        command.ExecuteNonQuery();
                                                    }
                                                    else
                                                    //se elimina el producto si se vendio toda la cantidad
                                                    {
                                                        
                                                        //modificar en postgresql
                                                        command = new NpgsqlCommand("DELETE FROM " + nombreTablaBDFragmento[0].ToString() + " WHERE id_Producto = " + item.Split(',').ElementAt(0) + "", conNPG);
                                                        command.ExecuteNonQuery();

                                                    }
                                                }
                                                break;
                                        }

                                        break;
                                }
                                ///fin de actualizacion
                                break;
                        }
                        break;
                }

                CargalistaidProductoNombrePrecioCantidad();
                cargaCOMBOListBoxInventarioProductos();
                total = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("no se inserto" + ex.Message);
            }
        }

        private void dataGridViewVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                banderaNoPermiteModificarListBox = true;
                if (banderaNoPermiteModificarListBox)
                    BtnInsertar.Enabled = false;
                limpiaCampos();
                dateTimePickerFecha.Text = dataGridViewVenta.CurrentRow.Cells[1].Value.ToString();
                textBoxDescripcionVenta.Text = dataGridViewVenta.CurrentRow.Cells[2].Value.ToString();
                string[] productos = dataGridViewVenta.CurrentRow.Cells[3].Value.ToString().Split(',');
                foreach (string item in productos)
                {
                    listBoxCarrito.Items.Add(item);
                }
                string temporalTotal = richTextBoxTotal.Text = dataGridViewVenta.CurrentRow.Cells[5].Value.ToString();
                richTextBoxTotal.Text = richTextBoxTotal.Text.Insert(0, "$");
                total = decimal.Parse(temporalTotal);
                

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error en el datagrid cellclick" + ex);
                BtnInsertar.Enabled = true ;
                banderaNoPermiteModificarListBox = false;
                CargalistaidProductoNombrePrecioCantidad();
                cargaCOMBOListBoxInventarioProductos();
                total = 0;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!validaDatosEntrada())
                return;

            try
            {
                banderaNoPermiteModificarListBox = false;
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
                    case "Horizontal":

                        break;
                    case "Vertical":
                        break;
                    case "Replica":
                        //Eliminar en ambos sitios
                        try
                        {
                            if (sitios.ElementAt(0).Contains("1"))
                            {
                                //eliminar en sql server
                                string consulta = "DELETE FROM " + nombreTablaBDFragmento.ElementAt(0).ToString() + " WHERE id_Venta = " + dataGridViewVenta.CurrentRow.Cells[0].Value.ToString() + "";
                                cmd = new SqlCommand(consulta, cnSQL);
                                cmd.ExecuteNonQuery();
                                //eliminar en postgressql
                                NpgsqlCommand command = new NpgsqlCommand("DELETE FROM " + nombreTablaBDFragmento.ElementAt(1).ToString() + " WHERE id_Venta = " + dataGridViewVenta.CurrentRow.Cells[0].Value.ToString() + "", conNPG);
                                command.ExecuteNonQuery();
                                
                            }
                            else
                            {

                                //eliminar en sql server
                                string consulta = "DELETE FROM " + nombreTablaBDFragmento.ElementAt(1).ToString() + " WHERE id_Venta = " + dataGridViewVenta.CurrentRow.Cells[0].Value.ToString() + "";
                                cmd = new SqlCommand(consulta, cnSQL);
                                cmd.ExecuteNonQuery();
                                //eliminar en postgressql
                                NpgsqlCommand command = new NpgsqlCommand("DELETE FROM " + nombreTablaBDFragmento.ElementAt(0).ToString() + " WHERE id_Venta = " + dataGridViewVenta.CurrentRow.Cells[0].Value.ToString() + "", conNPG);
                                command.ExecuteNonQuery();
                         
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                        break;

                    default:
                        switch (sitios.ElementAt(0))
                        {
                            case "1":
                                //Insercion en sql server
                                string consulta = "DELETE FROM " + nombreTablaBDFragmento.ElementAt(0).ToString() + " WHERE id_Venta = " + dataGridViewVenta.CurrentRow.Cells[0].Value.ToString() + "";
                                cmd = new SqlCommand(consulta, cnSQL);
                                cmd.ExecuteNonQuery();
                        

                                break;


                            case "2":

                                NpgsqlCommand command = new NpgsqlCommand("DELETE FROM " + nombreTablaBDFragmento.ElementAt(0).ToString() + " WHERE id_Venta = " + dataGridViewVenta.CurrentRow.Cells[0].Value.ToString() + "", conNPG);
                                command.ExecuteNonQuery();
                           

                                break;
                        }
                        break;
                }
         
                    cargaTabla();
                    limpiaCampos();
      
                BtnInsertar.Enabled = true;
                CargalistaidProductoNombrePrecioCantidad();
                cargaCOMBOListBoxInventarioProductos();
                total = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("no se inserto" + ex.Message);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            banderaNoPermiteModificarListBox = false;
            if (!validaDatosEntrada())
                return;

            try
            {

                string fecha = dateTimePickerFecha.Value.ToString("yyyy-MM-dd");
                string descripcion = textBoxDescripcionVenta.Text;

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
                    case "Horizontal":
                        //si es insercion se hace en el sitio de la condicion          

                        break;
                    case "Vertical":

                        break;
                    case "Replica":
                        //modifcar en ambos sitios

                        if (sitios.ElementAt(0).Contains("1"))
                        {
                            //MODIFICACION en sql server
                            string consulta = "UPDATE " + nombreTablaBDFragmento.ElementAt(0).ToString() + " SET descripción = '" + descripcion + "',fecha ='" + fecha + "' WHERE id_Venta = " + dataGridViewVenta.CurrentRow.Cells[0].Value.ToString() + "";
                            cmd = new SqlCommand(consulta, cnSQL);
                            cmd.ExecuteNonQuery();
                            //modificar en postgresql
                            NpgsqlCommand command = new NpgsqlCommand("UPDATE " + nombreTablaBDFragmento.ElementAt(1).ToString() + " SET descripción = '" + descripcion + "',fecha ='" + fecha + "' WHERE id_Venta = " + dataGridViewVenta.CurrentRow.Cells[0].Value.ToString() + "", conNPG);
                            command.ExecuteNonQuery();
                            cargaTabla();
                            limpiaCampos();
                        }
                        else
                        {
                            //MODIFICACION en sql server
                            string consulta = "UPDATE " + nombreTablaBDFragmento.ElementAt(1).ToString() + " SET descripción = '" + descripcion + "',fecha ='" + fecha + "' WHERE id_Venta = " + dataGridViewVenta.CurrentRow.Cells[0].Value.ToString() + "";
                            cmd = new SqlCommand(consulta, cnSQL);
                            cmd.ExecuteNonQuery();
                            //modificar en postgresql
                            NpgsqlCommand command = new NpgsqlCommand("UPDATE " + nombreTablaBDFragmento.ElementAt(0).ToString() + " SET descripción = '" + descripcion + "',fecha ='" + fecha + "' WHERE id_Venta = " + dataGridViewVenta.CurrentRow.Cells[0].Value.ToString() + "", conNPG);
                            command.ExecuteNonQuery();
                            cargaTabla();
                            limpiaCampos();
                        }
                        break;


                    default:
                        switch (sitios.ElementAt(0))
                        {
                            case "1":
                                //Insercion en sql server
                                string consultaS = "UPDATE " + nombreTablaBDFragmento.ElementAt(0).ToString() + " SET descripción = '" + descripcion + "',fecha ='" + fecha + "' WHERE id_Venta = " + dataGridViewVenta.CurrentRow.Cells[0].Value.ToString() + "";
                                cmd = new SqlCommand(consultaS, cnSQL);
                                cmd.ExecuteNonQuery();
                                cargaTabla();
                                limpiaCampos();

                                break;


                            case "2":

                                NpgsqlCommand commandS = new NpgsqlCommand("UPDATE " + nombreTablaBDFragmento.ElementAt(0).ToString() + " SET descripción = '" + descripcion + "',fecha ='" + fecha + "' WHERE id_Venta = " + dataGridViewVenta.CurrentRow.Cells[0].Value.ToString() + "", conNPG);
                                commandS.ExecuteNonQuery();
                                cargaTabla();
                                limpiaCampos();

                                break;
                        }
                        break;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("no se modifico" + ex.Message);
            }
            BtnInsertar.Enabled = true;
            CargalistaidProductoNombrePrecioCantidad();
            cargaCOMBOListBoxInventarioProductos();
            total = 0;
        }
    }
}