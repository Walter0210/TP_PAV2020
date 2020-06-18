
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
    public partial class frm_EstadisticasVentaSurtidorPorDia : Form
    {
        private string stringWhere = string.Empty;
        private string stringRestriccion;
        private bool eligiofecha = false;
        public frm_EstadisticasVentaSurtidorPorDia()
        {
            InitializeComponent();
            cargarComboEstacion();
        }

        private void frm_EstadisticasVentaSurtidorPorDia_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        private void cargarComboEstacion()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT  * FROM Estacion";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            cmbSolicitante.DataSource = tabla;
            cmbSolicitante.DisplayMember = "razonSocial ";
            cmbSolicitante.ValueMember = "CUIT";
            cmbSolicitante.SelectedIndex = -1;
        }

        private DataTable ObtenerListado()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = @"select S.numeroSurtidor, S.cuit, SUM(T.cantidad) AS Sumatoria
from Ticket T RIGHT JOIN Surtidor S on T.numeroSurtidor = S.numeroSurtidor and T.cuit = S.cuit "
 + stringWhere + " group by S.numeroSurtidor, S.cuit ";

            DataTable tabla = conexion.ejecutar_consulta(sql);
            return tabla;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = ObtenerListado();

            ReportDataSource ds = new ReportDataSource("DatosCantidadSurtidor", table);

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", "");
            reportViewer1.LocalReport.SetParameters(parametros);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            stringWhere = string.Empty;
            stringRestriccion = string.Empty;
            ArmarStringFiltros();
            //int solicitante = int.Parse(cmbSolicitante.SelectedValue.ToString());

            ReportDataSource ds = new ReportDataSource("DatosCantidadSurtidor", ObtenerListado());

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            reportViewer1.LocalReport.SetParameters(parametros);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void ArmarStringFiltros()
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            string shortFormat = "yyyy-MM-dd";

            if (cmbSolicitante.SelectedIndex != -1)
            {
                if (stringWhere == string.Empty)
                {
                    stringWhere = "WHERE S.cuit = " + cmbSolicitante.SelectedValue;
                    stringRestriccion = "Estación: " + cmbSolicitante.Text;
                }
                else
                {
                    stringWhere += " AND S.cuit = " + cmbSolicitante.SelectedValue;
                    stringRestriccion += " | Estación: " + cmbSolicitante.Text;
                }
            }

            if (eligiofecha)
            {
                if (stringWhere == string.Empty)
                {
                    stringWhere = "WHERE T.fecha LIKE " + "'" + dtpFecha.Value.ToString(shortFormat) + "'";
                    stringRestriccion = "Para: " + "'" + dtpFecha.Value.ToString(shortFormat) + "'";
                }
                else
                {
                    stringWhere += " AND T.fecha LIKE " + "'" + dtpFecha.Value.ToString(shortFormat) + "'";
                    stringRestriccion += " | Para: " + "'" + dtpFecha.Value.ToString(shortFormat) + "'";
                }
            }
        }
     

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            eligiofecha = true;
        }

        private void btnLimpiarFiltros_Click_1(object sender, EventArgs e)
        {
            cmbSolicitante.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            eligiofecha = false;
            stringWhere = string.Empty;
            stringRestriccion = string.Empty;

            DataTable table = new DataTable();
            table = ObtenerListado();

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            reportViewer1.LocalReport.SetParameters(parametros);

            ReportDataSource ds = new ReportDataSource("DatosCantidadSurtidor", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }
    }
}
