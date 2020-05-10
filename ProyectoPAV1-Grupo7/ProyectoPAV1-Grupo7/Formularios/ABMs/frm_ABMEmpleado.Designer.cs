namespace ProyectoPAV1_Grupo7.Formularios
{
    partial class frm_ABMEmpleado
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
            this.label6 = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.dtpFechaAlta = new System.Windows.Forms.MaskedTextBox();
            this.tbxDocumento = new System.Windows.Forms.MaskedTextBox();
            this.tbxLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.tbxLegSup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(53, 53);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(136, 29);
            this.lblTitulo.TabIndex = 60;
            this.lblTitulo.Text = "Empleado";
            // 
            // dgrEmpleado
            // 
            this.dgrEmpleado.AllowUserToAddRows = false;
            this.dgrEmpleado.AllowUserToDeleteRows = false;
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
            this.dgrEmpleado.Location = new System.Drawing.Point(497, 53);
            this.dgrEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.dgrEmpleado.Name = "dgrEmpleado";
            this.dgrEmpleado.ReadOnly = true;
            this.dgrEmpleado.Size = new System.Drawing.Size(842, 493);
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
            this.TipoDoc.DataPropertyName = "tipoDoc";
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
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(271, 518);
            this.btnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarEmpleado.TabIndex = 58;
            this.btnEliminarEmpleado.Text = "Eliminar";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(163, 518);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 57;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(55, 518);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(389, 518);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 55;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(55, 276);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(132, 17);
            this.lblTipoDoc.TabIndex = 53;
            this.lblTipoDoc.Text = "Tipo de Documento";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(54, 370);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(141, 17);
            this.lblFechaNacimiento.TabIndex = 52;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(242, 269);
            this.cmbTipoDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(213, 24);
            this.cmbTipoDoc.TabIndex = 47;
            // 
            // lblLegSup
            // 
            this.lblLegSup.AutoSize = true;
            this.lblLegSup.Location = new System.Drawing.Point(54, 471);
            this.lblLegSup.Name = "lblLegSup";
            this.lblLegSup.Size = new System.Drawing.Size(76, 17);
            this.lblLegSup.TabIndex = 45;
            this.lblLegSup.Text = "Supervisor";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(52, 421);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(95, 17);
            this.lblFechaAlta.TabIndex = 44;
            this.lblFechaAlta.Text = "Fecha de Alta";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(55, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 48;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(54, 322);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(80, 17);
            this.lblDocumento.TabIndex = 41;
            this.lblDocumento.Text = "Documento";
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(242, 218);
            this.tbxApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(213, 22);
            this.tbxApellido.TabIndex = 40;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(55, 223);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 39;
            this.lblApellido.Text = "Apellido";
            // 
            // tbxNombre
            // 
            this.tbxNombre.AcceptsReturn = true;
            this.tbxNombre.Location = new System.Drawing.Point(242, 166);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(213, 22);
            this.tbxNombre.TabIndex = 38;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 171);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(242, 365);
            this.dtpFechaNac.Mask = "00/00/0000";
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(213, 22);
            this.dtpFechaNac.TabIndex = 61;
            this.dtpFechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Location = new System.Drawing.Point(242, 418);
            this.dtpFechaAlta.Mask = "00/00/0000";
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(213, 22);
            this.dtpFechaAlta.TabIndex = 62;
            this.dtpFechaAlta.ValidatingType = typeof(System.DateTime);
            // 
            // tbxDocumento
            // 
            this.tbxDocumento.Location = new System.Drawing.Point(242, 319);
            this.tbxDocumento.Mask = "99999999";
            this.tbxDocumento.Name = "tbxDocumento";
            this.tbxDocumento.Size = new System.Drawing.Size(213, 22);
            this.tbxDocumento.TabIndex = 63;
            this.tbxDocumento.ValidatingType = typeof(int);
            // 
            // tbxLegajo
            // 
            this.tbxLegajo.AcceptsReturn = true;
            this.tbxLegajo.Location = new System.Drawing.Point(361, 120);
            this.tbxLegajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLegajo.Name = "tbxLegajo";
            this.tbxLegajo.Size = new System.Drawing.Size(94, 22);
            this.tbxLegajo.TabIndex = 64;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(55, 125);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(51, 17);
            this.lblLegajo.TabIndex = 65;
            this.lblLegajo.Text = "Legajo";
            // 
            // tbxLegSup
            // 
            this.tbxLegSup.FormattingEnabled = true;
            this.tbxLegSup.Location = new System.Drawing.Point(242, 464);
            this.tbxLegSup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLegSup.Name = "tbxLegSup";
            this.tbxLegSup.Size = new System.Drawing.Size(213, 24);
            this.tbxLegSup.TabIndex = 66;
            // 
            // frm_ABMEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 586);
            this.Controls.Add(this.tbxLegSup);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.tbxLegajo);
            this.Controls.Add(this.tbxDocumento);
            this.Controls.Add(this.dtpFechaAlta);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgrEmpleado);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.lblLegSup);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.tbxApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_ABMEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Empleado";
            this.Load += new System.EventHandler(this.frm_ABMEmpleado_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgrEmpleado)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegSuperior;
        private System.Windows.Forms.MaskedTextBox dtpFechaNac;
        private System.Windows.Forms.MaskedTextBox dtpFechaAlta;
        private System.Windows.Forms.MaskedTextBox tbxDocumento;
        private System.Windows.Forms.TextBox tbxLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.ComboBox tbxLegSup;
    }
}