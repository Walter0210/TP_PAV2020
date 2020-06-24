namespace ProyectoPAV1_Grupo7.Formularios.Reportes
{
    partial class frm_ListadoEmpleados
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTime_hasta = new System.Windows.Forms.DateTimePicker();
            this.dateTime_desde = new System.Windows.Forms.DateTimePicker();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.Label();
            this.txt_legajo = new System.Windows.Forms.TextBox();
            this.legajo = new System.Windows.Forms.Label();
            this.rv_empleadosGeneral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rv_empleadosXjefe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmb_JefeEmpleado = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltros2 = new System.Windows.Forms.Button();
            this.btnFiltrarEmpleados2 = new System.Windows.Forms.Button();
            this.lblEmpleadoJefe = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1179, 875);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btn_limpiar);
            this.tabPage1.Controls.Add(this.btn_filtrar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.rv_empleadosGeneral);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1171, 846);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTime_hasta);
            this.groupBox2.Controls.Add(this.dateTime_desde);
            this.groupBox2.Location = new System.Drawing.Point(304, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(409, 113);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha de Alta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta";
            // 
            // dateTime_hasta
            // 
            this.dateTime_hasta.Location = new System.Drawing.Point(93, 71);
            this.dateTime_hasta.Margin = new System.Windows.Forms.Padding(4);
            this.dateTime_hasta.Name = "dateTime_hasta";
            this.dateTime_hasta.Size = new System.Drawing.Size(261, 22);
            this.dateTime_hasta.TabIndex = 3;
            // 
            // dateTime_desde
            // 
            this.dateTime_desde.Location = new System.Drawing.Point(93, 32);
            this.dateTime_desde.Margin = new System.Windows.Forms.Padding(4);
            this.dateTime_desde.Name = "dateTime_desde";
            this.dateTime_desde.Size = new System.Drawing.Size(261, 22);
            this.dateTime_desde.TabIndex = 2;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(762, 90);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(100, 28);
            this.btn_limpiar.TabIndex = 13;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(762, 35);
            this.btn_filtrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(100, 28);
            this.btn_filtrar.TabIndex = 12;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_dni);
            this.groupBox1.Controls.Add(this.dni);
            this.groupBox1.Controls.Add(this.txt_legajo);
            this.groupBox1.Controls.Add(this.legajo);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(245, 113);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por:";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(91, 74);
            this.txt_dni.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(132, 22);
            this.txt_dni.TabIndex = 3;
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Location = new System.Drawing.Point(48, 74);
            this.dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(31, 17);
            this.dni.TabIndex = 2;
            this.dni.Text = "DNI";
            // 
            // txt_legajo
            // 
            this.txt_legajo.Location = new System.Drawing.Point(91, 32);
            this.txt_legajo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(132, 22);
            this.txt_legajo.TabIndex = 1;
            // 
            // legajo
            // 
            this.legajo.AutoSize = true;
            this.legajo.Location = new System.Drawing.Point(31, 32);
            this.legajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.legajo.Name = "legajo";
            this.legajo.Size = new System.Drawing.Size(51, 17);
            this.legajo.TabIndex = 0;
            this.legajo.Text = "Legajo";
            // 
            // rv_empleadosGeneral
            // 
            this.rv_empleadosGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_empleadosGeneral.AutoSize = true;
            this.rv_empleadosGeneral.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Listados.ListadoEmpleados.rdlc";
            this.rv_empleadosGeneral.Location = new System.Drawing.Point(15, 152);
            this.rv_empleadosGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.rv_empleadosGeneral.Name = "rv_empleadosGeneral";
            this.rv_empleadosGeneral.ServerReport.BearerToken = null;
            this.rv_empleadosGeneral.Size = new System.Drawing.Size(1145, 713);
            this.rv_empleadosGeneral.TabIndex = 10;
            this.rv_empleadosGeneral.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rv_empleadosGeneral.Load += new System.EventHandler(this.rv_empleadosGeneral_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rv_empleadosXjefe);
            this.tabPage2.Controls.Add(this.cmb_JefeEmpleado);
            this.tabPage2.Controls.Add(this.btnLimpiarFiltros2);
            this.tabPage2.Controls.Add(this.btnFiltrarEmpleados2);
            this.tabPage2.Controls.Add(this.lblEmpleadoJefe);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1171, 846);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Empleados por Jefe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rv_empleadosXjefe
            // 
            this.rv_empleadosXjefe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_empleadosXjefe.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.Listados.Listado_EmpleadosPorJefe.rdlc";
            this.rv_empleadosXjefe.Location = new System.Drawing.Point(23, 51);
            this.rv_empleadosXjefe.Name = "rv_empleadosXjefe";
            this.rv_empleadosXjefe.ServerReport.BearerToken = null;
            this.rv_empleadosXjefe.Size = new System.Drawing.Size(1110, 763);
            this.rv_empleadosXjefe.TabIndex = 25;
            this.rv_empleadosXjefe.Load += new System.EventHandler(this.rv_empleadosXjefe_Load);
            // 
            // cmb_JefeEmpleado
            // 
            this.cmb_JefeEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_JefeEmpleado.FormattingEnabled = true;
            this.cmb_JefeEmpleado.Location = new System.Drawing.Point(197, 10);
            this.cmb_JefeEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_JefeEmpleado.Name = "cmb_JefeEmpleado";
            this.cmb_JefeEmpleado.Size = new System.Drawing.Size(193, 24);
            this.cmb_JefeEmpleado.TabIndex = 24;
            // 
            // btnLimpiarFiltros2
            // 
            this.btnLimpiarFiltros2.Location = new System.Drawing.Point(595, 6);
            this.btnLimpiarFiltros2.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarFiltros2.Name = "btnLimpiarFiltros2";
            this.btnLimpiarFiltros2.Size = new System.Drawing.Size(113, 28);
            this.btnLimpiarFiltros2.TabIndex = 23;
            this.btnLimpiarFiltros2.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros2.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros2.Click += new System.EventHandler(this.btnLimpiarFiltros2_Click);
            // 
            // btnFiltrarEmpleados2
            // 
            this.btnFiltrarEmpleados2.Location = new System.Drawing.Point(728, 6);
            this.btnFiltrarEmpleados2.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrarEmpleados2.Name = "btnFiltrarEmpleados2";
            this.btnFiltrarEmpleados2.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrarEmpleados2.TabIndex = 20;
            this.btnFiltrarEmpleados2.Text = "Filtrar";
            this.btnFiltrarEmpleados2.UseVisualStyleBackColor = true;
            this.btnFiltrarEmpleados2.Click += new System.EventHandler(this.btnFiltrarEmpleados2_Click);
            // 
            // lblEmpleadoJefe
            // 
            this.lblEmpleadoJefe.AutoSize = true;
            this.lblEmpleadoJefe.Location = new System.Drawing.Point(150, 12);
            this.lblEmpleadoJefe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleadoJefe.Name = "lblEmpleadoJefe";
            this.lblEmpleadoJefe.Size = new System.Drawing.Size(39, 17);
            this.lblEmpleadoJefe.TabIndex = 18;
            this.lblEmpleadoJefe.Text = "Jefe:";
            this.lblEmpleadoJefe.Click += new System.EventHandler(this.lblEmpleadoJefe_Click);
            // 
            // frm_ListadoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 875);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(927, 912);
            this.Name = "frm_ListadoEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frm_ListadoEmpleados_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTime_hasta;
        private System.Windows.Forms.DateTimePicker dateTime_desde;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.TextBox txt_legajo;
        private System.Windows.Forms.Label legajo;
        private Microsoft.Reporting.WinForms.ReportViewer rv_empleadosGeneral;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLimpiarFiltros2;
        private System.Windows.Forms.Button btnFiltrarEmpleados2;
        private System.Windows.Forms.Label lblEmpleadoJefe;
        private System.Windows.Forms.ComboBox cmb_JefeEmpleado;
        private Microsoft.Reporting.WinForms.ReportViewer rv_empleadosXjefe;
    }
}