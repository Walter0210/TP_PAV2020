namespace ProyectoPAV1_Grupo7
{
    partial class frm_ConsultaOrdenCompra
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
            this.dgrOrdenCompra = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrDetallesOrden = new System.Windows.Forms.DataGridView();
            this.NumeroOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urgencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrarPedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrOrdenCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDetallesOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrOrdenCompra
            // 
            this.dgrOrdenCompra.AllowUserToAddRows = false;
            this.dgrOrdenCompra.AllowUserToDeleteRows = false;
            this.dgrOrdenCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrOrdenCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrOrdenCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Fecha,
            this.Responsable,
            this.Solicitante,
            this.PrecioTotal});
            this.dgrOrdenCompra.Location = new System.Drawing.Point(12, 39);
            this.dgrOrdenCompra.MultiSelect = false;
            this.dgrOrdenCompra.Name = "dgrOrdenCompra";
            this.dgrOrdenCompra.ReadOnly = true;
            this.dgrOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrOrdenCompra.Size = new System.Drawing.Size(760, 269);
            this.dgrOrdenCompra.TabIndex = 0;
            this.dgrOrdenCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrOrdenCompra_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "numeroOrdenCompra";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Responsable
            // 
            this.Responsable.DataPropertyName = "apenom";
            this.Responsable.HeaderText = "Responsable";
            this.Responsable.Name = "Responsable";
            this.Responsable.ReadOnly = true;
            // 
            // Solicitante
            // 
            this.Solicitante.DataPropertyName = "razonSocial";
            this.Solicitante.HeaderText = "Solicitante";
            this.Solicitante.Name = "Solicitante";
            this.Solicitante.ReadOnly = true;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.DataPropertyName = "total";
            this.PrecioTotal.HeaderText = "Precio Total";
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.ReadOnly = true;
            // 
            // dgrDetallesOrden
            // 
            this.dgrDetallesOrden.AllowUserToAddRows = false;
            this.dgrDetallesOrden.AllowUserToDeleteRows = false;
            this.dgrDetallesOrden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrDetallesOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrDetallesOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDetallesOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroOrden,
            this.Producto,
            this.Cantidad,
            this.UnidadMedida,
            this.Precio,
            this.Urgencia});
            this.dgrDetallesOrden.Location = new System.Drawing.Point(15, 329);
            this.dgrDetallesOrden.MultiSelect = false;
            this.dgrDetallesOrden.Name = "dgrDetallesOrden";
            this.dgrDetallesOrden.ReadOnly = true;
            this.dgrDetallesOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrDetallesOrden.Size = new System.Drawing.Size(757, 159);
            this.dgrDetallesOrden.TabIndex = 1;
            this.dgrDetallesOrden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDetallesOrden_CellContentClick);
            // 
            // NumeroOrden
            // 
            this.NumeroOrden.DataPropertyName = "numOrdenCompra";
            this.NumeroOrden.HeaderText = "Numero de OC";
            this.NumeroOrden.Name = "NumeroOrden";
            this.NumeroOrden.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "descripcion";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.DataPropertyName = "nombre";
            this.UnidadMedida.HeaderText = "Unidad de Medida";
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "precitotal";
            this.Precio.HeaderText = "Precio por cantidad pedida";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Urgencia
            // 
            this.Urgencia.DataPropertyName = "nombre1";
            this.Urgencia.HeaderText = "Nvel de urgencia";
            this.Urgencia.Name = "Urgencia";
            this.Urgencia.ReadOnly = true;
            // 
            // btnRegistrarPedido
            // 
            this.btnRegistrarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarPedido.Location = new System.Drawing.Point(644, 507);
            this.btnRegistrarPedido.Name = "btnRegistrarPedido";
            this.btnRegistrarPedido.Size = new System.Drawing.Size(128, 46);
            this.btnRegistrarPedido.TabIndex = 4;
            this.btnRegistrarPedido.Text = "registrar pedido";
            this.btnRegistrarPedido.UseVisualStyleBackColor = true;
            this.btnRegistrarPedido.Click += new System.EventHandler(this.btnRegistrarPedido_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detalle de orden";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odenes de compra";
            // 
            // frm_ConsultaOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 576);
            this.Controls.Add(this.btnRegistrarPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrDetallesOrden);
            this.Controls.Add(this.dgrOrdenCompra);
            this.Name = "frm_ConsultaOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frm_ConsultaOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrOrdenCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDetallesOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrOrdenCompra;
        private System.Windows.Forms.DataGridView dgrDetallesOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urgencia;
        private System.Windows.Forms.Button btnRegistrarPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}