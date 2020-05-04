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
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblFechaHabilitacion = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBoxCuit = new System.Windows.Forms.TextBox();
            this.txtBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.txtBoxCalle = new System.Windows.Forms.TextBox();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(12, 53);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(35, 13);
            this.lblCuit.TabIndex = 0;
            this.lblCuit.Text = "CUIT:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(12, 79);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "Razon Social:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(12, 105);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 2;
            this.lblCalle.Text = "Calle";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 131);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número";
            // 
            // lblFechaHabilitacion
            // 
            this.lblFechaHabilitacion.AutoSize = true;
            this.lblFechaHabilitacion.Location = new System.Drawing.Point(12, 160);
            this.lblFechaHabilitacion.Name = "lblFechaHabilitacion";
            this.lblFechaHabilitacion.Size = new System.Drawing.Size(73, 13);
            this.lblFechaHabilitacion.TabIndex = 4;
            this.lblFechaHabilitacion.Text = "Fecha de Alta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txtBoxCuit
            // 
            this.txtBoxCuit.Location = new System.Drawing.Point(110, 50);
            this.txtBoxCuit.MaxLength = 11;
            this.txtBoxCuit.Name = "txtBoxCuit";
            this.txtBoxCuit.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCuit.TabIndex = 6;
            // 
            // txtBoxRazonSocial
            // 
            this.txtBoxRazonSocial.Location = new System.Drawing.Point(110, 76);
            this.txtBoxRazonSocial.MaxLength = 25;
            this.txtBoxRazonSocial.Name = "txtBoxRazonSocial";
            this.txtBoxRazonSocial.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRazonSocial.TabIndex = 7;
            // 
            // txtBoxCalle
            // 
            this.txtBoxCalle.Location = new System.Drawing.Point(110, 102);
            this.txtBoxCalle.MaxLength = 32;
            this.txtBoxCalle.Name = "txtBoxCalle";
            this.txtBoxCalle.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCalle.TabIndex = 8;
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(110, 128);
            this.txtBoxNumero.MaxLength = 5;
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(200, 20);
            this.txtBoxNumero.TabIndex = 9;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(394, 285);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frm_ABMEstacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtBoxNumero);
            this.Controls.Add(this.txtBoxCalle);
            this.Controls.Add(this.txtBoxRazonSocial);
            this.Controls.Add(this.txtBoxCuit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFechaHabilitacion);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblCuit);
            this.Name = "frm_ABMEstacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Estación de Servicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblFechaHabilitacion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBoxCuit;
        private System.Windows.Forms.TextBox txtBoxRazonSocial;
        private System.Windows.Forms.TextBox txtBoxCalle;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.Button btnCerrar;
    }
}