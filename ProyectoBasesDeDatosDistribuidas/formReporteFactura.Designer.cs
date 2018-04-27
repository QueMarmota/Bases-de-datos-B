namespace ProyectoBasesDeDatosDistribuidas
{
    partial class formReporteFactura
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
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.listBoxVenta = new System.Windows.Forms.ListBox();
            this.dataGridViewProveedor = new System.Windows.Forms.DataGridView();
            this.btn_Genera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewVenta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Location = new System.Drawing.Point(358, 142);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewProducto.TabIndex = 14;
            this.dataGridViewProducto.Visible = false;
            // 
            // listBoxVenta
            // 
            this.listBoxVenta.FormattingEnabled = true;
            this.listBoxVenta.Location = new System.Drawing.Point(29, 83);
            this.listBoxVenta.Name = "listBoxVenta";
            this.listBoxVenta.Size = new System.Drawing.Size(309, 121);
            this.listBoxVenta.TabIndex = 13;
            this.listBoxVenta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxVenta_MouseDown);
            // 
            // dataGridViewProveedor
            // 
            this.dataGridViewProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProveedor.Location = new System.Drawing.Point(347, 66);
            this.dataGridViewProveedor.Name = "dataGridViewProveedor";
            this.dataGridViewProveedor.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewProveedor.TabIndex = 12;
            this.dataGridViewProveedor.Visible = false;
            // 
            // btn_Genera
            // 
            this.btn_Genera.Location = new System.Drawing.Point(106, 244);
            this.btn_Genera.Name = "btn_Genera";
            this.btn_Genera.Size = new System.Drawing.Size(148, 23);
            this.btn_Genera.TabIndex = 11;
            this.btn_Genera.Text = "Genera Reporte";
            this.btn_Genera.UseVisualStyleBackColor = true;
            this.btn_Genera.Click += new System.EventHandler(this.btn_Genera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecciona Venta";
            // 
            // dataGridViewVenta
            // 
            this.dataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenta.Location = new System.Drawing.Point(374, 196);
            this.dataGridViewVenta.Name = "dataGridViewVenta";
            this.dataGridViewVenta.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewVenta.TabIndex = 15;
            this.dataGridViewVenta.Visible = false;
            // 
            // formReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 307);
            this.Controls.Add(this.dataGridViewVenta);
            this.Controls.Add(this.dataGridViewProducto);
            this.Controls.Add(this.listBoxVenta);
            this.Controls.Add(this.dataGridViewProveedor);
            this.Controls.Add(this.btn_Genera);
            this.Controls.Add(this.label1);
            this.Name = "formReporteFactura";
            this.Text = "formReporteFactura";
            this.Load += new System.EventHandler(this.formReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducto;
        private System.Windows.Forms.ListBox listBoxVenta;
        private System.Windows.Forms.DataGridView dataGridViewProveedor;
        private System.Windows.Forms.Button btn_Genera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewVenta;
    }
}