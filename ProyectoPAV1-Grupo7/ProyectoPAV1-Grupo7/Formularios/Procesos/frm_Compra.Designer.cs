namespace ProyectoPAV1_Grupo7.Formularios.Procesos
{
    partial class frm_Compra
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgrTicketxProducto = new System.Windows.Forms.DataGridView();
            this.numeroTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioxcantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtBoxCantidad = new System.Windows.Forms.MaskedTextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.lblCantidadVendida = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.grpTicket = new System.Windows.Forms.GroupBox();
            this.lbCantidadVendida = new System.Windows.Forms.Label();
            this.txtBoxCantidadCombustible = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblSurtidor = new System.Windows.Forms.Label();
            this.lblTotalTicket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNroTicket = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTotalCalculado = new System.Windows.Forms.Label();
            this.cmbSurtidor = new System.Windows.Forms.ComboBox();
            this.cmbEstacion = new System.Windows.Forms.ComboBox();
            this.txtBoxNroTicket = new System.Windows.Forms.TextBox();
            this.grpObservaciones = new System.Windows.Forms.GroupBox();
            this.txtBoxObvs = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTicketxProducto)).BeginInit();
            this.grpDetalle.SuspendLayout();
            this.grpTicket.SuspendLayout();
            this.grpObservaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(112, 12);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(202, 25);
            this.lblTitulo.TabIndex = 62;
            this.lblTitulo.Text = "Venta de Productos";
            // 
            // dgrTicketxProducto
            // 
            this.dgrTicketxProducto.AllowUserToAddRows = false;
            this.dgrTicketxProducto.AllowUserToDeleteRows = false;
            this.dgrTicketxProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrTicketxProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrTicketxProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrTicketxProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroTicket,
            this.idProducto,
            this.cantidad,
            this.precioxcantidad});
            this.dgrTicketxProducto.Location = new System.Drawing.Point(351, 12);
            this.dgrTicketxProducto.MultiSelect = false;
            this.dgrTicketxProducto.Name = "dgrTicketxProducto";
            this.dgrTicketxProducto.ReadOnly = true;
            this.dgrTicketxProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrTicketxProducto.Size = new System.Drawing.Size(400, 463);
            this.dgrTicketxProducto.TabIndex = 79;
            this.dgrTicketxProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrTicketxProducto_CellClick);
            // 
            // numeroTicket
            // 
            this.numeroTicket.HeaderText = "Numero de Ticket";
            this.numeroTicket.Name = "numeroTicket";
            this.numeroTicket.ReadOnly = true;
            this.numeroTicket.Visible = false;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "Producto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precioxcantidad
            // 
            this.precioxcantidad.HeaderText = "Precio x Cantidad vendida";
            this.precioxcantidad.Name = "precioxcantidad";
            this.precioxcantidad.ReadOnly = true;
            // 
            // cmbProducto
            // 
            this.cmbProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(181, 28);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(100, 21);
            this.cmbProducto.TabIndex = 81;
            this.cmbProducto.DropDownClosed += new System.EventHandler(this.cmbProducto_DropDownClosed);
            // 
            // lblProducto
            // 
            this.lblProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(67, 31);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 82;
            this.lblProducto.Text = "Producto:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(68, 58);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 83;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCantidad.Location = new System.Drawing.Point(181, 55);
            this.txtBoxCantidad.Mask = "00000";
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.PromptChar = '#';
            this.txtBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCantidad.TabIndex = 84;
            this.txtBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxCantidad.TextChanged += new System.EventHandler(this.txtBoxCantidad_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(86, 84);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 85;
            this.lblTotal.Text = "Total:";
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTotal.Enabled = false;
            this.txtBoxTotal.Location = new System.Drawing.Point(181, 81);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTotal.TabIndex = 86;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizar.Location = new System.Drawing.Point(240, 595);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(283, 34);
            this.btnFinalizar.TabIndex = 88;
            this.btnFinalizar.Text = "Finalizar Venta";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // grpDetalle
            // 
            this.grpDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDetalle.Controls.Add(this.lblCantidadVendida);
            this.grpDetalle.Controls.Add(this.lblPrecioUnitario);
            this.grpDetalle.Controls.Add(this.btnModificarProducto);
            this.grpDetalle.Controls.Add(this.btnEliminarProducto);
            this.grpDetalle.Controls.Add(this.btnAgregarProducto);
            this.grpDetalle.Controls.Add(this.cmbProducto);
            this.grpDetalle.Controls.Add(this.lblProducto);
            this.grpDetalle.Controls.Add(this.txtBoxTotal);
            this.grpDetalle.Controls.Add(this.lblCantidad);
            this.grpDetalle.Controls.Add(this.lblTotal);
            this.grpDetalle.Controls.Add(this.txtBoxCantidad);
            this.grpDetalle.Location = new System.Drawing.Point(12, 315);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Size = new System.Drawing.Size(333, 160);
            this.grpDetalle.TabIndex = 89;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Datos del Producto";
            // 
            // lblCantidadVendida
            // 
            this.lblCantidadVendida.AutoSize = true;
            this.lblCantidadVendida.Location = new System.Drawing.Point(16, 84);
            this.lblCantidadVendida.Name = "lblCantidadVendida";
            this.lblCantidadVendida.Size = new System.Drawing.Size(13, 13);
            this.lblCantidadVendida.TabIndex = 93;
            this.lblCantidadVendida.Text = "0";
            this.lblCantidadVendida.Visible = false;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Enabled = false;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(16, 58);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(13, 13);
            this.lblPrecioUnitario.TabIndex = 92;
            this.lblPrecioUnitario.Text = "0";
            this.lblPrecioUnitario.Visible = false;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarProducto.AutoSize = true;
            this.btnModificarProducto.Location = new System.Drawing.Point(129, 129);
            this.btnModificarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(73, 26);
            this.btnModificarProducto.TabIndex = 91;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarProducto.AutoSize = true;
            this.btnEliminarProducto.Location = new System.Drawing.Point(46, 129);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(73, 26);
            this.btnEliminarProducto.TabIndex = 89;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.AutoSize = true;
            this.btnAgregarProducto.Location = new System.Drawing.Point(212, 129);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(73, 26);
            this.btnAgregarProducto.TabIndex = 90;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // grpTicket
            // 
            this.grpTicket.Controls.Add(this.lbCantidadVendida);
            this.grpTicket.Controls.Add(this.txtBoxCantidadCombustible);
            this.grpTicket.Controls.Add(this.label3);
            this.grpTicket.Controls.Add(this.cmbUnidadMedida);
            this.grpTicket.Controls.Add(this.lblSurtidor);
            this.grpTicket.Controls.Add(this.lblTotalTicket);
            this.grpTicket.Controls.Add(this.label1);
            this.grpTicket.Controls.Add(this.lblFecha);
            this.grpTicket.Controls.Add(this.lblNroTicket);
            this.grpTicket.Controls.Add(this.dateTimePicker1);
            this.grpTicket.Controls.Add(this.lblTotalCalculado);
            this.grpTicket.Controls.Add(this.cmbSurtidor);
            this.grpTicket.Controls.Add(this.cmbEstacion);
            this.grpTicket.Controls.Add(this.txtBoxNroTicket);
            this.grpTicket.Location = new System.Drawing.Point(12, 69);
            this.grpTicket.Name = "grpTicket";
            this.grpTicket.Size = new System.Drawing.Size(333, 240);
            this.grpTicket.TabIndex = 90;
            this.grpTicket.TabStop = false;
            this.grpTicket.Text = "Datos generales";
            // 
            // lbCantidadVendida
            // 
            this.lbCantidadVendida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCantidadVendida.AutoSize = true;
            this.lbCantidadVendida.Location = new System.Drawing.Point(2, 172);
            this.lbCantidadVendida.Name = "lbCantidadVendida";
            this.lbCantidadVendida.Size = new System.Drawing.Size(127, 13);
            this.lbCantidadVendida.TabIndex = 104;
            this.lbCantidadVendida.Text = "Cantidad de Combustible:";
            // 
            // txtBoxCantidadCombustible
            // 
            this.txtBoxCantidadCombustible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCantidadCombustible.Location = new System.Drawing.Point(181, 169);
            this.txtBoxCantidadCombustible.Mask = "00000";
            this.txtBoxCantidadCombustible.Name = "txtBoxCantidadCombustible";
            this.txtBoxCantidadCombustible.PromptChar = '#';
            this.txtBoxCantidadCombustible.Size = new System.Drawing.Size(121, 20);
            this.txtBoxCantidadCombustible.TabIndex = 94;
            this.txtBoxCantidadCombustible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxCantidadCombustible.TextChanged += new System.EventHandler(this.txtBoxCantidadCombustible_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Unidad de Medida";
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(181, 142);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(121, 21);
            this.cmbUnidadMedida.TabIndex = 102;
            // 
            // lblSurtidor
            // 
            this.lblSurtidor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSurtidor.AutoSize = true;
            this.lblSurtidor.Location = new System.Drawing.Point(83, 118);
            this.lblSurtidor.Name = "lblSurtidor";
            this.lblSurtidor.Size = new System.Drawing.Size(46, 13);
            this.lblSurtidor.TabIndex = 101;
            this.lblSurtidor.Text = "Surtidor:";
            // 
            // lblTotalTicket
            // 
            this.lblTotalTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTicket.AutoSize = true;
            this.lblTotalTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTicket.Location = new System.Drawing.Point(46, 202);
            this.lblTotalTicket.Name = "lblTotalTicket";
            this.lblTotalTicket.Size = new System.Drawing.Size(51, 13);
            this.lblTotalTicket.TabIndex = 100;
            this.lblTotalTicket.Text = "TOTAL:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Estacion:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(51, 68);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(78, 13);
            this.lblFecha.TabIndex = 98;
            this.lblFecha.Text = "Fecha emision:";
            // 
            // lblNroTicket
            // 
            this.lblNroTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNroTicket.AutoSize = true;
            this.lblNroTicket.Location = new System.Drawing.Point(66, 39);
            this.lblNroTicket.Name = "lblNroTicket";
            this.lblNroTicket.Size = new System.Drawing.Size(63, 13);
            this.lblNroTicket.TabIndex = 97;
            this.lblNroTicket.Text = "Nro. Ticket:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 96;
            // 
            // lblTotalCalculado
            // 
            this.lblTotalCalculado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCalculado.AutoSize = true;
            this.lblTotalCalculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCalculado.Location = new System.Drawing.Point(184, 202);
            this.lblTotalCalculado.Name = "lblTotalCalculado";
            this.lblTotalCalculado.Size = new System.Drawing.Size(21, 13);
            this.lblTotalCalculado.TabIndex = 95;
            this.lblTotalCalculado.Text = "$0";
            // 
            // cmbSurtidor
            // 
            this.cmbSurtidor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSurtidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSurtidor.Enabled = false;
            this.cmbSurtidor.FormattingEnabled = true;
            this.cmbSurtidor.Location = new System.Drawing.Point(181, 115);
            this.cmbSurtidor.Name = "cmbSurtidor";
            this.cmbSurtidor.Size = new System.Drawing.Size(121, 21);
            this.cmbSurtidor.TabIndex = 94;
            // 
            // cmbEstacion
            // 
            this.cmbEstacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstacion.FormattingEnabled = true;
            this.cmbEstacion.Location = new System.Drawing.Point(181, 88);
            this.cmbEstacion.Name = "cmbEstacion";
            this.cmbEstacion.Size = new System.Drawing.Size(121, 21);
            this.cmbEstacion.TabIndex = 93;
            this.cmbEstacion.DropDownClosed += new System.EventHandler(this.cmbEstacion_DropDownClosed);
            // 
            // txtBoxNroTicket
            // 
            this.txtBoxNroTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNroTicket.Enabled = false;
            this.txtBoxNroTicket.Location = new System.Drawing.Point(181, 36);
            this.txtBoxNroTicket.Name = "txtBoxNroTicket";
            this.txtBoxNroTicket.Size = new System.Drawing.Size(121, 20);
            this.txtBoxNroTicket.TabIndex = 89;
            // 
            // grpObservaciones
            // 
            this.grpObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpObservaciones.Controls.Add(this.txtBoxObvs);
            this.grpObservaciones.Location = new System.Drawing.Point(12, 482);
            this.grpObservaciones.Name = "grpObservaciones";
            this.grpObservaciones.Size = new System.Drawing.Size(739, 107);
            this.grpObservaciones.TabIndex = 91;
            this.grpObservaciones.TabStop = false;
            this.grpObservaciones.Text = "Observaciones";
            // 
            // txtBoxObvs
            // 
            this.txtBoxObvs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxObvs.Location = new System.Drawing.Point(6, 19);
            this.txtBoxObvs.Name = "txtBoxObvs";
            this.txtBoxObvs.Size = new System.Drawing.Size(727, 82);
            this.txtBoxObvs.TabIndex = 0;
            this.txtBoxObvs.Text = "";
            // 
            // frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 641);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpObservaciones);
            this.Controls.Add(this.grpTicket);
            this.Controls.Add(this.grpDetalle);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dgrTicketxProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Compra";
            this.Text = "frm_Compra";
            this.Load += new System.EventHandler(this.frm_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrTicketxProducto)).EndInit();
            this.grpDetalle.ResumeLayout(false);
            this.grpDetalle.PerformLayout();
            this.grpTicket.ResumeLayout(false);
            this.grpTicket.PerformLayout();
            this.grpObservaciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgrTicketxProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.MaskedTextBox txtBoxCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.GroupBox grpTicket;
        private System.Windows.Forms.TextBox txtBoxNroTicket;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblTotalTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNroTicket;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTotalCalculado;
        private System.Windows.Forms.ComboBox cmbSurtidor;
        private System.Windows.Forms.ComboBox cmbEstacion;
        private System.Windows.Forms.GroupBox grpObservaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.Label lblSurtidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioxcantidad;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblCantidadVendida;
        private System.Windows.Forms.Label lbCantidadVendida;
        private System.Windows.Forms.MaskedTextBox txtBoxCantidadCombustible;
        private System.Windows.Forms.RichTextBox txtBoxObvs;
    }
}