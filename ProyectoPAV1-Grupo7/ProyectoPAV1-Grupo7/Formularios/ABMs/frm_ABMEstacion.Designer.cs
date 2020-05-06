namespace ProyectoPAV1_Grupo7.Formularios
{
    partial class frm_ABMEstacion
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
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblFechaHabilitacion = new System.Windows.Forms.Label();
            this.dtFechaAta = new System.Windows.Forms.DateTimePicker();
            this.txtBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.txtBoxCalle = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.dgrEstacion = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBoxCuit = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxNumero = new System.Windows.Forms.MaskedTextBox();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrEstacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(14, 33);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(35, 13);
            this.lblCuit.TabIndex = 0;
            this.lblCuit.Text = "CUIT:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(14, 59);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "Razon Social:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(14, 85);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 2;
            this.lblCalle.Text = "Calle";
            // 
            // lblFechaHabilitacion
            // 
            this.lblFechaHabilitacion.AutoSize = true;
            this.lblFechaHabilitacion.Location = new System.Drawing.Point(14, 143);
            this.lblFechaHabilitacion.Name = "lblFechaHabilitacion";
            this.lblFechaHabilitacion.Size = new System.Drawing.Size(73, 13);
            this.lblFechaHabilitacion.TabIndex = 4;
            this.lblFechaHabilitacion.Text = "Fecha de Alta";
            // 
            // dtFechaAta
            // 
            this.dtFechaAta.Location = new System.Drawing.Point(136, 136);
            this.dtFechaAta.Name = "dtFechaAta";
            this.dtFechaAta.Size = new System.Drawing.Size(200, 20);
            this.dtFechaAta.TabIndex = 5;
            // 
            // txtBoxRazonSocial
            // 
            this.txtBoxRazonSocial.Location = new System.Drawing.Point(135, 56);
            this.txtBoxRazonSocial.MaxLength = 25;
            this.txtBoxRazonSocial.Name = "txtBoxRazonSocial";
            this.txtBoxRazonSocial.Size = new System.Drawing.Size(200, 20);
            this.txtBoxRazonSocial.TabIndex = 7;
            // 
            // txtBoxCalle
            // 
            this.txtBoxCalle.Location = new System.Drawing.Point(135, 82);
            this.txtBoxCalle.MaxLength = 32;
            this.txtBoxCalle.Name = "txtBoxCalle";
            this.txtBoxCalle.Size = new System.Drawing.Size(200, 20);
            this.txtBoxCalle.TabIndex = 8;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(260, 387);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(14, 111);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número";
            // 
            // dgrEstacion
            // 
            this.dgrEstacion.AllowUserToAddRows = false;
            this.dgrEstacion.AllowUserToDeleteRows = false;
            this.dgrEstacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrEstacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuit,
            this.Nombre,
            this.Calle,
            this.Numero,
            this.FechaAlta});
            this.dgrEstacion.Location = new System.Drawing.Point(358, 12);
            this.dgrEstacion.Name = "dgrEstacion";
            this.dgrEstacion.ReadOnly = true;
            this.dgrEstacion.Size = new System.Drawing.Size(445, 398);
            this.dgrEstacion.TabIndex = 17;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(10, 387);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(91, 387);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(172, 387);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtBoxCuit
            // 
            this.txtBoxCuit.Location = new System.Drawing.Point(135, 30);
            this.txtBoxCuit.Mask = "99999999999";
            this.txtBoxCuit.Name = "txtBoxCuit";
            this.txtBoxCuit.Size = new System.Drawing.Size(200, 20);
            this.txtBoxCuit.TabIndex = 31;
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(136, 108);
            this.txtBoxNumero.Mask = "99999999999999";
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(200, 20);
            this.txtBoxNumero.TabIndex = 32;
            // 
            // Cuit
            // 
            this.Cuit.DataPropertyName = "CUIT";
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            this.Cuit.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "razonSocial";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "calle";
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 50;
            // 
            // FechaAlta
            // 
            this.FechaAlta.DataPropertyName = "fechaHabilitacion";
            this.FechaAlta.HeaderText = "Fecha de Alta";
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.ReadOnly = true;
            this.FechaAlta.Width = 50;
            // 
            // frm_ABMEstacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 422);
            this.Controls.Add(this.txtBoxNumero);
            this.Controls.Add(this.txtBoxCuit);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgrEstacion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtBoxCalle);
            this.Controls.Add(this.txtBoxRazonSocial);
            this.Controls.Add(this.dtFechaAta);
            this.Controls.Add(this.lblFechaHabilitacion);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblCuit);
            this.Name = "frm_ABMEstacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Estación de Servicio";
            this.Load += new System.EventHandler(this.frm_ABMEstacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrEstacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblFechaHabilitacion;
        private System.Windows.Forms.DateTimePicker dtFechaAta;
        private System.Windows.Forms.TextBox txtBoxRazonSocial;
        private System.Windows.Forms.TextBox txtBoxCalle;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.DataGridView dgrEstacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.MaskedTextBox txtBoxCuit;
        private System.Windows.Forms.MaskedTextBox txtBoxNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
    }
}