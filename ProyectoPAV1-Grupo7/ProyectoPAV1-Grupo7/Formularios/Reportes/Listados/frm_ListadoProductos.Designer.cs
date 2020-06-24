﻿namespace ProyectoPAV1_Grupo7.Formularios.Reportes.Listados
{
    partial class frm_ListadoProductos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Productos = new System.Windows.Forms.TabPage();
            this.rv_stockProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.cmb_comparacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_limpiarTab3 = new System.Windows.Forms.Button();
            this.btn_filtrarTab3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Productos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Productos);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(692, 541);
            this.tabControl1.TabIndex = 0;
            // 
            // Productos
            // 
            this.Productos.Controls.Add(this.rv_stockProductos);
            this.Productos.Controls.Add(this.groupBox3);
            this.Productos.Location = new System.Drawing.Point(4, 22);
            this.Productos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Productos.Name = "Productos";
            this.Productos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Productos.Size = new System.Drawing.Size(684, 515);
            this.Productos.TabIndex = 0;
            this.Productos.Text = "Productos General";
            this.Productos.UseVisualStyleBackColor = true;
            // 
            // rv_stockProductos
            // 
            this.rv_stockProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_stockProductos.AutoScroll = true;
            this.rv_stockProductos.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Listados.Listado_StockProductos.rdlc";
            this.rv_stockProductos.Location = new System.Drawing.Point(6, 145);
            this.rv_stockProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rv_stockProductos.Name = "rv_stockProductos";
            this.rv_stockProductos.ServerReport.BearerToken = null;
            this.rv_stockProductos.Size = new System.Drawing.Size(586, 365);
            this.rv_stockProductos.TabIndex = 9;
            this.rv_stockProductos.Load += new System.EventHandler(this.rv_stockProductos_Load_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_stock);
            this.groupBox3.Controls.Add(this.cmb_comparacion);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btn_limpiarTab3);
            this.groupBox3.Controls.Add(this.btn_filtrarTab3);
            this.groupBox3.Location = new System.Drawing.Point(5, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(586, 134);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(170, 57);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(120, 20);
            this.txt_stock.TabIndex = 16;
            // 
            // cmb_comparacion
            // 
            this.cmb_comparacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_comparacion.FormattingEnabled = true;
            this.cmb_comparacion.Location = new System.Drawing.Point(170, 19);
            this.cmb_comparacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_comparacion.Name = "cmb_comparacion";
            this.cmb_comparacion.Size = new System.Drawing.Size(120, 21);
            this.cmb_comparacion.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ejemplo: si quiere listar productos con stock mayor a 100 unidades, debe escribir" +
    ": Comparacion \'>\' y en Valor \'100\'";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Location = new System.Drawing.Point(52, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Comparacion: ( =, < , > )";
            // 
            // btn_limpiarTab3
            // 
            this.btn_limpiarTab3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_limpiarTab3.Location = new System.Drawing.Point(452, 53);
            this.btn_limpiarTab3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_limpiarTab3.Name = "btn_limpiarTab3";
            this.btn_limpiarTab3.Size = new System.Drawing.Size(71, 20);
            this.btn_limpiarTab3.TabIndex = 9;
            this.btn_limpiarTab3.Text = "Limpiar";
            this.btn_limpiarTab3.UseVisualStyleBackColor = true;
            this.btn_limpiarTab3.Click += new System.EventHandler(this.btn_limpiarTab3_Click);
            // 
            // btn_filtrarTab3
            // 
            this.btn_filtrarTab3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_filtrarTab3.Location = new System.Drawing.Point(452, 19);
            this.btn_filtrarTab3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_filtrarTab3.Name = "btn_filtrarTab3";
            this.btn_filtrarTab3.Size = new System.Drawing.Size(71, 20);
            this.btn_filtrarTab3.TabIndex = 1;
            this.btn_filtrarTab3.Text = "Filtrar";
            this.btn_filtrarTab3.UseVisualStyleBackColor = true;
            this.btn_filtrarTab3.Click += new System.EventHandler(this.btn_filtrarTab3_Click);
            // 
            // frm_ListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 542);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_ListadoProductos";
            this.Text = "frm_ListadoProductos";
            this.Load += new System.EventHandler(this.frm_ListadoProductos_Load);
            this.tabControl1.ResumeLayout(false);
            this.Productos.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Productos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_limpiarTab3;
        private System.Windows.Forms.Button btn_filtrarTab3;
        private System.Windows.Forms.Label label12;
        private Microsoft.Reporting.WinForms.ReportViewer rv_stockProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_comparacion;
        private System.Windows.Forms.TextBox txt_stock;
    }
}