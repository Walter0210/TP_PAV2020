namespace ProyectoPAV1_Grupo7.Formularios.Procesos
{
    partial class frm_OrdenCompra
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
            this.dgrDetalleOC = new System.Windows.Forms.DataGridView();
            this.numOrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUrgencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBoxProductos = new System.Windows.Forms.GroupBox();
            this.lblUrgencia = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbUrgencia = new System.Windows.Forms.ComboBox();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.txtBoxCantidad = new System.Windows.Forms.MaskedTextBox();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.groupBoxDatosOC = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCalculado = new System.Windows.Forms.Label();
            this.lblNroOrden = new System.Windows.Forms.Label();
            this.lblEstacion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtBoxNroOrden = new System.Windows.Forms.TextBox();
            this.cmbEstacion = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDetalleOC)).BeginInit();
            this.groupBoxProductos.SuspendLayout();
            this.groupBoxDatosOC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(92, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(247, 25);
            this.lblTitulo.TabIndex = 62;
            this.lblTitulo.Text = "Nueva Orden de compra";
            // 
            // dgrDetalleOC
            // 
            this.dgrDetalleOC.AllowUserToAddRows = false;
            this.dgrDetalleOC.AllowUserToDeleteRows = false;
            this.dgrDetalleOC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrDetalleOC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrDetalleOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDetalleOC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numOrdenCompra,
            this.producto,
            this.cantidad,
            this.uniMedida,
            this.precio,
            this.idUrgencia});
            this.dgrDetalleOC.Location = new System.Drawing.Point(344, 12);
            this.dgrDetalleOC.MultiSelect = false;
            this.dgrDetalleOC.Name = "dgrDetalleOC";
            this.dgrDetalleOC.ReadOnly = true;
            this.dgrDetalleOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrDetalleOC.Size = new System.Drawing.Size(355, 618);
            this.dgrDetalleOC.TabIndex = 68;
            this.dgrDetalleOC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDetalleOC_CellClick);
            // 
            // numOrdenCompra
            // 
            this.numOrdenCompra.DataPropertyName = "numOrdenCompra";
            this.numOrdenCompra.HeaderText = "nroOrdenCompra";
            this.numOrdenCompra.Name = "numOrdenCompra";
            this.numOrdenCompra.ReadOnly = true;
            this.numOrdenCompra.Visible = false;
            // 
            // producto
            // 
            this.producto.DataPropertyName = "idProducto";
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // uniMedida
            // 
            this.uniMedida.DataPropertyName = "idUnidadMedida";
            this.uniMedida.HeaderText = "Unidad Medida";
            this.uniMedida.Name = "uniMedida";
            this.uniMedida.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio Unitario";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // idUrgencia
            // 
            this.idUrgencia.DataPropertyName = "idUrgencia";
            this.idUrgencia.HeaderText = "Urgencia";
            this.idUrgencia.Name = "idUrgencia";
            this.idUrgencia.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.Location = new System.Drawing.Point(107, 596);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 34);
            this.btnGuardar.TabIndex = 81;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBoxProductos
            // 
            this.groupBoxProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxProductos.Controls.Add(this.lblUrgencia);
            this.groupBoxProductos.Controls.Add(this.lblPrecio);
            this.groupBoxProductos.Controls.Add(this.lblProducto);
            this.groupBoxProductos.Controls.Add(this.lblCantidad);
            this.groupBoxProductos.Controls.Add(this.cmbUrgencia);
            this.groupBoxProductos.Controls.Add(this.txtBoxPrecio);
            this.groupBoxProductos.Controls.Add(this.txtBoxCantidad);
            this.groupBoxProductos.Controls.Add(this.btnModificarProducto);
            this.groupBoxProductos.Controls.Add(this.btnEliminarProducto);
            this.groupBoxProductos.Controls.Add(this.btnAgregarProducto);
            this.groupBoxProductos.Controls.Add(this.cmbUnidadMedida);
            this.groupBoxProductos.Controls.Add(this.cmbProducto);
            this.groupBoxProductos.Location = new System.Drawing.Point(12, 284);
            this.groupBoxProductos.Name = "groupBoxProductos";
            this.groupBoxProductos.Size = new System.Drawing.Size(311, 200);
            this.groupBoxProductos.TabIndex = 83;
            this.groupBoxProductos.TabStop = false;
            this.groupBoxProductos.Text = "Seleccion de Productos";
            // 
            // lblUrgencia
            // 
            this.lblUrgencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrgencia.AutoSize = true;
            this.lblUrgencia.Location = new System.Drawing.Point(27, 117);
            this.lblUrgencia.Name = "lblUrgencia";
            this.lblUrgencia.Size = new System.Drawing.Size(95, 13);
            this.lblUrgencia.TabIndex = 97;
            this.lblUrgencia.Text = "Nivel de Urgencia:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(43, 91);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(79, 13);
            this.lblPrecio.TabIndex = 96;
            this.lblPrecio.Text = "Precio Unitario:";
            // 
            // lblProducto
            // 
            this.lblProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(69, 37);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 95;
            this.lblProducto.Text = "Producto:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(27, 64);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(99, 13);
            this.lblCantidad.TabIndex = 94;
            this.lblCantidad.Text = "Cantidad solicitada:";
            // 
            // cmbUrgencia
            // 
            this.cmbUrgencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUrgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrgencia.FormattingEnabled = true;
            this.cmbUrgencia.Location = new System.Drawing.Point(142, 114);
            this.cmbUrgencia.Name = "cmbUrgencia";
            this.cmbUrgencia.Size = new System.Drawing.Size(149, 21);
            this.cmbUrgencia.TabIndex = 92;
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPrecio.Enabled = false;
            this.txtBoxPrecio.Location = new System.Drawing.Point(142, 88);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(149, 20);
            this.txtBoxPrecio.TabIndex = 91;
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxCantidad.Location = new System.Drawing.Point(141, 62);
            this.txtBoxCantidad.Mask = "000000";
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(72, 20);
            this.txtBoxCantidad.TabIndex = 89;
            this.txtBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarProducto.Location = new System.Drawing.Point(119, 162);
            this.btnModificarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(73, 24);
            this.btnModificarProducto.TabIndex = 88;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarProducto.Location = new System.Drawing.Point(41, 162);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(73, 24);
            this.btnEliminarProducto.TabIndex = 86;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(196, 162);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(73, 24);
            this.btnAgregarProducto.TabIndex = 87;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(220, 61);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(72, 21);
            this.cmbUnidadMedida.TabIndex = 82;
            // 
            // cmbProducto
            // 
            this.cmbProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(141, 34);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(150, 21);
            this.cmbProducto.TabIndex = 85;
            this.cmbProducto.DropDownClosed += new System.EventHandler(this.cmbProducto_DropDownClosed);
            // 
            // groupBoxDatosOC
            // 
            this.groupBoxDatosOC.Controls.Add(this.lblTotal);
            this.groupBoxDatosOC.Controls.Add(this.lblTotalCalculado);
            this.groupBoxDatosOC.Controls.Add(this.lblNroOrden);
            this.groupBoxDatosOC.Controls.Add(this.lblEstacion);
            this.groupBoxDatosOC.Controls.Add(this.lblFecha);
            this.groupBoxDatosOC.Controls.Add(this.lblResponsable);
            this.groupBoxDatosOC.Controls.Add(this.txtBoxNroOrden);
            this.groupBoxDatosOC.Controls.Add(this.cmbEstacion);
            this.groupBoxDatosOC.Controls.Add(this.cmbEmpleado);
            this.groupBoxDatosOC.Controls.Add(this.dateTimePicker1);
            this.groupBoxDatosOC.Location = new System.Drawing.Point(12, 68);
            this.groupBoxDatosOC.Name = "groupBoxDatosOC";
            this.groupBoxDatosOC.Size = new System.Drawing.Size(311, 190);
            this.groupBoxDatosOC.TabIndex = 84;
            this.groupBoxDatosOC.TabStop = false;
            this.groupBoxDatosOC.Text = "Datos de la Orden de Compra";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(17, 164);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 13);
            this.lblTotal.TabIndex = 89;
            this.lblTotal.Text = "Total de la Orden:";
            // 
            // lblTotalCalculado
            // 
            this.lblTotalCalculado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCalculado.AutoSize = true;
            this.lblTotalCalculado.Location = new System.Drawing.Point(200, 164);
            this.lblTotalCalculado.Name = "lblTotalCalculado";
            this.lblTotalCalculado.Size = new System.Drawing.Size(19, 13);
            this.lblTotalCalculado.TabIndex = 88;
            this.lblTotalCalculado.Text = "$0";
            // 
            // lblNroOrden
            // 
            this.lblNroOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNroOrden.AutoSize = true;
            this.lblNroOrden.Location = new System.Drawing.Point(28, 36);
            this.lblNroOrden.Name = "lblNroOrden";
            this.lblNroOrden.Size = new System.Drawing.Size(94, 13);
            this.lblNroOrden.TabIndex = 87;
            this.lblNroOrden.Text = "Número de Orden:";
            // 
            // lblEstacion
            // 
            this.lblEstacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstacion.AutoSize = true;
            this.lblEstacion.Location = new System.Drawing.Point(64, 89);
            this.lblEstacion.Name = "lblEstacion";
            this.lblEstacion.Size = new System.Drawing.Size(51, 13);
            this.lblEstacion.TabIndex = 86;
            this.lblEstacion.Text = "Estacion:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(28, 119);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 13);
            this.lblFecha.TabIndex = 85;
            this.lblFecha.Text = "Fecha de Emision:";
            // 
            // lblResponsable
            // 
            this.lblResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(50, 62);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(72, 13);
            this.lblResponsable.TabIndex = 84;
            this.lblResponsable.Text = "Responsable:";
            // 
            // txtBoxNroOrden
            // 
            this.txtBoxNroOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNroOrden.Enabled = false;
            this.txtBoxNroOrden.Location = new System.Drawing.Point(167, 33);
            this.txtBoxNroOrden.Name = "txtBoxNroOrden";
            this.txtBoxNroOrden.Size = new System.Drawing.Size(124, 20);
            this.txtBoxNroOrden.TabIndex = 83;
            // 
            // cmbEstacion
            // 
            this.cmbEstacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstacion.FormattingEnabled = true;
            this.cmbEstacion.Location = new System.Drawing.Point(167, 86);
            this.cmbEstacion.Name = "cmbEstacion";
            this.cmbEstacion.Size = new System.Drawing.Size(124, 21);
            this.cmbEstacion.TabIndex = 81;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(167, 59);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(124, 21);
            this.cmbEmpleado.TabIndex = 79;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker1.TabIndex = 77;
            // 
            // frm_OrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 642);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxDatosOC);
            this.Controls.Add(this.groupBoxProductos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgrDetalleOC);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_OrdenCompra";
            this.Text = "frm_OrdenCompra";
            this.Load += new System.EventHandler(this.frm_OrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDetalleOC)).EndInit();
            this.groupBoxProductos.ResumeLayout(false);
            this.groupBoxProductos.PerformLayout();
            this.groupBoxDatosOC.ResumeLayout(false);
            this.groupBoxDatosOC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgrDetalleOC;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBoxProductos;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.GroupBox groupBoxDatosOC;
        private System.Windows.Forms.ComboBox cmbEstacion;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox txtBoxCantidad;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.TextBox txtBoxNroOrden;
        private System.Windows.Forms.ComboBox cmbUrgencia;
        private System.Windows.Forms.Label lblUrgencia;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNroOrden;
        private System.Windows.Forms.Label lblEstacion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUrgencia;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalCalculado;
    }
}