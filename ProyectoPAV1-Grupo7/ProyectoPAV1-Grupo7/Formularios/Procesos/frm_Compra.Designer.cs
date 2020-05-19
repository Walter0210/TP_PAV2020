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
            this.cmbEstacion = new System.Windows.Forms.ComboBox();
            this.cmbSurtidor = new System.Windows.Forms.ComboBox();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbEstacion
            // 
            this.cmbEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstacion.FormattingEnabled = true;
            this.cmbEstacion.Location = new System.Drawing.Point(235, 140);
            this.cmbEstacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstacion.Name = "cmbEstacion";
            this.cmbEstacion.Size = new System.Drawing.Size(213, 24);
            this.cmbEstacion.TabIndex = 0;
            // 
            // cmbSurtidor
            // 
            this.cmbSurtidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSurtidor.FormattingEnabled = true;
            this.cmbSurtidor.Location = new System.Drawing.Point(235, 177);
            this.cmbSurtidor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSurtidor.Name = "cmbSurtidor";
            this.cmbSurtidor.Size = new System.Drawing.Size(213, 24);
            this.cmbSurtidor.TabIndex = 1;
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Location = new System.Drawing.Point(235, 218);
            this.txtBoxCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(122, 22);
            this.txtBoxCantidad.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(101, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(305, 29);
            this.lblTitulo.TabIndex = 62;
            this.lblTitulo.Text = "VENTA DE PRODUCTO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrar.Location = new System.Drawing.Point(257, 456);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 63;
            this.btnCerrar.Text = "Volver";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(365, 218);
            this.cmbUnidadMedida.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(83, 24);
            this.cmbUnidadMedida.TabIndex = 64;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(61, 147);
            this.lblResponsable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(66, 17);
            this.lblResponsable.TabIndex = 65;
            this.lblResponsable.Text = "Estacion:";
            this.lblResponsable.Click += new System.EventHandler(this.lblResponsable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "Surtidor:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(61, 221);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(124, 17);
            this.lblCantidad.TabIndex = 67;
            this.lblCantidad.Text = "Cantidad Vendida:";
            this.lblCantidad.Click += new System.EventHandler(this.label2_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(232, 280);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(216, 117);
            this.listView1.TabIndex = 75;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(61, 280);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(107, 17);
            this.lblObservaciones.TabIndex = 76;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 619);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.cmbUnidadMedida);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.cmbSurtidor);
            this.Controls.Add(this.cmbEstacion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Compra";
            this.Text = "frm_Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstacion;
        private System.Windows.Forms.ComboBox cmbSurtidor;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblObservaciones;
    }
}