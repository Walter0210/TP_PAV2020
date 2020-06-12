namespace ProyectoPAV1_Grupo7.Formularios.Reportes
{
    partial class frm_ListadoVentaProductos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetTablasBD = new ProyectoPAV1_Grupo7.DataSetTablasBD();
            this.dataSetTablasBDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosTickets";
            reportDataSource1.Value = this.dataSetTablasBDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Listado_VentaProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataSetTablasBD
            // 
            this.dataSetTablasBD.DataSetName = "DataSetTablasBD";
            this.dataSetTablasBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetTablasBDBindingSource
            // 
            this.dataSetTablasBDBindingSource.DataSource = this.dataSetTablasBD;
            this.dataSetTablasBDBindingSource.Position = 0;
            // 
            // frm_ListadoVentaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_ListadoVentaProductos";
            this.Text = "frm_ListadoVentaProductos";
            this.Load += new System.EventHandler(this.frm_ListadoVentaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetTablasBDBindingSource;
        private DataSetTablasBD dataSetTablasBD;
    }
}