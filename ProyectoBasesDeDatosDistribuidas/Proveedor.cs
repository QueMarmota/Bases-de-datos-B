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
    public partial class Proveedor : Form
    {
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

        private void MezclaBDHorizontal() {
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

           // dt.Merge(dtNPG);
            
            //Hacer merge entre los dos select del sito1 y el sitio2
            foreach (var column in dtNPG.Columns)
            {
                if (column.ToString().Contains("id"))//esto con la finalidad de corregir por q el ide copia el daato en las celdas que se llaman igual
                    dt.Columns.Add(column.ToString()+"2");
                else
                    dt.Columns.Add(column.ToString());
            }
         
            int numberOfColumns = dt.Columns.Count;
            int contadorRows = 0;
            //para esconder el campor id
           // dataGridViewProveedor.Columns[0].Visible = false;
           // dataGridViewProveedor.Columns[4].Visible = false;

            // go through each row
            foreach (DataRow dr in dt.Rows)
            {
                // go through each column in the row
                for (int i = dtNPG.Columns.Count; i < numberOfColumns-1; i++)//-2 por q adelante le sumo mas 2
                {
                    // access cell as set or get
                    var dato = dtNPG.Rows[contadorRows][(i - dtNPG.Columns.Count)];
                     dr[i+1] = dato;//+| para evitar q copie el idproveedor de la base de datos de npg
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

        public Proveedor()
        {

            InitializeComponent();
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
            cargaTabla();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if (!validaDatosEntrada())
                return;

            string nombre = textBoxNombre.Text;
            string telefono = textBoxTelefono.Text;
            string direccion = textBoxDireccion.Text;
            string email = textBoxEmail.Text;
            string tipo = comboBoxTipo.SelectedItem.ToString();
            int idProveedor = Int32.Parse(textBoxidProveedor.Text);
            try
            {
            //Validacion en esquema de localizacion---------------------------------------------------------------------------------------------------------------
                    //variables necesarias para sacar datos del esquema de localizacion
                    List<string> idFragmentos = new List<string>();
                    List<string> nombreTablaBDFragmento = new List<string>();
                    string nombreTablaGeneral="" ;
                    string tipoFragmento="";
                    List<string> sitios = new List<string>();
                    List<string> condicion = new List<string>();               
                SitioCentral st = new SitioCentral();
                st.LeeEsquemaLocalizacion("Proveedor", ref idFragmentos, ref nombreTablaBDFragmento, ref nombreTablaGeneral, ref sitios, ref tipoFragmento, ref condicion);
            
               
                switch (tipoFragmento)
                {
                    case "Horizontal":
                       
                        break;
                    case "Vertical":
                        try
                        {
                            List<string> atributosSitio1 = new List<string>();
                            List<string> atributosSitio2 = new List<string>();
                            st.LeeEsquemaAtributos(idFragmentos, ref atributosSitio1, ref atributosSitio2);
                            //Insercion en sql server
                            string consulta = "Insert into " + nombreTablaBDFragmento[0].ToString() + " values(" + idProveedor + ",'" + textBoxNombre.Text + "','" + textBoxEmail.Text + "','" + textBoxTelefono.Text + "')";
                            cmd = new SqlCommand(consulta, cnSQL);
                           // dr.Close();
                            cmd.ExecuteNonQuery();
                 
                            //fin de insercion                   
                            NpgsqlCommand command = new NpgsqlCommand("Insert into " + nombreTablaBDFragmento[1].ToString() + "(id_Proveedor,direccion,tipo) values(" + idProveedor + ",'" + textBoxDireccion.Text + "','" + comboBoxTipo.Text + "')", conNPG);
                           // dr.Close();
                            command.ExecuteNonQuery();
                                        
                            }
                            catch (Exception error)
                            {

                                MessageBox.Show("ERROR al insertar en NPG: " + error.Message);
                            }
             
                            cargaTabla();
                            limpiarCampos();

                        break;
                    case "Replica":

                        //insertar en ambos sitios


                        break;

                    default:
                        break;
                }             
           
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("no se inserto"+ex.Message);
            }
        }

        private void limpiarCampos()
        {
            textBoxDireccion.Clear(); textBoxEmail.Clear();
            textBoxNombre.Clear();
            textBoxTelefono.Clear();
            comboBoxTipo.Text = "";
            textBoxidProveedor.Text = "";              
        }

        private bool validaDatosEntrada()
        {
            if (textBoxidProveedor.Text=="" ||textBoxNombre.Text == "" || textBoxDireccion.Text == "" || textBoxTelefono.Text == "" || textBoxEmail.Text == "" || comboBoxTipo.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Error de datos");
                return false;
            }           
            return true;
        }

        private void dataGridViewProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxNombre.Text = dataGridViewProveedor.CurrentRow.Cells[1].Value.ToString();
                textBoxEmail.Text = dataGridViewProveedor.CurrentRow.Cells[2].Value.ToString();
                textBoxTelefono.Text = dataGridViewProveedor.CurrentRow.Cells[3].Value.ToString();
                textBoxDireccion.Text = dataGridViewProveedor.CurrentRow.Cells[5].Value.ToString();
                comboBoxTipo.Text = dataGridViewProveedor.CurrentRow.Cells[6].Value.ToString();
                textBoxidProveedor.Text = dataGridViewProveedor.CurrentRow.Cells[0].Value.ToString();
            
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en datagrid" + ex);
            }
           

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
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
                       
                        break;
                    case "Vertical":
                        try
                        {
                            //eliminar en sql server
                            string consulta = "DELETE FROM " + nombreTablaBDFragmento[0].ToString() + " WHERE id_Proveedor = " + dataGridViewProveedor.CurrentRow.Cells[0].Value.ToString() + "";
                            cmd = new SqlCommand(consulta, cnSQL);
                            cmd.ExecuteNonQuery();
                            //eliminar en postgressql
                            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM " + nombreTablaBDFragmento[1].ToString() + " WHERE id_Proveedor = " + dataGridViewProveedor.CurrentRow.Cells[4].Value.ToString() + "", conNPG);
                            command.ExecuteNonQuery();
                            cargaTabla();
                            limpiarCampos();
                        }
                        catch (Exception)
                        {
                            
                            throw;
                        }
                       


                        break;
                    case "Replica":

                        //insertar en ambos sitios


                        break;

                    default:
                        break;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("no se inserto" + ex.Message);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (!validaDatosEntrada())
                return;
            try 
	        {	        
		

            string nombre = textBoxNombre.Text;
            string telefono = textBoxTelefono.Text;
            string direccion = textBoxDireccion.Text;
            string email = textBoxEmail.Text;
            string tipo = comboBoxTipo.SelectedItem.ToString();

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
                      
                        break;
                    case "Vertical":
                        //MODIFICACION en sql server
                        string consulta = "UPDATE " + nombreTablaBDFragmento[0].ToString() + " SET nombre = '" + nombre + "', email = '" + email + "',teléfono = '" + telefono + "' WHERE id_Proveedor = " + dataGridViewProveedor.CurrentRow.Cells[0].Value.ToString() + "";
                        cmd = new SqlCommand(consulta, cnSQL);
                        cmd.ExecuteNonQuery();
                        //modificar en postgresql
                        NpgsqlCommand command = new NpgsqlCommand("UPDATE " + nombreTablaBDFragmento[1].ToString() + " SET direccion = '" + direccion + "', tipo = '" +tipo + "' WHERE id_Proveedor = " + dataGridViewProveedor.CurrentRow.Cells[4].Value.ToString() + "", conNPG);
                        command.ExecuteNonQuery();
                        cargaTabla();
                        limpiarCampos();
                        break;
                    case "Replica":

                        //insertar en ambos sitios


                        break;

                    default:
                        break;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("no se inserto" + ex.Message);
            }

        }
    }
}
