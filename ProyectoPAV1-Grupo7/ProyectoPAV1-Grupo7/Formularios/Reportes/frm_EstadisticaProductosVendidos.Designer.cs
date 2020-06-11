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
            this.SuspendLayout();
            // 
            // reportViewerProductos
            // 
            this.reportViewerProductos.AutoSize = true;
            this.reportViewerProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerProductos.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.EstadisticaProductosVendidos.rdlc";
            this.reportViewerProductos.Location = new System.Drawing.Point(0, 0);
            this.reportViewerProductos.Name = "reportViewerProductos";
            this.reportViewerProductos.ServerReport.BearerToken = null;
            this.reportViewerProductos.Size = new System.Drawing.Size(1268, 725);
            this.reportViewerProductos.TabIndex = 0;
            this.reportViewerProductos.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // frm_EstadisticaProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1268, 725);
            this.Controls.Add(this.reportViewerProductos);
            this.Name = "frm_EstadisticaProductosVendidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_EstadisticaProductosVendidos";
            this.Load += new System.EventHandler(this.frm_EstadisticaProductosVendidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProductos;
    }
}