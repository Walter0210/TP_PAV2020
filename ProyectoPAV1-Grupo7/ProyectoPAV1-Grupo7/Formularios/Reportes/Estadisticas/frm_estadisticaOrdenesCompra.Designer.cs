using Microsoft.Reporting.WinForms;

namespace ProyectoPAV1_Grupo7.Formularios.Reportes
{
    partial class frm_EstadisticaOrdenesCompra
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rv_EstadisticaGeneral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rv_Meses = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.dtp_fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rv_Sucursal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(886, 669);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rv_EstadisticaGeneral);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(878, 643);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Estadistica General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rv_EstadisticaGeneral
            // 
            this.rv_EstadisticaGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_EstadisticaGeneral.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Estadisticas.EstadisticaOrdenesCompra.rd" +
    "lc";
            this.rv_EstadisticaGeneral.Location = new System.Drawing.Point(3, 3);
            this.rv_EstadisticaGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.rv_EstadisticaGeneral.Name = "rv_EstadisticaGeneral";
            this.rv_EstadisticaGeneral.ServerReport.BearerToken = null;
            this.rv_EstadisticaGeneral.Size = new System.Drawing.Size(872, 637);
            this.rv_EstadisticaGeneral.TabIndex = 1;
            this.rv_EstadisticaGeneral.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            this.rv_EstadisticaGeneral.Load += new System.EventHandler(this.rv_EstadisticaGeneralLoad);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rv_Meses);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(878, 643);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estadistica Mensual";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rv_Meses
            // 
            this.rv_Meses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_Meses.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Estadisticas.EstadisticaOCMensual.rdlc";
            this.rv_Meses.Location = new System.Drawing.Point(3, 3);
            this.rv_Meses.Margin = new System.Windows.Forms.Padding(2);
            this.rv_Meses.Name = "rv_Meses";
            this.rv_Meses.ServerReport.BearerToken = null;
            this.rv_Meses.Size = new System.Drawing.Size(872, 637);
            this.rv_Meses.TabIndex = 2;
            this.rv_Meses.Load += new System.EventHandler(this.rv_Meses_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_Limpiar);
            this.tabPage3.Controls.Add(this.dtp_fechaHasta);
            this.tabPage3.Controls.Add(this.dtp_FechaDesde);
            this.tabPage3.Controls.Add(this.btnFiltrar);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.rv_Sucursal);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(878, 643);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Proporcion por Estacion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(656, 8);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(85, 23);
            this.btn_Limpiar.TabIndex = 11;
            this.btn_Limpiar.Text = "Limpiar Filtros";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar3_Click);
            // 
            // dtp_fechaHasta
            // 
            this.dtp_fechaHasta.Location = new System.Drawing.Point(430, 9);
            this.dtp_fechaHasta.Name = "dtp_fechaHasta";
            this.dtp_fechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechaHasta.TabIndex = 10;
            // 
            // dtp_FechaDesde
            // 
            this.dtp_FechaDesde.Location = new System.Drawing.Point(139, 9);
            this.dtp_FechaDesde.Name = "dtp_FechaDesde";
            this.dtp_FechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaDesde.TabIndex = 9;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(756, 8);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mes hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mes desde:";
            // 
            // rv_Sucursal
            // 
            this.rv_Sucursal.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Estadisticas.EstadisticaOCSucursal.rdlc";
            this.rv_Sucursal.Location = new System.Drawing.Point(3, 42);
            this.rv_Sucursal.Margin = new System.Windows.Forms.Padding(2);
            this.rv_Sucursal.Name = "rv_Sucursal";
            this.rv_Sucursal.ServerReport.BearerToken = null;
            this.rv_Sucursal.Size = new System.Drawing.Size(872, 598);
            this.rv_Sucursal.TabIndex = 3;
            this.rv_Sucursal.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            this.rv_Sucursal.Load += new System.EventHandler(this.rv_Sucursal_Load);
            // 
            // frm_EstadisticaOrdenesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 669);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frm_EstadisticaOrdenesCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas Ordenes de Compra";
            this.Load += new System.EventHandler(this.frm_estadisticaOrdenesCompra_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private ReportViewer rv_EstadisticaGeneral;
        private System.Windows.Forms.TabPage tabPage2;
        private ReportViewer rv_Meses;
        private System.Windows.Forms.TabPage tabPage3;
        private ReportViewer rv_Sucursal;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.DateTimePicker dtp_fechaHasta;
        private System.Windows.Forms.DateTimePicker dtp_FechaDesde;
    }
}