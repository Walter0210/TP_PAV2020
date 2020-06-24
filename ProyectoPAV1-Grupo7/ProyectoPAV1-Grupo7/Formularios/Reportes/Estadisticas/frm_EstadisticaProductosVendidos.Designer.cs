namespace ProyectoPAV1_Grupo7.Formularios.Reportes
{
    partial class frm_EstadisticaProductosVendidos
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
            this.reportViewerProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tab_Barras = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewerProductos2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTime_desde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Estacion = new System.Windows.Forms.ComboBox();
            this.dateTime_hasta = new System.Windows.Forms.DateTimePicker();
            this.tab_Barras.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerProductos
            // 
            this.reportViewerProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerProductos.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Estadisticas.EstadisticaProductosVendido" +
    "s.rdlc";
            this.reportViewerProductos.Location = new System.Drawing.Point(2, 2);
            this.reportViewerProductos.Name = "reportViewerProductos";
            this.reportViewerProductos.ServerReport.BearerToken = null;
            this.reportViewerProductos.Size = new System.Drawing.Size(898, 576);
            this.reportViewerProductos.TabIndex = 0;
            this.reportViewerProductos.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewerProductos.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tab_Barras
            // 
            this.tab_Barras.AccessibleName = "";
            this.tab_Barras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Barras.Controls.Add(this.tabPage1);
            this.tab_Barras.Controls.Add(this.tabPage2);
            this.tab_Barras.Location = new System.Drawing.Point(11, 94);
            this.tab_Barras.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Barras.Name = "tab_Barras";
            this.tab_Barras.SelectedIndex = 0;
            this.tab_Barras.Size = new System.Drawing.Size(910, 606);
            this.tab_Barras.TabIndex = 1;
            this.tab_Barras.Tag = "asdas";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewerProductos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(902, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gráfico de Barras";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewerProductos2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(902, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gráfico de Torta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewerProductos2
            // 
            this.reportViewerProductos2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerProductos2.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Estadisticas.EstadisticaProductosVendido" +
    "sTorta.rdlc";
            this.reportViewerProductos2.Location = new System.Drawing.Point(2, 2);
            this.reportViewerProductos2.Name = "reportViewerProductos2";
            this.reportViewerProductos2.ServerReport.BearerToken = null;
            this.reportViewerProductos2.Size = new System.Drawing.Size(898, 576);
            this.reportViewerProductos2.TabIndex = 7;
            this.reportViewerProductos2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewerProductos2.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(538, 44);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpiar Filtros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dateTime_desde);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_Estacion);
            this.groupBox1.Controls.Add(this.dateTime_hasta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(643, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTime_desde
            // 
            this.dateTime_desde.Location = new System.Drawing.Point(315, 17);
            this.dateTime_desde.Name = "dateTime_desde";
            this.dateTime_desde.Size = new System.Drawing.Size(200, 20);
            this.dateTime_desde.TabIndex = 4;
            this.dateTime_desde.ValueChanged += new System.EventHandler(this.dateTime_desde_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Desde:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estacion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_Estacion
            // 
            this.cmb_Estacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Estacion.FormattingEnabled = true;
            this.cmb_Estacion.Location = new System.Drawing.Point(106, 18);
            this.cmb_Estacion.Name = "cmb_Estacion";
            this.cmb_Estacion.Size = new System.Drawing.Size(121, 21);
            this.cmb_Estacion.TabIndex = 1;
            // 
            // dateTime_hasta
            // 
            this.dateTime_hasta.Location = new System.Drawing.Point(315, 47);
            this.dateTime_hasta.Name = "dateTime_hasta";
            this.dateTime_hasta.Size = new System.Drawing.Size(200, 20);
            this.dateTime_hasta.TabIndex = 0;
            this.dateTime_hasta.ValueChanged += new System.EventHandler(this.dateTime_hasta_ValueChanged);
            // 
            // frm_EstadisticaProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(934, 711);
            this.Controls.Add(this.tab_Barras);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_EstadisticaProductosVendidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos Vendidos";
            this.Load += new System.EventHandler(this.frm_EstadisticaProductosVendidos_Load);
            this.tab_Barras.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProductos;
        private System.Windows.Forms.TabControl tab_Barras;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTime_desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Estacion;
        private System.Windows.Forms.DateTimePicker dateTime_hasta;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProductos2;
    }
}