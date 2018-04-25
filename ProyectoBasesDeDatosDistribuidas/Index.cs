using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBasesDeDatosDistribuidas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.ShowDialog();
            emp.Dispose();
        }

        private void Index_Load(object sender, EventArgs e)
        {   
            /*Image imagen = new Bitmap(@"..\..\..\logo.jpg");
            this.BackgroundImage = imagen;*/
        
            

        }

        private void BtnSucursal_Click(object sender, EventArgs e)
        {
            Sucursal suc = new Sucursal();
            suc.ShowDialog();
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            Proveedor prov = new Proveedor();
            prov.ShowDialog();
        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.ShowDialog();
        }

        private void BtnOferta_Click(object sender, EventArgs e)
        {
            Oferta of = new Oferta();
            of.ShowDialog();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.ShowDialog();
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            FormReporteFiltro reporte = new FormReporteFiltro();
            reporte.Show();

        }

   

    }
}
