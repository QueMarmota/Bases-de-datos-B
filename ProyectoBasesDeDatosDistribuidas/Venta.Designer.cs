namespace ProyectoBasesDeDatosDistribuidas
{
    partial class Venta
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
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxDescripcionVenta = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewVenta = new System.Windows.Forms.DataGridView();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.labelProductos = new System.Windows.Forms.Label();
            this.listBoxInventario = new System.Windows.Forms.ListBox();
            this.listBoxCarrito = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Carrito = new System.Windows.Forms.Label();
            this.richTextBoxTotal = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(39, 200);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(108, 13);
            this.labelDescripcion.TabIndex = 0;
            this.labelDescripcion.Text = "Descripcion de venta";
            // 
            // textBoxDescripcionVenta
            // 
            this.textBoxDescripcionVenta.Location = new System.Drawing.Point(171, 197);
            this.textBoxDescripcionVenta.Multiline = true;
            this.textBoxDescripcionVenta.Name = "textBoxDescripcionVenta";
            this.textBoxDescripcionVenta.Size = new System.Drawing.Size(367, 94);
            this.textBoxDescripcionVenta.TabIndex = 5;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(45, 56);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 4;
            this.labelFecha.Text = "Fecha";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(174, 48);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFecha.TabIndex = 1;
            // 
            // dataGridViewVenta
            // 
            this.dataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenta.Location = new System.Drawing.Point(48, 311);
            this.dataGridViewVenta.Name = "dataGridViewVenta";
            this.dataGridViewVenta.Size = new System.Drawing.Size(535, 150);
            this.dataGridViewVenta.TabIndex = 6;
            this.dataGridViewVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVenta_CellClick);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(116, 481);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(75, 23);
            this.BtnInsertar.TabIndex = 7;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(299, 481);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modifcar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(470, 481);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Location = new System.Drawing.Point(42, 133);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(55, 13);
            this.labelProductos.TabIndex = 11;
            this.labelProductos.Text = "Productos";
            // 
            // listBoxInventario
            // 
            this.listBoxInventario.FormattingEnabled = true;
            this.listBoxInventario.Location = new System.Drawing.Point(171, 96);
            this.listBoxInventario.Name = "listBoxInventario";
            this.listBoxInventario.Size = new System.Drawing.Size(130, 95);
            this.listBoxInventario.TabIndex = 12;
            this.listBoxInventario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxInventario_MouseDown);
            // 
            // listBoxCarrito
            // 
            this.listBoxCarrito.FormattingEnabled = true;
            this.listBoxCarrito.Location = new System.Drawing.Point(338, 96);
            this.listBoxCarrito.Name = "listBoxCarrito";
            this.listBoxCarrito.Size = new System.Drawing.Size(136, 95);
            this.listBoxCarrito.TabIndex = 13;
            this.listBoxCarrito.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxCarrito_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "= >";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "< =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "STOCK";
            // 
            // Carrito
            // 
            this.Carrito.AutoSize = true;
            this.Carrito.Location = new System.Drawing.Point(349, 77);
            this.Carrito.Name = "Carrito";
            this.Carrito.Size = new System.Drawing.Size(37, 13);
            this.Carrito.TabIndex = 17;
            this.Carrito.Text = "Carrito";
            // 
            // richTextBoxTotal
            // 
            this.richTextBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTotal.Location = new System.Drawing.Point(513, 120);
            this.richTextBoxTotal.Name = "richTextBoxTotal";
            this.richTextBoxTotal.Size = new System.Drawing.Size(100, 49);
            this.richTextBoxTotal.TabIndex = 18;
            this.richTextBoxTotal.Text = "";
            this.richTextBoxTotal.TextChanged += new System.EventHandler(this.richTextBoxTotal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 96);
            this.label4.MaximumSize = new System.Drawing.Size(100, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 546);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxTotal);
            this.Controls.Add(this.Carrito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCarrito);
            this.Controls.Add(this.listBoxInventario);
            this.Controls.Add(this.labelProductos);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.dataGridViewVenta);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.textBoxDescripcionVenta);
            this.Controls.Add(this.labelDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxDescripcionVenta;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.DataGridView dataGridViewVenta;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.ListBox listBoxInventario;
        private System.Windows.Forms.ListBox listBoxCarrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Carrito;
        private System.Windows.Forms.RichTextBox richTextBoxTotal;
        private System.Windows.Forms.Label label4;
    }
}