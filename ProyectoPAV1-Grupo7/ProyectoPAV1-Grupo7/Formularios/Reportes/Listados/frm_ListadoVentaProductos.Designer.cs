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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataSetTablasBDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTablasBD = new ProyectoPAV1_Grupo7.DataSetTablasBD();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtWhere = new System.Windows.Forms.Label();
            this.grb_filtros = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.cmbSolicitante = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rv_prodXventas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_limpiarVentas = new System.Windows.Forms.Button();
            this.cmb_nroTicket = new System.Windows.Forms.ComboBox();
            this.btn_filtrarVentas = new System.Windows.Forms.Button();
            this.lbl_ticket = new System.Windows.Forms.Label();
            this.TicketXProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBD)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grb_filtros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketXProductoBindingSource)).BeginInit();
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1177, 1052);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtWhere);
            this.tabPage1.Controls.Add(this.grb_filtros);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1169, 1023);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ventas General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.rv_prodXventas);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1169, 1023);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Productos por Venta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtWhere
            // 
            this.txtWhere.AutoSize = true;
            this.txtWhere.Location = new System.Drawing.Point(13, 118);
            this.txtWhere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(0, 17);
            this.txtWhere.TabIndex = 9;
            this.txtWhere.Visible = false;
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
            this.grb_filtros.Location = new System.Drawing.Point(16, 0);
            this.grb_filtros.Margin = new System.Windows.Forms.Padding(4);
            this.grb_filtros.Name = "grb_filtros";
            this.grb_filtros.Padding = new System.Windows.Forms.Padding(4);
            this.grb_filtros.Size = new System.Drawing.Size(815, 110);
            this.grb_filtros.TabIndex = 8;
            this.grb_filtros.TabStop = false;
            this.grb_filtros.Text = "Filtros";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(693, 62);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(95, 25);
            this.btnLimpiarFiltros.TabIndex = 8;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(496, 62);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(160, 22);
            this.dtpHasta.TabIndex = 5;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(496, 22);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(160, 22);
            this.dtpDesde.TabIndex = 4;
            // 
            // cmbSolicitante
            // 
            this.cmbSolicitante.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSolicitante.FormattingEnabled = true;
            this.cmbSolicitante.Location = new System.Drawing.Point(148, 22);
            this.cmbSolicitante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSolicitante.Name = "cmbSolicitante";
            this.cmbSolicitante.Size = new System.Drawing.Size(160, 24);
            this.cmbSolicitante.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Location = new System.Drawing.Point(693, 25);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 25);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Filtrar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(75, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estacion:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Listados.Listado_VentaProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 117);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1145, 974);
            this.reportViewer1.TabIndex = 7;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // rv_prodXventas
            // 
            this.rv_prodXventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource4.Name = "productosXventa";
            reportDataSource4.Value = this.TicketXProductoBindingSource;
            this.rv_prodXventas.LocalReport.DataSources.Add(reportDataSource4);
            this.rv_prodXventas.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Listados.Listado_ProductosPorVenta.rdlc";
            this.rv_prodXventas.Location = new System.Drawing.Point(7, 122);
            this.rv_prodXventas.Name = "rv_prodXventas";
            this.rv_prodXventas.ServerReport.BearerToken = null;
            this.rv_prodXventas.Size = new System.Drawing.Size(932, 855);
            this.rv_prodXventas.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_limpiarVentas);
            this.groupBox1.Controls.Add(this.cmb_nroTicket);
            this.groupBox1.Controls.Add(this.btn_filtrarVentas);
            this.groupBox1.Controls.Add(this.lbl_ticket);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(656, 110);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btn_limpiarVentas
            // 
            this.btn_limpiarVentas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_limpiarVentas.Location = new System.Drawing.Point(518, 60);
            this.btn_limpiarVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpiarVentas.Name = "btn_limpiarVentas";
            this.btn_limpiarVentas.Size = new System.Drawing.Size(95, 25);
            this.btn_limpiarVentas.TabIndex = 8;
            this.btn_limpiarVentas.Text = "Limpiar";
            this.btn_limpiarVentas.UseVisualStyleBackColor = true;
            this.btn_limpiarVentas.Click += new System.EventHandler(this.btn_limpiarVentas_Click);
            // 
            // cmb_nroTicket
            // 
            this.cmb_nroTicket.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_nroTicket.FormattingEnabled = true;
            this.cmb_nroTicket.Location = new System.Drawing.Point(205, 23);
            this.cmb_nroTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_nroTicket.Name = "cmb_nroTicket";
            this.cmb_nroTicket.Size = new System.Drawing.Size(160, 24);
            this.cmb_nroTicket.TabIndex = 2;
            // 
            // btn_filtrarVentas
            // 
            this.btn_filtrarVentas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_filtrarVentas.Location = new System.Drawing.Point(518, 23);
            this.btn_filtrarVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_filtrarVentas.Name = "btn_filtrarVentas";
            this.btn_filtrarVentas.Size = new System.Drawing.Size(95, 25);
            this.btn_filtrarVentas.TabIndex = 1;
            this.btn_filtrarVentas.Text = "Filtrar";
            this.btn_filtrarVentas.UseVisualStyleBackColor = true;
            this.btn_filtrarVentas.Click += new System.EventHandler(this.btn_filtrarVentas_Click);
            // 
            // lbl_ticket
            // 
            this.lbl_ticket.AutoSize = true;
            this.lbl_ticket.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_ticket.Location = new System.Drawing.Point(75, 26);
            this.lbl_ticket.Name = "lbl_ticket";
            this.lbl_ticket.Size = new System.Drawing.Size(124, 17);
            this.lbl_ticket.TabIndex = 3;
            this.lbl_ticket.Text = "Numero de Ticket:";
            // 
            // TicketXProductoBindingSource
            // 
            this.TicketXProductoBindingSource.DataMember = "TicketXProducto";
            this.TicketXProductoBindingSource.DataSource = this.dataSetTablasBD;
            // 
            // frm_ListadoVentaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 1055);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1194, 1028);
            this.Name = "frm_ListadoVentaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de ventas";
            this.Load += new System.EventHandler(this.frm_ListadoVentaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBD)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grb_filtros.ResumeLayout(false);
            this.grb_filtros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketXProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSetTablasBDBindingSource;
        private DataSetTablasBD dataSetTablasBD;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label txtWhere;
        private System.Windows.Forms.GroupBox grb_filtros;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.ComboBox cmbSolicitante;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer rv_prodXventas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_limpiarVentas;
        private System.Windows.Forms.ComboBox cmb_nroTicket;
        private System.Windows.Forms.Button btn_filtrarVentas;
        private System.Windows.Forms.Label lbl_ticket;
        private System.Windows.Forms.BindingSource TicketXProductoBindingSource;
    }
}