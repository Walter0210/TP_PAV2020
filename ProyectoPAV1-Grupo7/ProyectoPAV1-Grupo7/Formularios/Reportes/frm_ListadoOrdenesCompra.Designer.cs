﻿namespace ProyectoPAV1_Grupo7.Formularios.Reportes
{
    partial class frm_ListadoOrdenesCompra
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cmbSolicitante = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.ListadoOrdenesCompra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 52);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(915, 525);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(599, 12);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(72, 24);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cmbSolicitante
            // 
            this.cmbSolicitante.FormattingEnabled = true;
            this.cmbSolicitante.Location = new System.Drawing.Point(344, 12);
            this.cmbSolicitante.Name = "cmbSolicitante";
            this.cmbSolicitante.Size = new System.Drawing.Size(220, 24);
            this.cmbSolicitante.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Solicitante:";
            // 
            // frm_ListadoOrdenesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSolicitante);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_ListadoOrdenesCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Ordenes de Compra";
            this.Load += new System.EventHandler(this.frm_ListadoOrdenesCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cmbSolicitante;
        private System.Windows.Forms.Label label1;
    }
}