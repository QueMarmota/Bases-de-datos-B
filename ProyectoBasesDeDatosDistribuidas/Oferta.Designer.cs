﻿namespace ProyectoBasesDeDatosDistribuidas
{
    partial class Oferta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.dateTimePickerVigencia = new System.Windows.Forms.DateTimePicker();
            this.numericDescuento = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewOferta = new System.Windows.Forms.DataGridView();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.id_Producto = new System.Windows.Forms.Label();
            this.comboBoxidProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOferta)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(77, 172);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 0;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vigencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descuento";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(167, 163);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(283, 59);
            this.textBoxDescripcion.TabIndex = 3;
            // 
            // dateTimePickerVigencia
            // 
            this.dateTimePickerVigencia.Location = new System.Drawing.Point(167, 89);
            this.dateTimePickerVigencia.Name = "dateTimePickerVigencia";
            this.dateTimePickerVigencia.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerVigencia.TabIndex = 4;
            // 
            // numericDescuento
            // 
            this.numericDescuento.Location = new System.Drawing.Point(184, 127);
            this.numericDescuento.Name = "numericDescuento";
            this.numericDescuento.Size = new System.Drawing.Size(120, 20);
            this.numericDescuento.TabIndex = 5;
            // 
            // dataGridViewOferta
            // 
            this.dataGridViewOferta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOferta.Location = new System.Drawing.Point(69, 239);
            this.dataGridViewOferta.Name = "dataGridViewOferta";
            this.dataGridViewOferta.Size = new System.Drawing.Size(441, 150);
            this.dataGridViewOferta.TabIndex = 6;
            this.dataGridViewOferta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOferta_CellClick);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(81, 409);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(75, 23);
            this.BtnInsertar.TabIndex = 7;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(250, 409);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(415, 409);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // id_Producto
            // 
            this.id_Producto.AutoSize = true;
            this.id_Producto.Location = new System.Drawing.Point(78, 62);
            this.id_Producto.Name = "id_Producto";
            this.id_Producto.Size = new System.Drawing.Size(50, 13);
            this.id_Producto.TabIndex = 10;
            this.id_Producto.Text = "Producto";
            // 
            // comboBoxidProducto
            // 
            this.comboBoxidProducto.FormattingEnabled = true;
            this.comboBoxidProducto.Location = new System.Drawing.Point(167, 59);
            this.comboBoxidProducto.Name = "comboBoxidProducto";
            this.comboBoxidProducto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxidProducto.TabIndex = 11;
            this.comboBoxidProducto.Enter += new System.EventHandler(this.comboBoxidProducto_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "%";
            // 
            // Oferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxidProducto);
            this.Controls.Add(this.id_Producto);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.dataGridViewOferta);
            this.Controls.Add(this.numericDescuento);
            this.Controls.Add(this.dateTimePickerVigencia);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Oferta";
            this.Text = "Oferta";
            this.Load += new System.EventHandler(this.Oferta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOferta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.DateTimePicker dateTimePickerVigencia;
        private System.Windows.Forms.NumericUpDown numericDescuento;
        private System.Windows.Forms.DataGridView dataGridViewOferta;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label id_Producto;
        private System.Windows.Forms.ComboBox comboBoxidProducto;
        private System.Windows.Forms.Label label1;
    }
}