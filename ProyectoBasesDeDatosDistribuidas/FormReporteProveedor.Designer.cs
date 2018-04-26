namespace ProyectoBasesDeDatosDistribuidas
{
    partial class FormReporteProveedor
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
            this.listBoxProveedor = new System.Windows.Forms.ListBox();
            this.dataGridViewProveedor = new System.Windows.Forms.DataGridView();
            this.btn_Genera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxProveedor
            // 
            this.listBoxProveedor.FormattingEnabled = true;
            this.listBoxProveedor.Location = new System.Drawing.Point(25, 78);
            this.listBoxProveedor.Name = "listBoxProveedor";
            this.listBoxProveedor.Size = new System.Drawing.Size(309, 121);
            this.listBoxProveedor.TabIndex = 8;
            this.listBoxProveedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxProveedor_MouseDown);
            // 
            // dataGridViewProveedor
            // 
            this.dataGridViewProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProveedor.Location = new System.Drawing.Point(343, 61);
            this.dataGridViewProveedor.Name = "dataGridViewProveedor";
            this.dataGridViewProveedor.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewProveedor.TabIndex = 7;
            this.dataGridViewProveedor.Visible = false;
            // 
            // btn_Genera
            // 
            this.btn_Genera.Location = new System.Drawing.Point(102, 239);
            this.btn_Genera.Name = "btn_Genera";
            this.btn_Genera.Size = new System.Drawing.Size(148, 23);
            this.btn_Genera.TabIndex = 6;
            this.btn_Genera.Text = "Genera Reporte";
            this.btn_Genera.UseVisualStyleBackColor = true;
            this.btn_Genera.Click += new System.EventHandler(this.btn_Genera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecciona Proveedor";
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Location = new System.Drawing.Point(354, 137);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewProducto.TabIndex = 9;
            this.dataGridViewProducto.Visible = false;
            // 
            // FormReporteProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 299);
            this.Controls.Add(this.dataGridViewProducto);
            this.Controls.Add(this.listBoxProveedor);
            this.Controls.Add(this.dataGridViewProveedor);
            this.Controls.Add(this.btn_Genera);
            this.Controls.Add(this.label1);
            this.Name = "FormReporteProveedor";
            this.Text = "FormReporteProveedor";
            this.Load += new System.EventHandler(this.FormReporteProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProveedor;
        private System.Windows.Forms.DataGridView dataGridViewProveedor;
        private System.Windows.Forms.Button btn_Genera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProducto;
    }
}