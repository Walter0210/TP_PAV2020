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
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbObservaciones = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmbEstacion
            // 
            this.cmbEstacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstacion.FormattingEnabled = true;
            this.cmbEstacion.Location = new System.Drawing.Point(237, 105);
            this.cmbEstacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstacion.Name = "cmbEstacion";
            this.cmbEstacion.Size = new System.Drawing.Size(285, 24);
            this.cmbEstacion.TabIndex = 0;
            // 
            // cmbSurtidor
            // 
            this.cmbSurtidor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSurtidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSurtidor.FormattingEnabled = true;
            this.cmbSurtidor.Location = new System.Drawing.Point(237, 142);
            this.cmbSurtidor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSurtidor.Name = "cmbSurtidor";
            this.cmbSurtidor.Size = new System.Drawing.Size(285, 24);
            this.cmbSurtidor.TabIndex = 1;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCantidad.Location = new System.Drawing.Point(237, 181);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(119, 22);
            this.tbCantidad.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(27, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(305, 29);
            this.lblTitulo.TabIndex = 62;
            this.lblTitulo.Text = "VENTA DE PRODUCTO";
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(368, 181);
            this.cmbUnidadMedida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(153, 24);
            this.cmbUnidadMedida.TabIndex = 64;
            // 
            // lblResponsable
            // 
            this.lblResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(57, 105);
            this.lblResponsable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(66, 17);
            this.lblResponsable.TabIndex = 65;
            this.lblResponsable.Text = "Estacion:";
            this.lblResponsable.Click += new System.EventHandler(this.lblResponsable_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "Surtidor:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(57, 186);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(124, 17);
            this.lblCantidad.TabIndex = 67;
            this.lblCantidad.Text = "Cantidad Vendida:";
            this.lblCantidad.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(55, 229);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(107, 17);
            this.lblObservaciones.TabIndex = 76;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(200, 553);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 28);
            this.button1.TabIndex = 77;
            this.button1.Text = "Registrar venta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbObservaciones.Location = new System.Drawing.Point(61, 262);
            this.tbObservaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(461, 248);
            this.tbObservaciones.TabIndex = 78;
            this.tbObservaciones.Text = "";
            // 
            // frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 596);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.cmbUnidadMedida);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.cmbSurtidor);
            this.Controls.Add(this.cmbEstacion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_Compra";
            this.Text = "frm_Compra";
            this.Load += new System.EventHandler(this.frm_Compra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstacion;
        private System.Windows.Forms.ComboBox cmbSurtidor;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox tbObservaciones;
    }
}