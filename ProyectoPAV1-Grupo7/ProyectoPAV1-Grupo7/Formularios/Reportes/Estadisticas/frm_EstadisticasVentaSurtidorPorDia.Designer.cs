﻿namespace ProyectoPAV1_Grupo7.Formularios.Reportes
{
    partial class frm_EstadisticasVentaSurtidorPorDia
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbSolicitante = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Estadisticas.EstadisticaVentaPorDia.rdlc" +
    "";
            this.reportViewer1.Location = new System.Drawing.Point(12, 93);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(910, 606);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(538, 14);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(90, 24);
            this.btnLimpiarFiltros.TabIndex = 14;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha desde:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(315, 17);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(202, 20);
            this.dtpFecha.TabIndex = 12;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged_1);
            // 
            // cmbSolicitante
            // 
            this.cmbSolicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSolicitante.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSolicitante.FormattingEnabled = true;
            this.cmbSolicitante.Location = new System.Drawing.Point(106, 18);
            this.cmbSolicitante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSolicitante.Name = "cmbSolicitante";
            this.cmbSolicitante.Size = new System.Drawing.Size(121, 21);
            this.cmbSolicitante.TabIndex = 10;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Location = new System.Drawing.Point(538, 44);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 24);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Filtrar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estacion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.cmbSolicitante);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 75);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // frm_EstadisticasVentaSurtidorPorDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 711);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.MinimumSize = new System.Drawing.Size(950, 750);
            this.Name = "frm_EstadisticasVentaSurtidorPorDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas Venta Surtidor Por Dia";
            this.Load += new System.EventHandler(this.frm_EstadisticasVentaSurtidorPorDia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbSolicitante;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}