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
            this.txtBoxCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtBoxStockActual = new System.Windows.Forms.TextBox();
            this.dateUltiAct = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaActualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio de venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ultima Actualizacion";
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(193, 96);
            this.txtBoxDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(265, 22);
            this.txtBoxDescripcion.TabIndex = 6;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(360, 401);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(144, 401);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(36, 401);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dgrProducto
            // 
            this.dgrProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.StockActual,
            this.PrecioCompra,
            this.PrecioVenta,
            this.FechaActualizacion});
            this.dgrProducto.Location = new System.Drawing.Point(496, 15);
            this.dgrProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgrProducto.Name = "dgrProducto";
            this.dgrProducto.RowHeadersWidth = 51;
            this.dgrProducto.Size = new System.Drawing.Size(808, 415);
            this.dgrProducto.TabIndex = 22;
            // 
            // txtBoxCodigoProducto
            // 
            this.txtBoxCodigoProducto.Enabled = false;
            this.txtBoxCodigoProducto.Location = new System.Drawing.Point(193, 64);
            this.txtBoxCodigoProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCodigoProducto.Name = "txtBoxCodigoProducto";
            this.txtBoxCodigoProducto.Size = new System.Drawing.Size(265, 22);
            this.txtBoxCodigoProducto.TabIndex = 23;
            // 
            // txtBoxStockActual
            // 
            this.txtBoxStockActual.Location = new System.Drawing.Point(193, 128);
            this.txtBoxStockActual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStockActual.Name = "txtBoxStockActual";
            this.txtBoxStockActual.Size = new System.Drawing.Size(265, 22);
            this.txtBoxStockActual.TabIndex = 24;
            // 
            // dateUltiAct
            // 
            this.dateUltiAct.Location = new System.Drawing.Point(193, 224);
            this.dateUltiAct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateUltiAct.Name = "dateUltiAct";
            this.dateUltiAct.Size = new System.Drawing.Size(265, 22);
            this.dateUltiAct.TabIndex = 25;
            // 
            // txtBoxPrecioCompra
            // 
            this.txtBoxPrecioCompra.Location = new System.Drawing.Point(193, 160);
            this.txtBoxPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPrecioCompra.Name = "txtBoxPrecioCompra";
            this.txtBoxPrecioCompra.Size = new System.Drawing.Size(265, 22);
            this.txtBoxPrecioCompra.TabIndex = 26;
            // 
            // txtBoxPrecioVenta
            // 
            this.txtBoxPrecioVenta.Location = new System.Drawing.Point(193, 192);
            this.txtBoxPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPrecioVenta.Name = "txtBoxPrecioVenta";
            this.txtBoxPrecioVenta.Size = new System.Drawing.Size(265, 22);
            this.txtBoxPrecioVenta.TabIndex = 27;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(252, 401);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "idProducto";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // StockActual
            // 
            this.StockActual.DataPropertyName = "stockActual";
            this.StockActual.HeaderText = "StockActual";
            this.StockActual.MinimumWidth = 6;
            this.StockActual.Name = "StockActual";
            this.StockActual.Width = 125;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.DataPropertyName = "precioCompra";
            this.PrecioCompra.HeaderText = "PrecioCompra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.Width = 125;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.DataPropertyName = "precioVenta";
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Width = 125;
            // 
            // FechaActualizacion
            // 
            this.FechaActualizacion.DataPropertyName = "fechaUltimaActualizacion";
            this.FechaActualizacion.HeaderText = "FechaActualizacion";
            this.FechaActualizacion.MinimumWidth = 6;
            this.FechaActualizacion.Name = "FechaActualizacion";
            this.FechaActualizacion.Width = 125;
            // 
            // frm_ABMProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 444);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtBoxPrecioVenta);
            this.Controls.Add(this.txtBoxPrecioCompra);
            this.Controls.Add(this.dateUltiAct);
            this.Controls.Add(this.txtBoxStockActual);
            this.Controls.Add(this.txtBoxCodigoProducto);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_ABMProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ABMProducto";
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
        private System.Windows.Forms.TextBox txtBoxCodigoProducto;
        private System.Windows.Forms.TextBox txtBoxStockActual;
        private System.Windows.Forms.DateTimePicker dateUltiAct;
        private System.Windows.Forms.TextBox txtBoxPrecioCompra;
        private System.Windows.Forms.TextBox txtBoxPrecioVenta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaActualizacion;
    }
}