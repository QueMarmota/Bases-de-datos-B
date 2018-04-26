namespace ProyectoBasesDeDatosDistribuidas
{
    partial class FormReporteEmpleadoFiltro
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Genera = new System.Windows.Forms.Button();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.listBoxEmpleado = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona Empleado";
            // 
            // btn_Genera
            // 
            this.btn_Genera.Location = new System.Drawing.Point(122, 239);
            this.btn_Genera.Name = "btn_Genera";
            this.btn_Genera.Size = new System.Drawing.Size(148, 23);
            this.btn_Genera.TabIndex = 2;
            this.btn_Genera.Text = "Genera Reporte";
            this.btn_Genera.UseVisualStyleBackColor = true;
            this.btn_Genera.Click += new System.EventHandler(this.btn_Genera_Click);
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(360, 57);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewEmpleados.TabIndex = 3;
            this.dataGridViewEmpleados.Visible = false;
            // 
            // listBoxEmpleado
            // 
            this.listBoxEmpleado.FormattingEnabled = true;
            this.listBoxEmpleado.Location = new System.Drawing.Point(45, 69);
            this.listBoxEmpleado.Name = "listBoxEmpleado";
            this.listBoxEmpleado.Size = new System.Drawing.Size(309, 121);
            this.listBoxEmpleado.TabIndex = 4;
            this.listBoxEmpleado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxEmpleado_MouseDown);
            // 
            // FormReporteEmpleadoFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 288);
            this.Controls.Add(this.listBoxEmpleado);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Controls.Add(this.btn_Genera);
            this.Controls.Add(this.label1);
            this.Name = "FormReporteEmpleadoFiltro";
            this.Text = "ReporteEmpleado";
            this.Load += new System.EventHandler(this.FormReporteFiltro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Genera;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.ListBox listBoxEmpleado;
    }
}