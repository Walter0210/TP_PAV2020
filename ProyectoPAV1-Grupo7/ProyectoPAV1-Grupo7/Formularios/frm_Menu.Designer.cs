namespace ProyectoPAV1_Grupo7.Formularios
{
    partial class frm_Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.subPanel_empleado = new System.Windows.Forms.Panel();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_empleado = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_producto = new System.Windows.Forms.Button();
            this.subPanel_producto = new System.Windows.Forms.Panel();
            this.btn_nuevo_prod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMenuLateral.SuspendLayout();
            this.subPanel_empleado.SuspendLayout();
            this.subPanel_producto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(588, 842);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 168);
            this.panel1.TabIndex = 0;
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenuLateral.Controls.Add(this.subPanel_producto);
            this.panelMenuLateral.Controls.Add(this.btn_producto);
            this.panelMenuLateral.Controls.Add(this.subPanel_empleado);
            this.panelMenuLateral.Controls.Add(this.btn_empleado);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(250, 559);
            this.panelMenuLateral.TabIndex = 1;
            // 
            // subPanel_empleado
            // 
            this.subPanel_empleado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.subPanel_empleado.Controls.Add(this.btn_eliminar);
            this.subPanel_empleado.Controls.Add(this.btn_editar);
            this.subPanel_empleado.Controls.Add(this.btn_nuevo);
            this.subPanel_empleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanel_empleado.Location = new System.Drawing.Point(0, 145);
            this.subPanel_empleado.Name = "subPanel_empleado";
            this.subPanel_empleado.Size = new System.Drawing.Size(250, 121);
            this.subPanel_empleado.TabIndex = 2;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Location = new System.Drawing.Point(0, 80);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_eliminar.Size = new System.Drawing.Size(250, 40);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Location = new System.Drawing.Point(0, 40);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_editar.Size = new System.Drawing.Size(250, 40);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Modificar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Location = new System.Drawing.Point(0, 0);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_nuevo.Size = new System.Drawing.Size(250, 40);
            this.btn_nuevo.TabIndex = 2;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_empleado
            // 
            this.btn_empleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_empleado.FlatAppearance.BorderSize = 0;
            this.btn_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleado.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empleado.Location = new System.Drawing.Point(0, 100);
            this.btn_empleado.Name = "btn_empleado";
            this.btn_empleado.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_empleado.Size = new System.Drawing.Size(250, 45);
            this.btn_empleado.TabIndex = 2;
            this.btn_empleado.Text = "Empleado";
            this.btn_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empleado.UseVisualStyleBackColor = true;
            this.btn_empleado.Click += new System.EventHandler(this.btn_empleado_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 2;
            // 
            // btn_producto
            // 
            this.btn_producto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_producto.FlatAppearance.BorderSize = 0;
            this.btn_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_producto.Location = new System.Drawing.Point(0, 266);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_producto.Size = new System.Drawing.Size(250, 45);
            this.btn_producto.TabIndex = 2;
            this.btn_producto.Text = "Producto";
            this.btn_producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_producto.UseVisualStyleBackColor = true;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // subPanel_producto
            // 
            this.subPanel_producto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.subPanel_producto.Controls.Add(this.button2);
            this.subPanel_producto.Controls.Add(this.button1);
            this.subPanel_producto.Controls.Add(this.btn_nuevo_prod);
            this.subPanel_producto.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanel_producto.Location = new System.Drawing.Point(0, 311);
            this.subPanel_producto.Name = "subPanel_producto";
            this.subPanel_producto.Size = new System.Drawing.Size(250, 126);
            this.subPanel_producto.TabIndex = 3;
            // 
            // btn_nuevo_prod
            // 
            this.btn_nuevo_prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nuevo_prod.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_prod.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_nuevo_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_prod.Location = new System.Drawing.Point(0, 0);
            this.btn_nuevo_prod.Name = "btn_nuevo_prod";
            this.btn_nuevo_prod.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_nuevo_prod.Size = new System.Drawing.Size(250, 40);
            this.btn_nuevo_prod.TabIndex = 4;
            this.btn_nuevo_prod.Text = "Nuevo";
            this.btn_nuevo_prod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo_prod.UseVisualStyleBackColor = true;
            this.btn_nuevo_prod.Click += new System.EventHandler(this.btn_nuevo_prod_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 40);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Modificar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 80);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Eliminar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(647, 559);
            this.panelChildForm.TabIndex = 2;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 559);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenuLateral);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frm_Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.panelMenuLateral.ResumeLayout(false);
            this.subPanel_empleado.ResumeLayout(false);
            this.subPanel_producto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel subPanel_empleado;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_empleado;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel subPanel_producto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_nuevo_prod;
        private System.Windows.Forms.Button btn_producto;
        private System.Windows.Forms.Panel panelChildForm;
    }
}