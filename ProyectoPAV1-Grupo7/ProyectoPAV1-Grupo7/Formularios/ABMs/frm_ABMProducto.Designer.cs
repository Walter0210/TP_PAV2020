namespace ProyectoPAV1_Grupo7.Formularios.ABMs
{
    partial class frm_ABMProducto
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgrProducto = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimaActualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.txtBoxStockActual = new System.Windows.Forms.TextBox();
            this.txtBoxPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtFechaUltimaActualizacion = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio de venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ultima Actualizacion";
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(186, 78);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(159, 20);
            this.txtBoxDescripcion.TabIndex = 6;
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
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(105, 326);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 21;
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
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgrProducto
            // 
            this.dgrProducto.AllowUserToAddRows = false;
            this.dgrProducto.AllowUserToDeleteRows = false;
            this.dgrProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrProducto.ColumnHeadersHeight = 34;
            this.dgrProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgrProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.StockActual,
            this.PrecioCompra,
            this.PrecioVenta,
            this.UltimaActualizacion});
            this.dgrProducto.Location = new System.Drawing.Point(372, 12);
            this.dgrProducto.Name = "dgrProducto";
            this.dgrProducto.ReadOnly = true;
            this.dgrProducto.RowHeadersWidth = 51;
            this.dgrProducto.Size = new System.Drawing.Size(500, 337);
            this.dgrProducto.TabIndex = 22;
            this.dgrProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrProducto_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "idProducto";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // StockActual
            // 
            this.StockActual.DataPropertyName = "stockActual";
            this.StockActual.HeaderText = "StockActual";
            this.StockActual.MinimumWidth = 6;
            this.StockActual.Name = "StockActual";
            this.StockActual.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.DataPropertyName = "precioCompra";
            this.PrecioCompra.HeaderText = "PrecioCompra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.DataPropertyName = "precioVenta";
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // UltimaActualizacion
            // 
            this.UltimaActualizacion.DataPropertyName = "fechaUltimaActualizacion";
            this.UltimaActualizacion.HeaderText = "UltimaActualizacion";
            this.UltimaActualizacion.MinimumWidth = 6;
            this.UltimaActualizacion.Name = "UltimaActualizacion";
            this.UltimaActualizacion.ReadOnly = true;
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Enabled = false;
            this.txtBoxCodigo.Location = new System.Drawing.Point(186, 52);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(159, 20);
            this.txtBoxCodigo.TabIndex = 23;
            // 
            // txtBoxStockActual
            // 
            this.txtBoxStockActual.Location = new System.Drawing.Point(186, 104);
            this.txtBoxStockActual.Name = "txtBoxStockActual";
            this.txtBoxStockActual.Size = new System.Drawing.Size(159, 20);
            this.txtBoxStockActual.TabIndex = 24;
            // 
            // txtBoxPrecioCompra
            // 
            this.txtBoxPrecioCompra.Location = new System.Drawing.Point(186, 130);
            this.txtBoxPrecioCompra.Name = "txtBoxPrecioCompra";
            this.txtBoxPrecioCompra.Size = new System.Drawing.Size(159, 20);
            this.txtBoxPrecioCompra.TabIndex = 26;
            // 
            // txtBoxPrecioVenta
            // 
            this.txtBoxPrecioVenta.Location = new System.Drawing.Point(186, 156);
            this.txtBoxPrecioVenta.Name = "txtBoxPrecioVenta";
            this.txtBoxPrecioVenta.Size = new System.Drawing.Size(159, 20);
            this.txtBoxPrecioVenta.TabIndex = 27;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Location = new System.Drawing.Point(186, 326);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtFechaUltimaActualizacion
            // 
            this.txtFechaUltimaActualizacion.Location = new System.Drawing.Point(186, 181);
            this.txtFechaUltimaActualizacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFechaUltimaActualizacion.Mask = "00/00/0000";
            this.txtFechaUltimaActualizacion.Name = "txtFechaUltimaActualizacion";
            this.txtFechaUltimaActualizacion.Size = new System.Drawing.Size(159, 20);
            this.txtFechaUltimaActualizacion.TabIndex = 29;
            this.txtFechaUltimaActualizacion.ValidatingType = typeof(System.DateTime);
            // 
            // frm_ABMProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.txtFechaUltimaActualizacion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtBoxPrecioVenta);
            this.Controls.Add(this.txtBoxPrecioCompra);
            this.Controls.Add(this.txtBoxStockActual);
            this.Controls.Add(this.txtBoxCodigo);
            this.Controls.Add(this.dgrProducto);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_ABMProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ABMProducto";
            this.Load += new System.EventHandler(this.frm_ABMEstacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgrProducto;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.TextBox txtBoxStockActual;
        private System.Windows.Forms.TextBox txtBoxPrecioCompra;
        private System.Windows.Forms.TextBox txtBoxPrecioVenta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.MaskedTextBox txtFechaUltimaActualizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimaActualizacion;
    }
}