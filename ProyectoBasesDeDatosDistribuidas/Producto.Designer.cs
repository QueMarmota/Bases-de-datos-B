namespace ProyectoBasesDeDatosDistribuidas
{
    partial class Producto
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCaducidad = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.numericPrecio = new System.Windows.Forms.NumericUpDown();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerCaducidad = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxidProveedor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(64, 83);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(140, 80);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(64, 122);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio";
            // 
            // labelCaducidad
            // 
            this.labelCaducidad.AutoSize = true;
            this.labelCaducidad.Location = new System.Drawing.Point(64, 159);
            this.labelCaducidad.Name = "labelCaducidad";
            this.labelCaducidad.Size = new System.Drawing.Size(58, 13);
            this.labelCaducidad.TabIndex = 3;
            this.labelCaducidad.Text = "Caducidad";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(64, 191);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(49, 13);
            this.labelCantidad.TabIndex = 4;
            this.labelCantidad.Text = "Cantidad";
            // 
            // numericPrecio
            // 
            this.numericPrecio.Location = new System.Drawing.Point(140, 120);
            this.numericPrecio.Name = "numericPrecio";
            this.numericPrecio.Size = new System.Drawing.Size(120, 20);
            this.numericPrecio.TabIndex = 5;
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(140, 189);
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(120, 20);
            this.numericCantidad.TabIndex = 6;
            // 
            // dateTimePickerCaducidad
            // 
            this.dateTimePickerCaducidad.Location = new System.Drawing.Point(140, 151);
            this.dateTimePickerCaducidad.Name = "dateTimePickerCaducidad";
            this.dateTimePickerCaducidad.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCaducidad.TabIndex = 7;
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Location = new System.Drawing.Point(51, 228);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.Size = new System.Drawing.Size(490, 150);
            this.dataGridViewProducto.TabIndex = 8;
            this.dataGridViewProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducto_CellClick);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(67, 400);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(75, 23);
            this.BtnInsertar.TabIndex = 9;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(247, 400);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 10;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(432, 400);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "id_Proveedor";
            // 
            // comboBoxidProveedor
            // 
            this.comboBoxidProveedor.FormattingEnabled = true;
            this.comboBoxidProveedor.Location = new System.Drawing.Point(140, 48);
            this.comboBoxidProveedor.Name = "comboBoxidProveedor";
            this.comboBoxidProveedor.Size = new System.Drawing.Size(200, 21);
            this.comboBoxidProveedor.TabIndex = 13;
            this.comboBoxidProveedor.Enter += new System.EventHandler(this.comboBoxidProveedor_Enter);
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 445);
            this.Controls.Add(this.comboBoxidProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.dataGridViewProducto);
            this.Controls.Add(this.dateTimePickerCaducidad);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.numericPrecio);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelCaducidad);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCaducidad;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.NumericUpDown numericPrecio;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.DateTimePicker dateTimePickerCaducidad;
        private System.Windows.Forms.DataGridView dataGridViewProducto;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxidProveedor;
    }
}