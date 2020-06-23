namespace ProyectoPAV1_Grupo7.Formularios.Reportes
{
    partial class frm_ListadoOrdenesCompra
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
            this.txtWhere = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.cmbSolicitante = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rv_ListadoGeneral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_LimpiarFiltrosPromedios = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbResponsable2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_FechaHasta2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaDesde2 = new System.Windows.Forms.DateTimePicker();
            this.cmbEstacion2 = new System.Windows.Forms.ComboBox();
            this.btn_FiltrarPromedios = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rv_promedios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_limpiarTab3 = new System.Windows.Forms.Button();
            this.cmb_nroOrden = new System.Windows.Forms.ComboBox();
            this.btn_filtrarTab3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.rv_productosPorOC = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Responsable = new System.Windows.Forms.TextBox();
            this.txt_Estacion = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWhere
            // 
            this.txtWhere.AutoSize = true;
            this.txtWhere.Location = new System.Drawing.Point(29, 128);
            this.txtWhere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(0, 17);
            this.txtWhere.TabIndex = 5;
            this.txtWhere.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(979, 1060);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.rv_ListadoGeneral);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(971, 1026);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado General";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbResponsable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Controls.Add(this.cmbSolicitante);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(831, 107);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(692, 63);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(95, 25);
            this.btnLimpiarFiltros.TabIndex = 9;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Responsable";
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(141, 62);
            this.cmbResponsable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(160, 24);
            this.cmbResponsable.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(476, 60);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(160, 22);
            this.dtpHasta.TabIndex = 5;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(476, 21);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(160, 22);
            this.dtpDesde.TabIndex = 4;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // cmbSolicitante
            // 
            this.cmbSolicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSolicitante.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSolicitante.FormattingEnabled = true;
            this.cmbSolicitante.Location = new System.Drawing.Point(141, 21);
            this.cmbSolicitante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSolicitante.Name = "cmbSolicitante";
            this.cmbSolicitante.Size = new System.Drawing.Size(160, 24);
            this.cmbSolicitante.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFiltrar.Location = new System.Drawing.Point(692, 21);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(95, 25);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estacion:";
            // 
            // rv_ListadoGeneral
            // 
            this.rv_ListadoGeneral.AutoScroll = true;
            this.rv_ListadoGeneral.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rv_ListadoGeneral.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Listados.ListadoOrdenesCompra.rdlc";
            this.rv_ListadoGeneral.Location = new System.Drawing.Point(4, 122);
            this.rv_ListadoGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rv_ListadoGeneral.Name = "rv_ListadoGeneral";
            this.rv_ListadoGeneral.ServerReport.BearerToken = null;
            this.rv_ListadoGeneral.Size = new System.Drawing.Size(963, 900);
            this.rv_ListadoGeneral.TabIndex = 5;
            this.rv_ListadoGeneral.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rv_ListadoGeneral.Load += new System.EventHandler(this.rv_ListadiGeneral_Load);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.rv_promedios);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(971, 1026);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Promedios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_LimpiarFiltrosPromedios);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbResponsable2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtp_FechaHasta2);
            this.groupBox2.Controls.Add(this.dtp_FechaDesde2);
            this.groupBox2.Controls.Add(this.cmbEstacion2);
            this.groupBox2.Controls.Add(this.btn_FiltrarPromedios);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(16, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(831, 107);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // btn_LimpiarFiltrosPromedios
            // 
            this.btn_LimpiarFiltrosPromedios.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_LimpiarFiltrosPromedios.Location = new System.Drawing.Point(692, 63);
            this.btn_LimpiarFiltrosPromedios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LimpiarFiltrosPromedios.Name = "btn_LimpiarFiltrosPromedios";
            this.btn_LimpiarFiltrosPromedios.Size = new System.Drawing.Size(95, 25);
            this.btn_LimpiarFiltrosPromedios.TabIndex = 9;
            this.btn_LimpiarFiltrosPromedios.Text = "Limpiar";
            this.btn_LimpiarFiltrosPromedios.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Responsable";
            // 
            // cmbResponsable2
            // 
            this.cmbResponsable2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsable2.FormattingEnabled = true;
            this.cmbResponsable2.Location = new System.Drawing.Point(141, 62);
            this.cmbResponsable2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbResponsable2.Name = "cmbResponsable2";
            this.cmbResponsable2.Size = new System.Drawing.Size(160, 24);
            this.cmbResponsable2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha hasta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha desde:";
            // 
            // dtp_FechaHasta2
            // 
            this.dtp_FechaHasta2.Location = new System.Drawing.Point(476, 60);
            this.dtp_FechaHasta2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_FechaHasta2.Name = "dtp_FechaHasta2";
            this.dtp_FechaHasta2.Size = new System.Drawing.Size(160, 22);
            this.dtp_FechaHasta2.TabIndex = 5;
            // 
            // dtp_FechaDesde2
            // 
            this.dtp_FechaDesde2.Location = new System.Drawing.Point(476, 21);
            this.dtp_FechaDesde2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_FechaDesde2.Name = "dtp_FechaDesde2";
            this.dtp_FechaDesde2.Size = new System.Drawing.Size(160, 22);
            this.dtp_FechaDesde2.TabIndex = 4;
            // 
            // cmbEstacion2
            // 
            this.cmbEstacion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstacion2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEstacion2.FormattingEnabled = true;
            this.cmbEstacion2.Location = new System.Drawing.Point(141, 21);
            this.cmbEstacion2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstacion2.Name = "cmbEstacion2";
            this.cmbEstacion2.Size = new System.Drawing.Size(160, 24);
            this.cmbEstacion2.TabIndex = 2;
            // 
            // btn_FiltrarPromedios
            // 
            this.btn_FiltrarPromedios.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_FiltrarPromedios.Location = new System.Drawing.Point(692, 21);
            this.btn_FiltrarPromedios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_FiltrarPromedios.Name = "btn_FiltrarPromedios";
            this.btn_FiltrarPromedios.Size = new System.Drawing.Size(95, 25);
            this.btn_FiltrarPromedios.TabIndex = 1;
            this.btn_FiltrarPromedios.Text = "Filtrar";
            this.btn_FiltrarPromedios.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Location = new System.Drawing.Point(53, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Estacion:";
            // 
            // rv_promedios
            // 
            this.rv_promedios.AutoScroll = true;
            this.rv_promedios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rv_promedios.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.ListadoOrdenesCompra.rdlc";
            this.rv_promedios.Location = new System.Drawing.Point(4, 122);
            this.rv_promedios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rv_promedios.Name = "rv_promedios";
            this.rv_promedios.ServerReport.BearerToken = null;
            this.rv_promedios.Size = new System.Drawing.Size(963, 900);
            this.rv_promedios.TabIndex = 7;
            this.rv_promedios.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rv_promedios.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.rv_productosPorOC);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(971, 1031);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Productos por OC";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_limpiarTab3);
            this.groupBox3.Controls.Add(this.cmb_nroOrden);
            this.groupBox3.Controls.Add(this.btn_filtrarTab3);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(7, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(615, 107);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // btn_limpiarTab3
            // 
            this.btn_limpiarTab3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_limpiarTab3.Location = new System.Drawing.Point(423, 59);
            this.btn_limpiarTab3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpiarTab3.Name = "btn_limpiarTab3";
            this.btn_limpiarTab3.Size = new System.Drawing.Size(95, 25);
            this.btn_limpiarTab3.TabIndex = 9;
            this.btn_limpiarTab3.Text = "Limpiar";
            this.btn_limpiarTab3.UseVisualStyleBackColor = true;
            // 
            // cmb_nroOrden
            // 
            this.cmb_nroOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nroOrden.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_nroOrden.FormattingEnabled = true;
            this.cmb_nroOrden.Location = new System.Drawing.Point(173, 23);
            this.cmb_nroOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_nroOrden.Name = "cmb_nroOrden";
            this.cmb_nroOrden.Size = new System.Drawing.Size(160, 24);
            this.cmb_nroOrden.TabIndex = 2;
            // 
            // btn_filtrarTab3
            // 
            this.btn_filtrarTab3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_filtrarTab3.Location = new System.Drawing.Point(423, 17);
            this.btn_filtrarTab3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_filtrarTab3.Name = "btn_filtrarTab3";
            this.btn_filtrarTab3.Size = new System.Drawing.Size(95, 25);
            this.btn_filtrarTab3.TabIndex = 1;
            this.btn_filtrarTab3.Text = "Filtrar";
            this.btn_filtrarTab3.UseVisualStyleBackColor = true;
            this.btn_filtrarTab3.Click += new System.EventHandler(this.btn_filtrarTab3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Location = new System.Drawing.Point(18, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Nro Orden de Compra:";
            // 
            // rv_productosPorOC
            // 
            this.rv_productosPorOC.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Listados.Listado_ProductosPorOC.rdlc";
            this.rv_productosPorOC.Location = new System.Drawing.Point(6, 222);
            this.rv_productosPorOC.Name = "rv_productosPorOC";
            this.rv_productosPorOC.ServerReport.BearerToken = null;
            this.rv_productosPorOC.Size = new System.Drawing.Size(955, 363);
            this.rv_productosPorOC.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_Estacion);
            this.groupBox4.Controls.Add(this.txt_Responsable);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(7, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(615, 102);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Orden Compra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Responsable:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(188, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Estacion:";
            // 
            // txt_Responsable
            // 
            this.txt_Responsable.Location = new System.Drawing.Point(289, 32);
            this.txt_Responsable.Name = "txt_Responsable";
            this.txt_Responsable.Size = new System.Drawing.Size(173, 22);
            this.txt_Responsable.TabIndex = 2;
            // 
            // txt_Estacion
            // 
            this.txt_Estacion.Location = new System.Drawing.Point(289, 63);
            this.txt_Estacion.Name = "txt_Estacion";
            this.txt_Estacion.Size = new System.Drawing.Size(173, 22);
            this.txt_Estacion.TabIndex = 3;
            // 
            // frm_ListadoOrdenesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 1055);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtWhere);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(994, 1028);
            this.Name = "frm_ListadoOrdenesCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Ordenes de Compra";
            this.Load += new System.EventHandler(this.frm_ListadoOrdenesCompra_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtWhere;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.ComboBox cmbSolicitante;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_ListadoGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_LimpiarFiltrosPromedios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbResponsable2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_FechaHasta2;
        private System.Windows.Forms.DateTimePicker dtp_FechaDesde2;
        private System.Windows.Forms.ComboBox cmbEstacion2;
        private System.Windows.Forms.Button btn_FiltrarPromedios;
        private System.Windows.Forms.Label label8;
        private Microsoft.Reporting.WinForms.ReportViewer rv_promedios;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer rv_productosPorOC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_limpiarTab3;
        private System.Windows.Forms.ComboBox cmb_nroOrden;
        private System.Windows.Forms.Button btn_filtrarTab3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_Estacion;
        private System.Windows.Forms.TextBox txt_Responsable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
    }
}