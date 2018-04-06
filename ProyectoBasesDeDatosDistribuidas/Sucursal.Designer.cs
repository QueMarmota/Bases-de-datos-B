namespace ProyectoBasesDeDatosDistribuidas
{
    partial class Sucursal
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
            this.textBoxSucursal = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.dataGridViewSucursal = new System.Windows.Forms.DataGridView();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.labelCantidadEmpeados = new System.Windows.Forms.Label();
            this.numericCantDeEmpleados = new System.Windows.Forms.NumericUpDown();
            this.labelHoraApert = new System.Windows.Forms.Label();
            this.labelHoraCierre = new System.Windows.Forms.Label();
            this.dateTimePickerHoraApertura = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCierre = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantDeEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(64, 35);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxSucursal
            // 
            this.textBoxSucursal.Location = new System.Drawing.Point(114, 32);
            this.textBoxSucursal.Name = "textBoxSucursal";
            this.textBoxSucursal.Size = new System.Drawing.Size(327, 20);
            this.textBoxSucursal.TabIndex = 1;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(114, 68);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(327, 20);
            this.textBoxDireccion.TabIndex = 3;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(64, 71);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 2;
            this.labelDireccion.Text = "Direccion";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(114, 104);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(327, 20);
            this.textBoxTelefono.TabIndex = 5;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(64, 107);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 4;
            this.labelTelefono.Text = "Telefono";
            // 
            // dataGridViewSucursal
            // 
            this.dataGridViewSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSucursal.Location = new System.Drawing.Point(47, 242);
            this.dataGridViewSucursal.Name = "dataGridViewSucursal";
            this.dataGridViewSucursal.Size = new System.Drawing.Size(515, 150);
            this.dataGridViewSucursal.TabIndex = 6;
            this.dataGridViewSucursal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSucursal_CellClick);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(76, 415);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(75, 23);
            this.BtnInsertar.TabIndex = 7;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(253, 415);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modifcar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(434, 415);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // labelCantidadEmpeados
            // 
            this.labelCantidadEmpeados.AutoSize = true;
            this.labelCantidadEmpeados.Location = new System.Drawing.Point(67, 136);
            this.labelCantidadEmpeados.Name = "labelCantidadEmpeados";
            this.labelCantidadEmpeados.Size = new System.Drawing.Size(118, 13);
            this.labelCantidadEmpeados.TabIndex = 10;
            this.labelCantidadEmpeados.Text = "Cantidad de empleados";
            // 
            // numericCantDeEmpleados
            // 
            this.numericCantDeEmpleados.Location = new System.Drawing.Point(194, 134);
            this.numericCantDeEmpleados.Name = "numericCantDeEmpleados";
            this.numericCantDeEmpleados.Size = new System.Drawing.Size(120, 20);
            this.numericCantDeEmpleados.TabIndex = 11;
            // 
            // labelHoraApert
            // 
            this.labelHoraApert.AutoSize = true;
            this.labelHoraApert.Location = new System.Drawing.Point(70, 167);
            this.labelHoraApert.Name = "labelHoraApert";
            this.labelHoraApert.Size = new System.Drawing.Size(87, 13);
            this.labelHoraApert.TabIndex = 12;
            this.labelHoraApert.Text = "Hora de apertura";
            // 
            // labelHoraCierre
            // 
            this.labelHoraCierre.AutoSize = true;
            this.labelHoraCierre.Location = new System.Drawing.Point(70, 201);
            this.labelHoraCierre.Name = "labelHoraCierre";
            this.labelHoraCierre.Size = new System.Drawing.Size(74, 13);
            this.labelHoraCierre.TabIndex = 13;
            this.labelHoraCierre.Text = "Hora de cierre";
            // 
            // dateTimePickerHoraApertura
            // 
            this.dateTimePickerHoraApertura.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraApertura.Location = new System.Drawing.Point(194, 160);
            this.dateTimePickerHoraApertura.Name = "dateTimePickerHoraApertura";
            this.dateTimePickerHoraApertura.ShowUpDown = true;
            this.dateTimePickerHoraApertura.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerHoraApertura.TabIndex = 14;
            // 
            // dateTimePickerCierre
            // 
            this.dateTimePickerCierre.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerCierre.Location = new System.Drawing.Point(194, 195);
            this.dateTimePickerCierre.Name = "dateTimePickerCierre";
            this.dateTimePickerCierre.ShowUpDown = true;
            this.dateTimePickerCierre.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerCierre.TabIndex = 15;
            // 
            // Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 470);
            this.Controls.Add(this.dateTimePickerCierre);
            this.Controls.Add(this.dateTimePickerHoraApertura);
            this.Controls.Add(this.labelHoraCierre);
            this.Controls.Add(this.labelHoraApert);
            this.Controls.Add(this.numericCantDeEmpleados);
            this.Controls.Add(this.labelCantidadEmpeados);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.dataGridViewSucursal);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.textBoxSucursal);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Sucursal";
            this.Text = "Sucursal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantDeEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxSucursal;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.DataGridView dataGridViewSucursal;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label labelCantidadEmpeados;
        private System.Windows.Forms.NumericUpDown numericCantDeEmpleados;
        private System.Windows.Forms.Label labelHoraApert;
        private System.Windows.Forms.Label labelHoraCierre;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraApertura;
        private System.Windows.Forms.DateTimePicker dateTimePickerCierre;
    }
}