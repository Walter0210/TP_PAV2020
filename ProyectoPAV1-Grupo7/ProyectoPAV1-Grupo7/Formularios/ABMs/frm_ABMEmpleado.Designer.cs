namespace ProyectoPAV1_Grupo7.Formularios
{
    partial class frm_ABMEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
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
            this.dgrEmpleado = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LegSuperior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblLegSup = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxDocumento = new System.Windows.Forms.MaskedTextBox();
            this.tbxLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.tbxLegSup = new System.Windows.Forms.ComboBox();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.checkSupervisor = new System.Windows.Forms.CheckBox();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrEmpleado)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(7, 12);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(119, 25);
            this.lblTitulo.TabIndex = 60;
            this.lblTitulo.Text = "Empleados";
            // 
            // dgrEmpleado
            // 
            this.dgrEmpleado.AllowUserToAddRows = false;
            this.dgrEmpleado.AllowUserToDeleteRows = false;
            this.dgrEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Nombre,
            this.Apellido,
            this.TipoDoc,
            this.Documento,
            this.FechaNac,
            this.FechaAlta,
            this.LegSuperior});
            this.dgrEmpleado.Location = new System.Drawing.Point(372, 12);
            this.dgrEmpleado.MultiSelect = false;
            this.dgrEmpleado.Name = "dgrEmpleado";
            this.dgrEmpleado.ReadOnly = true;
            this.dgrEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrEmpleado.Size = new System.Drawing.Size(500, 417);
            this.dgrEmpleado.TabIndex = 59;
            this.dgrEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrEmpleado_CellContentClick);
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // TipoDoc
            // 
            this.TipoDoc.DataPropertyName = "nombre1";
            this.TipoDoc.HeaderText = "Tipo Documento";
            this.TipoDoc.Name = "TipoDoc";
            this.TipoDoc.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "nroDoc";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // FechaNac
            // 
            this.FechaNac.DataPropertyName = "fechaNacimiento";
            this.FechaNac.HeaderText = "Fecha Nacimiento";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            // 
            // FechaAlta
            // 
            this.FechaAlta.DataPropertyName = "fechaAlta";
            this.FechaAlta.HeaderText = "Fecha Alta";
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.ReadOnly = true;
            // 
            // LegSuperior
            // 
            this.LegSuperior.DataPropertyName = "legajoSuperior";
            this.LegSuperior.HeaderText = "Legajo Superior";
            this.LegSuperior.Name = "LegSuperior";
            this.LegSuperior.ReadOnly = true;
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(188, 406);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEmpleado.TabIndex = 58;
            this.btnEliminarEmpleado.Text = "Eliminar";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(106, 406);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 57;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.Location = new System.Drawing.Point(24, 406);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrar.Location = new System.Drawing.Point(270, 406);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 55;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(7, 136);
            this.lblTipoDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(101, 13);
            this.lblTipoDoc.TabIndex = 53;
            this.lblTipoDoc.Text = "Tipo de Documento";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(12, 206);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 52;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(188, 133);
            this.cmbTipoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(161, 21);
            this.cmbTipoDoc.TabIndex = 47;
            // 
            // lblLegSup
            // 
            this.lblLegSup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLegSup.AutoSize = true;
            this.lblLegSup.Location = new System.Drawing.Point(12, 269);
            this.lblLegSup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLegSup.Name = "lblLegSup";
            this.lblLegSup.Size = new System.Drawing.Size(57, 13);
            this.lblLegSup.TabIndex = 45;
            this.lblLegSup.Text = "Supervisor";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(12, 239);
            this.lblFechaAlta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(73, 13);
            this.lblFechaAlta.TabIndex = 44;
            this.lblFechaAlta.Text = "Fecha de Alta";
            // 
            // lblDocumento
            // 
            this.lblDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(12, 170);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 41;
            this.lblDocumento.Text = "Documento";
            // 
            // tbxApellido
            // 
            this.tbxApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxApellido.Location = new System.Drawing.Point(188, 100);
            this.tbxApellido.Margin = new System.Windows.Forms.Padding(2);
            this.tbxApellido.MaxLength = 20;
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(161, 20);
            this.tbxApellido.TabIndex = 40;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(7, 103);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 39;
            this.lblApellido.Text = "Apellido";
            // 
            // tbxNombre
            // 
            this.tbxNombre.AcceptsReturn = true;
            this.tbxNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxNombre.Location = new System.Drawing.Point(188, 67);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNombre.MaxLength = 20;
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(161, 20);
            this.tbxNombre.TabIndex = 38;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 70);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre";
            // 
            // tbxDocumento
            // 
            this.tbxDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxDocumento.Location = new System.Drawing.Point(188, 167);
            this.tbxDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDocumento.Mask = "00000000";
            this.tbxDocumento.Name = "tbxDocumento";
            this.tbxDocumento.Size = new System.Drawing.Size(161, 20);
            this.tbxDocumento.TabIndex = 63;
            this.tbxDocumento.ValidatingType = typeof(int);
            // 
            // tbxLegajo
            // 
            this.tbxLegajo.AcceptsReturn = true;
            this.tbxLegajo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxLegajo.Location = new System.Drawing.Point(277, 34);
            this.tbxLegajo.Margin = new System.Windows.Forms.Padding(2);
            this.tbxLegajo.MaxLength = 10;
            this.tbxLegajo.Name = "tbxLegajo";
            this.tbxLegajo.Size = new System.Drawing.Size(72, 20);
            this.tbxLegajo.TabIndex = 64;
            // 
            // lblLegajo
            // 
            this.lblLegajo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(7, 37);
            this.lblLegajo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 65;
            this.lblLegajo.Text = "Legajo";
            // 
            // tbxLegSup
            // 
            this.tbxLegSup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxLegSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbxLegSup.FormattingEnabled = true;
            this.tbxLegSup.Location = new System.Drawing.Point(188, 266);
            this.tbxLegSup.Margin = new System.Windows.Forms.Padding(2);
            this.tbxLegSup.Name = "tbxLegSup";
            this.tbxLegSup.Size = new System.Drawing.Size(161, 21);
            this.tbxLegSup.TabIndex = 66;
            // 
            // grpDatos
            // 
            this.grpDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDatos.Controls.Add(this.checkSupervisor);
            this.grpDatos.Controls.Add(this.dtpFechaAlta);
            this.grpDatos.Controls.Add(this.dtpFechaNac);
            this.grpDatos.Controls.Add(this.tbxLegajo);
            this.grpDatos.Controls.Add(this.tbxLegSup);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.lblLegajo);
            this.grpDatos.Controls.Add(this.tbxNombre);
            this.grpDatos.Controls.Add(this.lblApellido);
            this.grpDatos.Controls.Add(this.tbxDocumento);
            this.grpDatos.Controls.Add(this.tbxApellido);
            this.grpDatos.Controls.Add(this.lblDocumento);
            this.grpDatos.Controls.Add(this.lblFechaAlta);
            this.grpDatos.Controls.Add(this.lblLegSup);
            this.grpDatos.Controls.Add(this.cmbTipoDoc);
            this.grpDatos.Controls.Add(this.lblFechaNacimiento);
            this.grpDatos.Controls.Add(this.lblTipoDoc);
            this.grpDatos.Location = new System.Drawing.Point(12, 88);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(354, 312);
            this.grpDatos.TabIndex = 67;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos de Empleados";
            // 
            // checkSupervisor
            // 
            this.checkSupervisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkSupervisor.AutoSize = true;
            this.checkSupervisor.Location = new System.Drawing.Point(80, 268);
            this.checkSupervisor.Name = "checkSupervisor";
            this.checkSupervisor.Size = new System.Drawing.Size(89, 17);
            this.checkSupervisor.TabIndex = 69;
            this.checkSupervisor.Text = "Es supervisor";
            this.checkSupervisor.UseVisualStyleBackColor = true;
            this.checkSupervisor.CheckedChanged += new System.EventHandler(this.checkSupervisor_CheckedChanged);
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaAlta.Enabled = false;
            this.dtpFechaAlta.Location = new System.Drawing.Point(188, 233);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(161, 20);
            this.dtpFechaAlta.TabIndex = 68;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaNac.Location = new System.Drawing.Point(188, 200);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(161, 20);
            this.dtpFechaNac.TabIndex = 67;
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(153, 61);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(127, 20);
            this.txtBoxBuscar.TabIndex = 68;
            this.txtBoxBuscar.Text = "Buscar...";
            this.txtBoxBuscar.Click += new System.EventHandler(this.txtBoxBuscar_Click);
            this.txtBoxBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(286, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 69;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frm_ABMEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 441);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgrEmpleado);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCerrar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(900, 480);
            this.Name = "frm_ABMEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Empleado";
            this.Load += new System.EventHandler(this.frm_ABMEmpleado_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgrEmpleado)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgrEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label lblLegSup;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MaskedTextBox tbxDocumento;
        private System.Windows.Forms.TextBox tbxLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.ComboBox tbxLegSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegSuperior;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.CheckBox checkSupervisor;
    }
}