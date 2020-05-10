using System;

namespace ProyectoPAV1_Grupo7.Formularios.ABMs
{
    partial class frm_ABMSurtidor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCuilEstacion = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbTipoCombustible = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgrSurtidor = new System.Windows.Forms.DataGridView();
            this.nroSurtidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoCombustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxNroSurtidor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSurtidor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Surtidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estacion de Servicio: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Combustible";
            // 
            // cmbCuilEstacion
            // 
            this.cmbCuilEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuilEstacion.FormattingEnabled = true;
            this.cmbCuilEstacion.Location = new System.Drawing.Point(186, 78);
            this.cmbCuilEstacion.Name = "cmbCuilEstacion";
            this.cmbCuilEstacion.Size = new System.Drawing.Size(159, 21);
            this.cmbCuilEstacion.TabIndex = 4;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(186, 105);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(159, 21);
            this.cmbEstado.TabIndex = 5;
            // 
            // cmbTipoCombustible
            // 
            this.cmbTipoCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCombustible.FormattingEnabled = true;
            this.cmbTipoCombustible.Location = new System.Drawing.Point(186, 132);
            this.cmbTipoCombustible.Name = "cmbTipoCombustible";
            this.cmbTipoCombustible.Size = new System.Drawing.Size(159, 21);
            this.cmbTipoCombustible.TabIndex = 6;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrar.Location = new System.Drawing.Point(270, 326);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Location = new System.Drawing.Point(186, 326);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(105, 326);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.Location = new System.Drawing.Point(24, 326);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgrSurtidor
            // 
            this.dgrSurtidor.AllowUserToAddRows = false;
            this.dgrSurtidor.AllowUserToDeleteRows = false;
            this.dgrSurtidor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrSurtidor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrSurtidor.ColumnHeadersHeight = 34;
            this.dgrSurtidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgrSurtidor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroSurtidor,
            this.cuit,
            this.idEstado,
            this.idTipoCombustible});
            this.dgrSurtidor.Location = new System.Drawing.Point(372, 12);
            this.dgrSurtidor.MultiSelect = false;
            this.dgrSurtidor.Name = "dgrSurtidor";
            this.dgrSurtidor.ReadOnly = true;
            this.dgrSurtidor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrSurtidor.Size = new System.Drawing.Size(500, 337);
            this.dgrSurtidor.TabIndex = 33;
            this.dgrSurtidor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrSurtidor_CellClick);
            // 
            // nroSurtidor
            // 
            this.nroSurtidor.DataPropertyName = "numeroSurtidor";
            this.nroSurtidor.HeaderText = "Nro Surtidor";
            this.nroSurtidor.Name = "nroSurtidor";
            this.nroSurtidor.ReadOnly = true;
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "razonSocial";
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // idEstado
            // 
            this.idEstado.DataPropertyName = "nombre";
            this.idEstado.HeaderText = "Estado";
            this.idEstado.Name = "idEstado";
            this.idEstado.ReadOnly = true;
            // 
            // idTipoCombustible
            // 
            this.idTipoCombustible.DataPropertyName = "nombre1";
            this.idTipoCombustible.HeaderText = "Tipo de Combustible";
            this.idTipoCombustible.Name = "idTipoCombustible";
            this.idTipoCombustible.ReadOnly = true;
            // 
            // txtBoxNroSurtidor
            // 
            this.txtBoxNroSurtidor.Enabled = false;
            this.txtBoxNroSurtidor.Location = new System.Drawing.Point(186, 52);
            this.txtBoxNroSurtidor.Name = "txtBoxNroSurtidor";
            this.txtBoxNroSurtidor.Size = new System.Drawing.Size(159, 20);
            this.txtBoxNroSurtidor.TabIndex = 34;
            // 
            // frm_ABMSurtidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.txtBoxNroSurtidor);
            this.Controls.Add(this.dgrSurtidor);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cmbTipoCombustible);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbCuilEstacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_ABMSurtidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ABMSurtidor";
            this.Load += new System.EventHandler(this.frm_ABMSurtidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrSurtidor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCuilEstacion;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbTipoCombustible;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgrSurtidor;
        private System.Windows.Forms.TextBox txtBoxNroSurtidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroSurtidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoCombustible;
    }
}