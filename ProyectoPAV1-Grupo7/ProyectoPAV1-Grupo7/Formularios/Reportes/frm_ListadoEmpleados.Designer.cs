namespace ProyectoPAV1_Grupo7.Formularios.Reportes
{
    partial class frm_ListadoEmpleados
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.Label();
            this.txt_legajo = new System.Windows.Forms.TextBox();
            this.legajo = new System.Windows.Forms.Label();
            this.dateTime_desde = new System.Windows.Forms.DateTimePicker();
            this.dateTime_hasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.ListadoEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 124);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1016, 489);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_dni);
            this.groupBox1.Controls.Add(this.dni);
            this.groupBox1.Controls.Add(this.txt_legajo);
            this.groupBox1.Controls.Add(this.legajo);
            this.groupBox1.Location = new System.Drawing.Point(171, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por:";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(68, 60);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(100, 20);
            this.txt_dni.TabIndex = 3;
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Location = new System.Drawing.Point(36, 60);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(26, 13);
            this.dni.TabIndex = 2;
            this.dni.Text = "DNI";
            // 
            // txt_legajo
            // 
            this.txt_legajo.Location = new System.Drawing.Point(68, 26);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(100, 20);
            this.txt_legajo.TabIndex = 1;
            // 
            // legajo
            // 
            this.legajo.AutoSize = true;
            this.legajo.Location = new System.Drawing.Point(23, 26);
            this.legajo.Name = "legajo";
            this.legajo.Size = new System.Drawing.Size(39, 13);
            this.legajo.TabIndex = 0;
            this.legajo.Text = "Legajo";
            // 
            // dateTime_desde
            // 
            this.dateTime_desde.Location = new System.Drawing.Point(70, 26);
            this.dateTime_desde.Name = "dateTime_desde";
            this.dateTime_desde.Size = new System.Drawing.Size(197, 20);
            this.dateTime_desde.TabIndex = 2;
            this.dateTime_desde.ValueChanged += new System.EventHandler(this.dateTime_desde_ValueChanged);
            // 
            // dateTime_hasta
            // 
            this.dateTime_hasta.Location = new System.Drawing.Point(70, 58);
            this.dateTime_hasta.Name = "dateTime_hasta";
            this.dateTime_hasta.Size = new System.Drawing.Size(197, 20);
            this.dateTime_hasta.TabIndex = 3;
            this.dateTime_hasta.ValueChanged += new System.EventHandler(this.dateTime_hasta_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(733, 37);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 6;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(733, 74);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 8;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTime_hasta);
            this.groupBox2.Controls.Add(this.dateTime_desde);
            this.groupBox2.Location = new System.Drawing.Point(383, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 92);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha de Alta";
            // 
            // frm_ListadoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_ListadoEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ListadoEmpleados";
            this.Load += new System.EventHandler(this.frm_ListadoEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label legajo;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.TextBox txt_legajo;
        private System.Windows.Forms.DateTimePicker dateTime_desde;
        private System.Windows.Forms.DateTimePicker dateTime_hasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}