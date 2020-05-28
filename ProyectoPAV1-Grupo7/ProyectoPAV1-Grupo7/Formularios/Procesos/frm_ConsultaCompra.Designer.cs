namespace ProyectoPAV1_Grupo7.Formularios.Procesos
{
    partial class frm_ConsultaCompra
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
            this.dgrTicket = new System.Windows.Forms.DataGridView();
            this.NumeroTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroSurtidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxLabelTicket = new System.Windows.Forms.Label();
            this.dgrTicketProducto = new System.Windows.Forms.DataGridView();
            this.NumeroTicketProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxLabelTicketProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTicketProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrTicket
            // 
            this.dgrTicket.AllowUserToAddRows = false;
            this.dgrTicket.AllowUserToDeleteRows = false;
            this.dgrTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroTicket,
            this.Fecha,
            this.Cuit,
            this.NumeroSurtidor,
            this.Cantidad,
            this.UnidadMedida,
            this.Observacion});
            this.dgrTicket.Location = new System.Drawing.Point(9, 33);
            this.dgrTicket.Margin = new System.Windows.Forms.Padding(2);
            this.dgrTicket.MultiSelect = false;
            this.dgrTicket.Name = "dgrTicket";
            this.dgrTicket.ReadOnly = true;
            this.dgrTicket.RowHeadersWidth = 51;
            this.dgrTicket.RowTemplate.Height = 24;
            this.dgrTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrTicket.Size = new System.Drawing.Size(699, 301);
            this.dgrTicket.TabIndex = 0;
            this.dgrTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrTicket_CellClick);
            // 
            // NumeroTicket
            // 
            this.NumeroTicket.DataPropertyName = "numTicket";
            this.NumeroTicket.HeaderText = "NumeroTicket";
            this.NumeroTicket.MinimumWidth = 6;
            this.NumeroTicket.Name = "NumeroTicket";
            this.NumeroTicket.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Cuit
            // 
            this.Cuit.DataPropertyName = "razonSocial";
            this.Cuit.HeaderText = "Estacion Solicitante";
            this.Cuit.MinimumWidth = 6;
            this.Cuit.Name = "Cuit";
            this.Cuit.ReadOnly = true;
            // 
            // NumeroSurtidor
            // 
            this.NumeroSurtidor.DataPropertyName = "numeroSurtidor";
            this.NumeroSurtidor.HeaderText = "NumeroSurtidor";
            this.NumeroSurtidor.MinimumWidth = 6;
            this.NumeroSurtidor.Name = "NumeroSurtidor";
            this.NumeroSurtidor.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.DataPropertyName = "nombre";
            this.UnidadMedida.HeaderText = "Unidad de Medida";
            this.UnidadMedida.MinimumWidth = 6;
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.ReadOnly = true;
            // 
            // Observacion
            // 
            this.Observacion.DataPropertyName = "observacion";
            this.Observacion.HeaderText = "Observaciones";
            this.Observacion.MinimumWidth = 6;
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            // 
            // txtBoxLabelTicket
            // 
            this.txtBoxLabelTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxLabelTicket.AutoSize = true;
            this.txtBoxLabelTicket.Location = new System.Drawing.Point(9, 17);
            this.txtBoxLabelTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBoxLabelTicket.Name = "txtBoxLabelTicket";
            this.txtBoxLabelTicket.Size = new System.Drawing.Size(84, 13);
            this.txtBoxLabelTicket.TabIndex = 1;
            this.txtBoxLabelTicket.Text = "Tickets Emitidos";
            // 
            // dgrTicketProducto
            // 
            this.dgrTicketProducto.AllowUserToAddRows = false;
            this.dgrTicketProducto.AllowUserToDeleteRows = false;
            this.dgrTicketProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrTicketProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrTicketProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrTicketProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroTicketProducto,
            this.ID_Producto,
            this.CantidadProducto,
            this.Precio});
            this.dgrTicketProducto.Location = new System.Drawing.Point(9, 386);
            this.dgrTicketProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dgrTicketProducto.MultiSelect = false;
            this.dgrTicketProducto.Name = "dgrTicketProducto";
            this.dgrTicketProducto.ReadOnly = true;
            this.dgrTicketProducto.RowHeadersWidth = 51;
            this.dgrTicketProducto.RowTemplate.Height = 24;
            this.dgrTicketProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrTicketProducto.Size = new System.Drawing.Size(571, 200);
            this.dgrTicketProducto.TabIndex = 2;
            // 
            // NumeroTicketProducto
            // 
            this.NumeroTicketProducto.DataPropertyName = "numeroTicket";
            this.NumeroTicketProducto.HeaderText = "NumeroTicketProducto";
            this.NumeroTicketProducto.MinimumWidth = 6;
            this.NumeroTicketProducto.Name = "NumeroTicketProducto";
            this.NumeroTicketProducto.ReadOnly = true;
            // 
            // ID_Producto
            // 
            this.ID_Producto.DataPropertyName = "descripcion";
            this.ID_Producto.HeaderText = "Producto";
            this.ID_Producto.MinimumWidth = 6;
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.ReadOnly = true;
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.DataPropertyName = "cantidad";
            this.CantidadProducto.HeaderText = "Cantidad Solicitada";
            this.CantidadProducto.MinimumWidth = 6;
            this.CantidadProducto.Name = "CantidadProducto";
            this.CantidadProducto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // txtBoxLabelTicketProd
            // 
            this.txtBoxLabelTicketProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxLabelTicketProd.AutoSize = true;
            this.txtBoxLabelTicketProd.Location = new System.Drawing.Point(6, 371);
            this.txtBoxLabelTicketProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBoxLabelTicketProd.Name = "txtBoxLabelTicketProd";
            this.txtBoxLabelTicketProd.Size = new System.Drawing.Size(100, 13);
            this.txtBoxLabelTicketProd.TabIndex = 3;
            this.txtBoxLabelTicketProd.Text = "Lista de productos: ";
            // 
            // frm_ConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 594);
            this.Controls.Add(this.txtBoxLabelTicketProd);
            this.Controls.Add(this.dgrTicketProducto);
            this.Controls.Add(this.txtBoxLabelTicket);
            this.Controls.Add(this.dgrTicket);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_ConsultaCompra";
            this.Text = "ConsultaCompra";
            this.Load += new System.EventHandler(this.frm_ConsultaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTicketProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrTicket;
        private System.Windows.Forms.Label txtBoxLabelTicket;
        private System.Windows.Forms.DataGridView dgrTicketProducto;
        private System.Windows.Forms.Label txtBoxLabelTicketProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTicketProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSurtidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
    }
}