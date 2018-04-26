namespace ProyectoBasesDeDatosDistribuidas
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BtnEmpleado = new System.Windows.Forms.Button();
            this.BtnSucursal = new System.Windows.Forms.Button();
            this.BtnProveedor = new System.Windows.Forms.Button();
            this.BtnVenta = new System.Windows.Forms.Button();
            this.BtnOferta = new System.Windows.Forms.Button();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_ReporteProveedor = new System.Windows.Forms.Button();
            this.btn_Factura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEmpleado
            // 
            this.BtnEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEmpleado.Location = new System.Drawing.Point(100, 130);
            this.BtnEmpleado.Name = "BtnEmpleado";
            this.BtnEmpleado.Size = new System.Drawing.Size(75, 23);
            this.BtnEmpleado.TabIndex = 0;
            this.BtnEmpleado.Text = "Empleado";
            this.BtnEmpleado.UseVisualStyleBackColor = false;
            this.BtnEmpleado.Click += new System.EventHandler(this.BtnEmpleado_Click);
            // 
            // BtnSucursal
            // 
            this.BtnSucursal.Location = new System.Drawing.Point(223, 130);
            this.BtnSucursal.Name = "BtnSucursal";
            this.BtnSucursal.Size = new System.Drawing.Size(75, 23);
            this.BtnSucursal.TabIndex = 1;
            this.BtnSucursal.Text = "Sucursal";
            this.BtnSucursal.UseVisualStyleBackColor = true;
            this.BtnSucursal.Click += new System.EventHandler(this.BtnSucursal_Click);
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.Location = new System.Drawing.Point(349, 130);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Size = new System.Drawing.Size(75, 23);
            this.BtnProveedor.TabIndex = 2;
            this.BtnProveedor.Text = "Proveedor";
            this.BtnProveedor.UseVisualStyleBackColor = true;
            this.BtnProveedor.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // BtnVenta
            // 
            this.BtnVenta.Location = new System.Drawing.Point(480, 130);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Size = new System.Drawing.Size(113, 23);
            this.BtnVenta.TabIndex = 3;
            this.BtnVenta.Text = "Venta";
            this.BtnVenta.UseVisualStyleBackColor = true;
            this.BtnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // BtnOferta
            // 
            this.BtnOferta.Location = new System.Drawing.Point(232, 220);
            this.BtnOferta.Name = "BtnOferta";
            this.BtnOferta.Size = new System.Drawing.Size(75, 23);
            this.BtnOferta.TabIndex = 4;
            this.BtnOferta.Text = "Oferta";
            this.BtnOferta.UseVisualStyleBackColor = true;
            this.BtnOferta.Click += new System.EventHandler(this.BtnOferta_Click);
            // 
            // BtnProducto
            // 
            this.BtnProducto.Location = new System.Drawing.Point(349, 220);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(75, 23);
            this.BtnProducto.TabIndex = 5;
            this.BtnProducto.Text = "Producto";
            this.BtnProducto.UseVisualStyleBackColor = true;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.Location = new System.Drawing.Point(287, 305);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(110, 23);
            this.btn_reporte.TabIndex = 6;
            this.btn_reporte.Text = "Reporte-Empleado";
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // btn_ReporteProveedor
            // 
            this.btn_ReporteProveedor.Location = new System.Drawing.Point(480, 304);
            this.btn_ReporteProveedor.Name = "btn_ReporteProveedor";
            this.btn_ReporteProveedor.Size = new System.Drawing.Size(130, 23);
            this.btn_ReporteProveedor.TabIndex = 7;
            this.btn_ReporteProveedor.Text = "Reporte-Proveedor";
            this.btn_ReporteProveedor.UseVisualStyleBackColor = true;
            this.btn_ReporteProveedor.Click += new System.EventHandler(this.btn_ReporteProveedor_Click);
            // 
            // btn_Factura
            // 
            this.btn_Factura.Location = new System.Drawing.Point(77, 305);
            this.btn_Factura.Name = "btn_Factura";
            this.btn_Factura.Size = new System.Drawing.Size(127, 23);
            this.btn_Factura.TabIndex = 8;
            this.btn_Factura.Text = "Reporte-Factura";
            this.btn_Factura.UseVisualStyleBackColor = true;
            this.btn_Factura.Click += new System.EventHandler(this.btn_Factura_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 360);
            this.Controls.Add(this.btn_Factura);
            this.Controls.Add(this.btn_ReporteProveedor);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.BtnProducto);
            this.Controls.Add(this.BtnOferta);
            this.Controls.Add(this.BtnVenta);
            this.Controls.Add(this.BtnProveedor);
            this.Controls.Add(this.BtnSucursal);
            this.Controls.Add(this.BtnEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.Text = "SuperTienda";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEmpleado;
        private System.Windows.Forms.Button BtnSucursal;
        private System.Windows.Forms.Button BtnProveedor;
        private System.Windows.Forms.Button BtnVenta;
        private System.Windows.Forms.Button BtnOferta;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_ReporteProveedor;
        private System.Windows.Forms.Button btn_Factura;
    }
}

