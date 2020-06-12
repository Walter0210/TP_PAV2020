using Microsoft.Reporting.WinForms;
using ProyectoPAV1_Grupo7.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV1_Grupo7.Formularios.Reportes
{
    public partial class frm_ListadoOrdenesCompra : Form
    {
        public frm_ListadoOrdenesCompra()
        {
            InitializeComponent();
            cargarComboSolicitante();
            cargarComboResponsable();
        }

        private void cargarComboResponsable()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT  E.nombre + ' ' + E.apellido as 'ApeNom', E.legajo FROM Empleado E";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            cmbResponsable.DataSource = tabla;
            cmbResponsable.DisplayMember = "ApeNom";
            cmbResponsable.ValueMember = "legajo";
            cmbResponsable.SelectedIndex = -1;
        }

        private void frm_ListadoOrdenesCompra_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
            /*DataTable table = new DataTable();
            table = frm_ConsultaOrdenCompra.ObtenerListadoOrdenesCompra();

            ReportDataSource ds = new ReportDataSource("DatosOrdenesCompra", table);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh(); */


            DataTable table = new DataTable();
            table = frm_ConsultaOrdenCompra.ObtenerListadoOrdenesCompra();

            ReportDataSource ds = new ReportDataSource("DatosOrdenesCompra", table);

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", "");
            reportViewer1.LocalReport.SetParameters(parametros);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh(); 
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbSolicitante.SelectedIndex != -1 && cmbResponsable.SelectedIndex != -1 && dtpDesde.Value != dtpHasta.Value)
            {
                int solicitante = int.Parse(cmbSolicitante.SelectedValue.ToString());
                
                ReportDataSource ds = new ReportDataSource("DatosOrdenesCompra", ObtenerSolicitante(solicitante));

                //reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.ListadoOrdenesCompra.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("restriccion", "Restringido por el solicitante con cuit: " + solicitante);
                reportViewer1.LocalReport.SetParameters(parametros);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Debe seleccionar por lo menos un filtro!");
            }
        }

        private void cargarComboSolicitante()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Estacion";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            cmbSolicitante.DataSource = tabla;
            cmbSolicitante.DisplayMember = "razonSocial";
            cmbSolicitante.ValueMember = "CUIT";
            cmbSolicitante.SelectedIndex = -1;
        }

        private DataTable ObtenerSolicitante(int solicitante)
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT OC.numeroOrdenCompra as numeroOrdenCompra, OC.fecha as fecha, E.nombre + E.apellido AS legajo, S.razonSocial as cuitSolicitante, OC.total as total" +
                " FROM OrdenCompra OC JOIN Empleado E ON OC.legajo = E.legajo " +
                "JOIN Estacion S ON OC.cuitSolicitante = S.CUIT " +
                "WHERE S.CUIT = '" + solicitante + "'";

            //string sql = "SELECT * FROM Estacion WHERE CUIT = " + solicitante;
            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;
        }
    }
}
