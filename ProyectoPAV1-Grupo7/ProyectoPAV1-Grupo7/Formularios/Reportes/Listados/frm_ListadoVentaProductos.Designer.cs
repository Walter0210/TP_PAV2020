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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataSetTablasBDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTablasBD = new ProyectoPAV1_Grupo7.DataSetTablasBD();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grb_filtros = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.cmbSolicitante = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWhere = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBD)).BeginInit();
            this.grb_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSetTablasBDBindingSource
            // 
            this.dataSetTablasBDBindingSource.DataSource = this.dataSetTablasBD;
            this.dataSetTablasBDBindingSource.Position = 0;
            // 
            // dataSetTablasBD
            // 
            this.dataSetTablasBD.DataSetName = "DataSetTablasBD";
            this.dataSetTablasBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DatosTickets";
            reportDataSource2.Value = this.dataSetTablasBDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Listado_VentaProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 124);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(884, 787);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // grb_filtros
            // 
            this.grb_filtros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_filtros.Controls.Add(this.btnLimpiarFiltros);
            this.grb_filtros.Controls.Add(this.label3);
            this.grb_filtros.Controls.Add(this.label2);
            this.grb_filtros.Controls.Add(this.dtpHasta);
            this.grb_filtros.Controls.Add(this.dtpDesde);
            this.grb_filtros.Controls.Add(this.cmbSolicitante);
            this.grb_filtros.Controls.Add(this.btnCalcular);
            this.grb_filtros.Controls.Add(this.label1);
            this.grb_filtros.Location = new System.Drawing.Point(12, 12);
            this.grb_filtros.Name = "grb_filtros";
            this.grb_filtros.Size = new System.Drawing.Size(611, 89);
            this.grb_filtros.TabIndex = 5;
            this.grb_filtros.TabStop = false;
            this.grb_filtros.Text = "Filtros";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(520, 46);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(71, 20);
            this.btnLimpiarFiltros.TabIndex = 8;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(372, 46);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(121, 20);
            this.dtpHasta.TabIndex = 5;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(372, 14);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(121, 20);
            this.dtpDesde.TabIndex = 4;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // cmbSolicitante
            // 
            this.cmbSolicitante.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSolicitante.FormattingEnabled = true;
            this.cmbSolicitante.Location = new System.Drawing.Point(111, 14);
            this.cmbSolicitante.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSolicitante.Name = "cmbSolicitante";
            this.cmbSolicitante.Size = new System.Drawing.Size(121, 21);
            this.cmbSolicitante.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Location = new System.Drawing.Point(520, 16);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(71, 20);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Filtrar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(56, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estacion:";
            // 
            // txtWhere
            // 
            this.txtWhere.AutoSize = true;
            this.txtWhere.Location = new System.Drawing.Point(22, 108);
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(0, 13);
            this.txtWhere.TabIndex = 6;
            this.txtWhere.Visible = false;
            // 
            // frm_ListadoVentaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 911);
            this.Controls.Add(this.txtWhere);
            this.Controls.Add(this.grb_filtros);
            this.Controls.Add(this.reportViewer1);
            this.MinimumSize = new System.Drawing.Size(900, 950);
            this.Name = "frm_ListadoVentaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de ventas";
            this.Load += new System.EventHandler(this.frm_ListadoVentaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBD)).EndInit();
            this.grb_filtros.ResumeLayout(false);
            this.grb_filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetTablasBDBindingSource;
        private DataSetTablasBD dataSetTablasBD;
        private System.Windows.Forms.GroupBox grb_filtros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.ComboBox cmbSolicitante;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Label txtWhere;
    }
}