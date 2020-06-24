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
            this.TicketXProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTablasBD = new ProyectoPAV1_Grupo7.DataSetTablasBD();
            this.dataSetTablasBDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtWhere = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grb_filtros = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFiltros1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta1 = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde1 = new System.Windows.Forms.DateTimePicker();
            this.cmbSolicitante1 = new System.Windows.Forms.ComboBox();
            this.btnFiltrar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rv_ListadoVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFiltros2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_fechaHasta2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaDesde2 = new System.Windows.Forms.DateTimePicker();
            this.cmbEstacion2 = new System.Windows.Forms.ComboBox();
            this.btnFiltrar2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rv_CantidadVendidaProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_FiltrarTab3 = new System.Windows.Forms.Button();
            this.btn_LimpiarTab3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_nroTicket = new System.Windows.Forms.ComboBox();
            this.rv_prodXventas = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.TicketXProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBDBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grb_filtros.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketXProductoBindingSource
            // 
            this.TicketXProductoBindingSource.DataMember = "TicketXProducto";
            this.TicketXProductoBindingSource.DataSource = this.dataSetTablasBD;
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
            // txtWhere
            // 
            this.txtWhere.AutoSize = true;
            this.txtWhere.Location = new System.Drawing.Point(22, 108);
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(0, 13);
            this.txtWhere.TabIndex = 6;
            this.txtWhere.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 861);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grb_filtros);
            this.tabPage1.Controls.Add(this.rv_ListadoVentas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 835);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grb_filtros
            // 
            this.grb_filtros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_filtros.Controls.Add(this.btnLimpiarFiltros1);
            this.grb_filtros.Controls.Add(this.label3);
            this.grb_filtros.Controls.Add(this.label2);
            this.grb_filtros.Controls.Add(this.dtpHasta1);
            this.grb_filtros.Controls.Add(this.dtpDesde1);
            this.grb_filtros.Controls.Add(this.cmbSolicitante1);
            this.grb_filtros.Controls.Add(this.btnFiltrar1);
            this.grb_filtros.Controls.Add(this.label1);
            this.grb_filtros.Location = new System.Drawing.Point(8, 2);
            this.grb_filtros.Name = "grb_filtros";
            this.grb_filtros.Size = new System.Drawing.Size(710, 89);
            this.grb_filtros.TabIndex = 7;
            this.grb_filtros.TabStop = false;
            this.grb_filtros.Text = "Filtros";
            // 
            // btnLimpiarFiltros1
            // 
            this.btnLimpiarFiltros1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpiarFiltros1.Location = new System.Drawing.Point(599, 51);
            this.btnLimpiarFiltros1.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarFiltros1.Name = "btnLimpiarFiltros1";
            this.btnLimpiarFiltros1.Size = new System.Drawing.Size(75, 20);
            this.btnLimpiarFiltros1.TabIndex = 8;
            this.btnLimpiarFiltros1.Text = "Limpiar filtros";
            this.btnLimpiarFiltros1.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros1.Click += new System.EventHandler(this.btnLimpiarFiltrosListado1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha desde:";
            // 
            // dtpHasta1
            // 
            this.dtpHasta1.Location = new System.Drawing.Point(372, 51);
            this.dtpHasta1.Name = "dtpHasta1";
            this.dtpHasta1.Size = new System.Drawing.Size(197, 20);
            this.dtpHasta1.TabIndex = 5;
            this.dtpHasta1.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // dtpDesde1
            // 
            this.dtpDesde1.Location = new System.Drawing.Point(372, 23);
            this.dtpDesde1.Name = "dtpDesde1";
            this.dtpDesde1.Size = new System.Drawing.Size(197, 20);
            this.dtpDesde1.TabIndex = 4;
            this.dtpDesde1.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // cmbSolicitante1
            // 
            this.cmbSolicitante1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSolicitante1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSolicitante1.FormattingEnabled = true;
            this.cmbSolicitante1.Location = new System.Drawing.Point(99, 23);
            this.cmbSolicitante1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSolicitante1.Name = "cmbSolicitante1";
            this.cmbSolicitante1.Size = new System.Drawing.Size(140, 21);
            this.cmbSolicitante1.TabIndex = 2;
            // 
            // btnFiltrar1
            // 
            this.btnFiltrar1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFiltrar1.Location = new System.Drawing.Point(599, 22);
            this.btnFiltrar1.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar1.Name = "btnFiltrar1";
            this.btnFiltrar1.Size = new System.Drawing.Size(75, 20);
            this.btnFiltrar1.TabIndex = 1;
            this.btnFiltrar1.Text = "Filtrar";
            this.btnFiltrar1.UseVisualStyleBackColor = true;
            this.btnFiltrar1.Click += new System.EventHandler(this.btnFiltrar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estacion:";
            // 
            // rv_ListadoVentas
            // 
            this.rv_ListadoVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_ListadoVentas.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Listados.Listado_VentaProductos.rdlc";
            this.rv_ListadoVentas.Location = new System.Drawing.Point(8, 102);
            this.rv_ListadoVentas.Name = "rv_ListadoVentas";
            this.rv_ListadoVentas.ServerReport.BearerToken = null;
            this.rv_ListadoVentas.Size = new System.Drawing.Size(710, 734);
            this.rv_ListadoVentas.TabIndex = 6;
            this.rv_ListadoVentas.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rv_ListadoVentas.Load += new System.EventHandler(this.rv_ListadoGeneral_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.rv_CantidadVendidaProductos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(726, 835);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cantidad Total Items Vendidos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnLimpiarFiltros2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtp_fechaHasta2);
            this.groupBox1.Controls.Add(this.dtp_fechaDesde2);
            this.groupBox1.Controls.Add(this.cmbEstacion2);
            this.groupBox1.Controls.Add(this.btnFiltrar2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(8, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 89);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnLimpiarFiltros2
            // 
            this.btnLimpiarFiltros2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpiarFiltros2.Location = new System.Drawing.Point(599, 51);
            this.btnLimpiarFiltros2.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarFiltros2.Name = "btnLimpiarFiltros2";
            this.btnLimpiarFiltros2.Size = new System.Drawing.Size(75, 20);
            this.btnLimpiarFiltros2.TabIndex = 8;
            this.btnLimpiarFiltros2.Text = "Limpiar filtros";
            this.btnLimpiarFiltros2.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros2.Click += new System.EventHandler(this.btnLimpiarFiltros2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha desde:";
            // 
            // dtp_fechaHasta2
            // 
            this.dtp_fechaHasta2.Location = new System.Drawing.Point(372, 51);
            this.dtp_fechaHasta2.Name = "dtp_fechaHasta2";
            this.dtp_fechaHasta2.Size = new System.Drawing.Size(196, 20);
            this.dtp_fechaHasta2.TabIndex = 5;
            this.dtp_fechaHasta2.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // dtp_fechaDesde2
            // 
            this.dtp_fechaDesde2.Location = new System.Drawing.Point(372, 23);
            this.dtp_fechaDesde2.Name = "dtp_fechaDesde2";
            this.dtp_fechaDesde2.Size = new System.Drawing.Size(196, 20);
            this.dtp_fechaDesde2.TabIndex = 4;
            this.dtp_fechaDesde2.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // cmbEstacion2
            // 
            this.cmbEstacion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstacion2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEstacion2.FormattingEnabled = true;
            this.cmbEstacion2.Location = new System.Drawing.Point(99, 23);
            this.cmbEstacion2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstacion2.Name = "cmbEstacion2";
            this.cmbEstacion2.Size = new System.Drawing.Size(140, 21);
            this.cmbEstacion2.TabIndex = 2;
            // 
            // btnFiltrar2
            // 
            this.btnFiltrar2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFiltrar2.Location = new System.Drawing.Point(599, 22);
            this.btnFiltrar2.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar2.Name = "btnFiltrar2";
            this.btnFiltrar2.Size = new System.Drawing.Size(75, 20);
            this.btnFiltrar2.TabIndex = 1;
            this.btnFiltrar2.Text = "Filtrar";
            this.btnFiltrar2.UseVisualStyleBackColor = true;
            this.btnFiltrar2.Click += new System.EventHandler(this.btnFiltrar2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Location = new System.Drawing.Point(39, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Estacion:";
            // 
            // rv_CantidadVendidaProductos
            // 
            this.rv_CantidadVendidaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_CantidadVendidaProductos.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Listados.CantidadTotalProdVendidos.rdlc";
            this.rv_CantidadVendidaProductos.Location = new System.Drawing.Point(8, 102);
            this.rv_CantidadVendidaProductos.Name = "rv_CantidadVendidaProductos";
            this.rv_CantidadVendidaProductos.ServerReport.BearerToken = null;
            this.rv_CantidadVendidaProductos.Size = new System.Drawing.Size(710, 734);
            this.rv_CantidadVendidaProductos.TabIndex = 8;
            this.rv_CantidadVendidaProductos.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rv_CantidadVendidaProductos.Load += new System.EventHandler(this.rv_CantidadVendidaProductos_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.rv_prodXventas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(726, 835);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos por Venta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_FiltrarTab3);
            this.groupBox4.Controls.Add(this.btn_LimpiarTab3);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.cmb_nroTicket);
            this.groupBox4.Location = new System.Drawing.Point(8, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(710, 89);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtros";
            // 
            // btn_FiltrarTab3
            // 
            this.btn_FiltrarTab3.Location = new System.Drawing.Point(599, 22);
            this.btn_FiltrarTab3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FiltrarTab3.Name = "btn_FiltrarTab3";
            this.btn_FiltrarTab3.Size = new System.Drawing.Size(75, 20);
            this.btn_FiltrarTab3.TabIndex = 16;
            this.btn_FiltrarTab3.Text = "Filtrar";
            this.btn_FiltrarTab3.UseVisualStyleBackColor = true;
            this.btn_FiltrarTab3.Click += new System.EventHandler(this.btn_FiltrarTab3_Click);
            // 
            // btn_LimpiarTab3
            // 
            this.btn_LimpiarTab3.Location = new System.Drawing.Point(599, 50);
            this.btn_LimpiarTab3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LimpiarTab3.Name = "btn_LimpiarTab3";
            this.btn_LimpiarTab3.Size = new System.Drawing.Size(75, 20);
            this.btn_LimpiarTab3.TabIndex = 15;
            this.btn_LimpiarTab3.Text = "Limpiar filtros";
            this.btn_LimpiarTab3.UseVisualStyleBackColor = true;
            this.btn_LimpiarTab3.Click += new System.EventHandler(this.btn_LimpiarTab3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Numero de Ticket:";
            // 
            // cmb_nroTicket
            // 
            this.cmb_nroTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nroTicket.FormattingEnabled = true;
            this.cmb_nroTicket.Location = new System.Drawing.Point(99, 23);
            this.cmb_nroTicket.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_nroTicket.Name = "cmb_nroTicket";
            this.cmb_nroTicket.Size = new System.Drawing.Size(150, 21);
            this.cmb_nroTicket.TabIndex = 0;
            // 
            // rv_prodXventas
            // 
            this.rv_prodXventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "productosXventa";
            reportDataSource1.Value = this.TicketXProductoBindingSource;
            this.rv_prodXventas.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_prodXventas.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Listados.Listado_ProductosPorVenta.rdlc";
            this.rv_prodXventas.Location = new System.Drawing.Point(8, 102);
            this.rv_prodXventas.Margin = new System.Windows.Forms.Padding(2);
            this.rv_prodXventas.Name = "rv_prodXventas";
            this.rv_prodXventas.ServerReport.BearerToken = null;
            this.rv_prodXventas.Size = new System.Drawing.Size(711, 727);
            this.rv_prodXventas.TabIndex = 12;
            this.rv_prodXventas.Load += new System.EventHandler(this.rv_prodXventas_Load);
            // 
            // frm_ListadoVentaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 861);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtWhere);
            this.MinimumSize = new System.Drawing.Size(750, 900);
            this.Name = "frm_ListadoVentaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de ventas";
            this.Load += new System.EventHandler(this.frm_ListadoVentaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketXProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTablasBDBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grb_filtros.ResumeLayout(false);
            this.grb_filtros.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSetTablasBDBindingSource;
        private DataSetTablasBD dataSetTablasBD;
        private System.Windows.Forms.Label txtWhere;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grb_filtros;
        private System.Windows.Forms.Button btnLimpiarFiltros1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta1;
        private System.Windows.Forms.DateTimePicker dtpDesde1;
        private System.Windows.Forms.ComboBox cmbSolicitante1;
        private System.Windows.Forms.Button btnFiltrar1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_ListadoVentas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiarFiltros2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_fechaHasta2;
        private System.Windows.Forms.DateTimePicker dtp_fechaDesde2;
        private System.Windows.Forms.ComboBox cmbEstacion2;
        private System.Windows.Forms.Button btnFiltrar2;
        private System.Windows.Forms.Label label6;
        private Microsoft.Reporting.WinForms.ReportViewer rv_CantidadVendidaProductos;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer rv_prodXventas;
        private System.Windows.Forms.BindingSource TicketXProductoBindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_FiltrarTab3;
        private System.Windows.Forms.Button btn_LimpiarTab3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_nroTicket;
    }
}