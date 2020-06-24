namespace ProyectoPAV1_Grupo7.Formularios.Reportes
{
    partial class frm_EstadisticaGananciaProducto
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTime_desde = new System.Windows.Forms.DateTimePicker();
            this.cmb_Comparacion = new System.Windows.Forms.ComboBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_porcentaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTime_hasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Estadisticas.EstadisticaGananciaProducto" +
    "s.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(896, 574);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 606);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(902, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesos Argentinos ($)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(902, 580);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dólares (U$D)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Estadisticas.EstadisticaGananciaProducto" +
    "sUSD.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(902, 580);
            this.reportViewer3.TabIndex = 0;
            this.reportViewer3.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(902, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Porcentaje (%)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Estadisticas.EstadisticaGananciaProducto" +
    "sPorc.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(896, 574);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dateTime_desde
            // 
            this.dateTime_desde.Location = new System.Drawing.Point(315, 17);
            this.dateTime_desde.Name = "dateTime_desde";
            this.dateTime_desde.Size = new System.Drawing.Size(200, 20);
            this.dateTime_desde.TabIndex = 2;
            this.dateTime_desde.ValueChanged += new System.EventHandler(this.dateTime_desde_ValueChanged);
            // 
            // cmb_Comparacion
            // 
            this.cmb_Comparacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Comparacion.FormattingEnabled = true;
            this.cmb_Comparacion.Location = new System.Drawing.Point(92, 45);
            this.cmb_Comparacion.Name = "cmb_Comparacion";
            this.cmb_Comparacion.Size = new System.Drawing.Size(43, 21);
            this.cmb_Comparacion.TabIndex = 3;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(92, 18);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(129, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.Location = new System.Drawing.Point(142, 46);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(53, 20);
            this.txt_porcentaje.TabIndex = 8;
            this.txt_porcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(538, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 24);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpiar Filtros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTime_hasta
            // 
            this.dateTime_hasta.Location = new System.Drawing.Point(315, 47);
            this.dateTime_hasta.Name = "dateTime_hasta";
            this.dateTime_hasta.Size = new System.Drawing.Size(200, 20);
            this.dateTime_hasta.TabIndex = 12;
            this.dateTime_hasta.ValueChanged += new System.EventHandler(this.dateTime_hasta_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha Hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ganancia:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_Comparacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTime_desde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTime_hasta);
            this.groupBox1.Controls.Add(this.txt_porcentaje);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 75);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // frm_EstadisticaGananciaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 711);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(950, 750);
            this.Name = "frm_EstadisticaGananciaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ganancia por producto";
            this.Load += new System.EventHandler(this.frm_EstadisticaGananciaProducto_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.DateTimePicker dateTime_desde;
        private System.Windows.Forms.ComboBox cmb_Comparacion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_porcentaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTime_hasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
    }
}