namespace ProyectoBasesDeDatosDistribuidas
{
    partial class Empleado
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
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.labelPuesto = new System.Windows.Forms.Label();
            this.TextBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelSueldo = new System.Windows.Forms.Label();
            this.TextBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.ComboBoxPuesto = new System.Windows.Forms.ComboBox();
            this.NumericSueldo = new System.Windows.Forms.NumericUpDown();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnModifica = new System.Windows.Forms.Button();
            this.BtnElimina = new System.Windows.Forms.Button();
            this.dataGridViewEmpleado = new System.Windows.Forms.DataGridView();
            this.labelGenero = new System.Windows.Forms.Label();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.labelEntrada = new System.Windows.Forms.Label();
            this.labelHoraSAlida = new System.Windows.Forms.Label();
            this.dateTimePickerHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxidSucursal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSueldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(53, 41);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(111, 41);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(267, 20);
            this.TextBoxNombre.TabIndex = 1;
            // 
            // labelPuesto
            // 
            this.labelPuesto.AutoSize = true;
            this.labelPuesto.Location = new System.Drawing.Point(53, 145);
            this.labelPuesto.Name = "labelPuesto";
            this.labelPuesto.Size = new System.Drawing.Size(40, 13);
            this.labelPuesto.TabIndex = 2;
            this.labelPuesto.Text = "Puesto";
            // 
            // TextBoxTelefono
            // 
            this.TextBoxTelefono.Location = new System.Drawing.Point(111, 67);
            this.TextBoxTelefono.Name = "TextBoxTelefono";
            this.TextBoxTelefono.Size = new System.Drawing.Size(149, 20);
            this.TextBoxTelefono.TabIndex = 7;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(53, 67);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 6;
            this.labelTelefono.Text = "Telefono";
            // 
            // labelSueldo
            // 
            this.labelSueldo.AutoSize = true;
            this.labelSueldo.Location = new System.Drawing.Point(53, 175);
            this.labelSueldo.Name = "labelSueldo";
            this.labelSueldo.Size = new System.Drawing.Size(40, 13);
            this.labelSueldo.TabIndex = 4;
            this.labelSueldo.Text = "Sueldo";
            // 
            // TextBoxDireccion
            // 
            this.TextBoxDireccion.Location = new System.Drawing.Point(111, 93);
            this.TextBoxDireccion.Name = "TextBoxDireccion";
            this.TextBoxDireccion.Size = new System.Drawing.Size(267, 20);
            this.TextBoxDireccion.TabIndex = 9;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(53, 96);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 8;
            this.labelDireccion.Text = "Dirección";
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(167, 119);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 10;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(53, 125);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(108, 13);
            this.labelFecha.TabIndex = 11;
            this.labelFecha.Text = "Fecha de Nacimiento";
            // 
            // ComboBoxPuesto
            // 
            this.ComboBoxPuesto.FormattingEnabled = true;
            this.ComboBoxPuesto.Items.AddRange(new object[] {
            "Empleado",
            "Administrador"});
            this.ComboBoxPuesto.Location = new System.Drawing.Point(111, 145);
            this.ComboBoxPuesto.Name = "ComboBoxPuesto";
            this.ComboBoxPuesto.Size = new System.Drawing.Size(149, 21);
            this.ComboBoxPuesto.TabIndex = 12;
            // 
            // NumericSueldo
            // 
            this.NumericSueldo.DecimalPlaces = 2;
            this.NumericSueldo.Location = new System.Drawing.Point(111, 172);
            this.NumericSueldo.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.NumericSueldo.Name = "NumericSueldo";
            this.NumericSueldo.Size = new System.Drawing.Size(120, 20);
            this.NumericSueldo.TabIndex = 13;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(65, 500);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(75, 23);
            this.BtnInsertar.TabIndex = 14;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnModifica
            // 
            this.BtnModifica.Location = new System.Drawing.Point(239, 500);
            this.BtnModifica.Name = "BtnModifica";
            this.BtnModifica.Size = new System.Drawing.Size(75, 23);
            this.BtnModifica.TabIndex = 15;
            this.BtnModifica.Text = "Modificar";
            this.BtnModifica.UseVisualStyleBackColor = true;
            this.BtnModifica.Click += new System.EventHandler(this.BtnModifica_Click);
            // 
            // BtnElimina
            // 
            this.BtnElimina.Location = new System.Drawing.Point(424, 500);
            this.BtnElimina.Name = "BtnElimina";
            this.BtnElimina.Size = new System.Drawing.Size(75, 23);
            this.BtnElimina.TabIndex = 16;
            this.BtnElimina.Text = "Eliminar";
            this.BtnElimina.UseVisualStyleBackColor = true;
            this.BtnElimina.Click += new System.EventHandler(this.BtnElimina_Click);
            // 
            // dataGridViewEmpleado
            // 
            this.dataGridViewEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleado.Location = new System.Drawing.Point(42, 331);
            this.dataGridViewEmpleado.Name = "dataGridViewEmpleado";
            this.dataGridViewEmpleado.Size = new System.Drawing.Size(471, 150);
            this.dataGridViewEmpleado.TabIndex = 17;
            this.dataGridViewEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleado_CellClick);
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(54, 263);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(42, 13);
            this.labelGenero.TabIndex = 18;
            this.labelGenero.Text = "Genero";
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(122, 261);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 19;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.Location = new System.Drawing.Point(215, 261);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(71, 17);
            this.radioButtonFemenino.TabIndex = 20;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = true;
            // 
            // labelEntrada
            // 
            this.labelEntrada.AutoSize = true;
            this.labelEntrada.Location = new System.Drawing.Point(53, 203);
            this.labelEntrada.Name = "labelEntrada";
            this.labelEntrada.Size = new System.Drawing.Size(85, 13);
            this.labelEntrada.TabIndex = 21;
            this.labelEntrada.Text = "Hora de Entrada";
            // 
            // labelHoraSAlida
            // 
            this.labelHoraSAlida.AutoSize = true;
            this.labelHoraSAlida.Location = new System.Drawing.Point(53, 233);
            this.labelHoraSAlida.Name = "labelHoraSAlida";
            this.labelHoraSAlida.Size = new System.Drawing.Size(77, 13);
            this.labelHoraSAlida.TabIndex = 22;
            this.labelHoraSAlida.Text = "Hora de Salida";
            // 
            // dateTimePickerHoraEntrada
            // 
            this.dateTimePickerHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraEntrada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerHoraEntrada.Location = new System.Drawing.Point(167, 197);
            this.dateTimePickerHoraEntrada.Name = "dateTimePickerHoraEntrada";
            this.dateTimePickerHoraEntrada.ShowUpDown = true;
            this.dateTimePickerHoraEntrada.Size = new System.Drawing.Size(103, 20);
            this.dateTimePickerHoraEntrada.TabIndex = 14;
            this.dateTimePickerHoraEntrada.Value = new System.DateTime(2018, 3, 15, 17, 33, 12, 0);
            // 
            // dateTimePickerHoraSalida
            // 
            this.dateTimePickerHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraSalida.Location = new System.Drawing.Point(167, 226);
            this.dateTimePickerHoraSalida.Name = "dateTimePickerHoraSalida";
            this.dateTimePickerHoraSalida.ShowUpDown = true;
            this.dateTimePickerHoraSalida.Size = new System.Drawing.Size(103, 20);
            this.dateTimePickerHoraSalida.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Sucursal";
            // 
            // comboBoxidSucursal
            // 
            this.comboBoxidSucursal.FormattingEnabled = true;
            this.comboBoxidSucursal.Location = new System.Drawing.Point(122, 287);
            this.comboBoxidSucursal.Name = "comboBoxidSucursal";
            this.comboBoxidSucursal.Size = new System.Drawing.Size(138, 21);
            this.comboBoxidSucursal.TabIndex = 26;
            this.comboBoxidSucursal.Enter += new System.EventHandler(this.comboBoxidSucursal_Enter_1);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 540);
            this.Controls.Add(this.comboBoxidSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerHoraSalida);
            this.Controls.Add(this.dateTimePickerHoraEntrada);
            this.Controls.Add(this.labelHoraSAlida);
            this.Controls.Add(this.labelEntrada);
            this.Controls.Add(this.radioButtonFemenino);
            this.Controls.Add(this.radioButtonMasculino);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.dataGridViewEmpleado);
            this.Controls.Add(this.BtnElimina);
            this.Controls.Add(this.BtnModifica);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.NumericSueldo);
            this.Controls.Add(this.ComboBoxPuesto);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.Controls.Add(this.TextBoxDireccion);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.TextBoxTelefono);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelSueldo);
            this.Controls.Add(this.labelPuesto);
            this.Controls.Add(this.TextBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericSueldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.Label labelPuesto;
        private System.Windows.Forms.TextBox TextBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelSueldo;
        private System.Windows.Forms.TextBox TextBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.ComboBox ComboBoxPuesto;
        private System.Windows.Forms.NumericUpDown NumericSueldo;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnModifica;
        private System.Windows.Forms.Button BtnElimina;
        private System.Windows.Forms.DataGridView dataGridViewEmpleado;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonFemenino;
        private System.Windows.Forms.Label labelEntrada;
        private System.Windows.Forms.Label labelHoraSAlida;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraEntrada;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxidSucursal;
    }
}