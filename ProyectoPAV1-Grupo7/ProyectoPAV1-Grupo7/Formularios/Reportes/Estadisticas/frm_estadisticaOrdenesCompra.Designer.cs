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
            this.btnLimpiarFiltrosGeneral = new System.Windows.Forms.Button();
            this.dtp_GeneralFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_GeneralFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrarGeneral = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rv_EstadisticaGeneral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rv_Meses = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_LimpiarFiltrosSucursal = new System.Windows.Forms.Button();
            this.dtp_SucursalFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_SucursalFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrarSucursal = new System.Windows.Forms.Button();
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
            this.tabPage1.Controls.Add(this.btnLimpiarFiltrosGeneral);
            this.tabPage1.Controls.Add(this.dtp_GeneralFechaHasta);
            this.tabPage1.Controls.Add(this.dtp_GeneralFechaDesde);
            this.tabPage1.Controls.Add(this.btnFiltrarGeneral);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.rv_EstadisticaGeneral);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(878, 643);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Estadistica General";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnLimpiarFiltrosGeneral
            // 
            this.btnLimpiarFiltrosGeneral.Location = new System.Drawing.Point(656, 8);
            this.btnLimpiarFiltrosGeneral.Name = "btnLimpiarFiltrosGeneral";
            this.btnLimpiarFiltrosGeneral.Size = new System.Drawing.Size(85, 23);
            this.btnLimpiarFiltrosGeneral.TabIndex = 17;
            this.btnLimpiarFiltrosGeneral.Text = "Limpiar Filtros";
            this.btnLimpiarFiltrosGeneral.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltrosGeneral.Click += new System.EventHandler(this.btnLimpiarFiltrosGeneral_Click);
            // 
            // dtp_GeneralFechaHasta
            // 
            this.dtp_GeneralFechaHasta.Location = new System.Drawing.Point(392, 9);
            this.dtp_GeneralFechaHasta.Name = "dtp_GeneralFechaHasta";
            this.dtp_GeneralFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_GeneralFechaHasta.TabIndex = 16;
            // 
            // dtp_GeneralFechaDesde
            // 
            this.dtp_GeneralFechaDesde.Location = new System.Drawing.Point(101, 9);
            this.dtp_GeneralFechaDesde.Name = "dtp_GeneralFechaDesde";
            this.dtp_GeneralFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtp_GeneralFechaDesde.TabIndex = 15;
            // 
            // btnFiltrarGeneral
            // 
            this.btnFiltrarGeneral.Location = new System.Drawing.Point(756, 8);
            this.btnFiltrarGeneral.Name = "btnFiltrarGeneral";
            this.btnFiltrarGeneral.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarGeneral.TabIndex = 14;
            this.btnFiltrarGeneral.Text = "Filtrar";
            this.btnFiltrarGeneral.UseVisualStyleBackColor = true;
            this.btnFiltrarGeneral.Click += new System.EventHandler(this.btnFiltrarGeneral_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mes hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mes desde:";
            // 
            // rv_EstadisticaGeneral
            // 
            this.rv_EstadisticaGeneral.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Estadisticas.EstadisticaOrdenesCompra.rd" +
    "lc";
            this.rv_EstadisticaGeneral.Location = new System.Drawing.Point(4, 38);
            this.rv_EstadisticaGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.rv_EstadisticaGeneral.Name = "rv_EstadisticaGeneral";
            this.rv_EstadisticaGeneral.ServerReport.BearerToken = null;
            this.rv_EstadisticaGeneral.Size = new System.Drawing.Size(870, 600);
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
            this.tabPage3.Controls.Add(this.btn_LimpiarFiltrosSucursal);
            this.tabPage3.Controls.Add(this.dtp_SucursalFechaHasta);
            this.tabPage3.Controls.Add(this.dtp_SucursalFechaDesde);
            this.tabPage3.Controls.Add(this.btnFiltrarSucursal);
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
            // btn_LimpiarFiltrosSucursal
            // 
            this.btn_LimpiarFiltrosSucursal.Location = new System.Drawing.Point(656, 8);
            this.btn_LimpiarFiltrosSucursal.Name = "btn_LimpiarFiltrosSucursal";
            this.btn_LimpiarFiltrosSucursal.Size = new System.Drawing.Size(85, 23);
            this.btn_LimpiarFiltrosSucursal.TabIndex = 11;
            this.btn_LimpiarFiltrosSucursal.Text = "Limpiar";
            this.btn_LimpiarFiltrosSucursal.UseVisualStyleBackColor = true;
            this.btn_LimpiarFiltrosSucursal.Click += new System.EventHandler(this.btn_LimpiarFiltrosSucursal_Click);
            // 
            // dtp_SucursalFechaHasta
            // 
            this.dtp_SucursalFechaHasta.Location = new System.Drawing.Point(392, 9);
            this.dtp_SucursalFechaHasta.Name = "dtp_SucursalFechaHasta";
            this.dtp_SucursalFechaHasta.Size = new System.Drawing.Size(194, 20);
            this.dtp_SucursalFechaHasta.TabIndex = 10;
            // 
            // dtp_SucursalFechaDesde
            // 
            this.dtp_SucursalFechaDesde.Location = new System.Drawing.Point(101, 9);
            this.dtp_SucursalFechaDesde.Name = "dtp_SucursalFechaDesde";
            this.dtp_SucursalFechaDesde.Size = new System.Drawing.Size(194, 20);
            this.dtp_SucursalFechaDesde.TabIndex = 9;
            // 
            // btnFiltrarSucursal
            // 
            this.btnFiltrarSucursal.Location = new System.Drawing.Point(756, 8);
            this.btnFiltrarSucursal.Name = "btnFiltrarSucursal";
            this.btnFiltrarSucursal.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarSucursal.TabIndex = 8;
            this.btnFiltrarSucursal.Text = "Filtrar";
            this.btnFiltrarSucursal.UseVisualStyleBackColor = true;
            this.btnFiltrarSucursal.Click += new System.EventHandler(this.btnFiltrarSucursal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mes hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mes desde:";
            // 
            // rv_Sucursal
            // 
            this.rv_Sucursal.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Estadisticas.EstadisticaOCSucursal.rdlc";
            this.rv_Sucursal.Location = new System.Drawing.Point(4, 38);
            this.rv_Sucursal.Margin = new System.Windows.Forms.Padding(2);
            this.rv_Sucursal.Name = "rv_Sucursal";
            this.rv_Sucursal.ServerReport.BearerToken = null;
            this.rv_Sucursal.Size = new System.Drawing.Size(870, 600);
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
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Button btnFiltrarSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_LimpiarFiltrosSucursal;
        private System.Windows.Forms.DateTimePicker dtp_SucursalFechaHasta;
        private System.Windows.Forms.DateTimePicker dtp_SucursalFechaDesde;
        private System.Windows.Forms.Button btnLimpiarFiltrosGeneral;
        private System.Windows.Forms.DateTimePicker dtp_GeneralFechaHasta;
        private System.Windows.Forms.DateTimePicker dtp_GeneralFechaDesde;
        private System.Windows.Forms.Button btnFiltrarGeneral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}