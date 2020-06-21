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
    public partial class frm_EstadisticaOrdenesCompra : Form
    {
        //string stringWhereMeses = string.Empty;

        public frm_EstadisticaOrdenesCompra()
        {
            InitializeComponent();
        }

        private void frm_estadisticaOrdenesCompra_Load(object sender, EventArgs e)
        {
            rv_Meses.RefreshReport();
            rv_EstadisticaGeneral.RefreshReport();
            rv_Sucursal.RefreshReport();


            //dtp_SucursalFechaDesde.Value = DateTime.Today;
            //dtp_SucursalFechaHasta.Value = DateTime.Today;
        }

        private void rv_EstadisticaGeneralLoad(object sender, EventArgs e)
        {
            dtp_GeneralFechaDesde.Value = DateTime.Today;
            dtp_GeneralFechaHasta.Value = DateTime.Today;
            ObtenerEstadisticaOrdenesCompra();
        }

        private void ObtenerEstadisticaOrdenesCompra()
        {
            string stringWhere = string.Empty;
            string stringRes = string.Empty;

            stringWhere = stringFiltros(dtp_GeneralFechaDesde.Value, dtp_GeneralFechaHasta.Value);
            stringRes = stringRestriccion(dtp_GeneralFechaDesde.Value, dtp_GeneralFechaHasta.Value);

            ConexionBD conexion = new ConexionBD();

            string sql = "SELECT(E.nombre + ' ' + E.apellido) AS apeNom, COUNT(OC.numeroOrdenCompra) AS cantidadOC " +
                "FROM OrdenCompra OC JOIN Empleado E ON OC.legajo = E.legajo " +
                 stringWhere +
                "GROUP BY E.nombre, E.apellido";

            DataTable tabla = conexion.ejecutar_consulta(sql);
            ReportDataSource ds = new ReportDataSource("DatosEstadisticaOrdenesCompra", tabla);

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccionResponsables", stringRes);
            rv_EstadisticaGeneral.LocalReport.SetParameters(parametros);

            rv_EstadisticaGeneral.LocalReport.DataSources.Clear();
            rv_EstadisticaGeneral.LocalReport.DataSources.Add(ds);
            rv_EstadisticaGeneral.RefreshReport();
        }

        private void rv_Meses_Load(object sender, EventArgs e)
        {
            ObtenerEstadisticaOrdenesCompraMeses();
        }

        private void ObtenerEstadisticaOrdenesCompraMeses()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = @"SELECT OC.fecha, OC.total
                           FROM OrdenCompra OC LEFT JOIN DetalleOrdenCompra DOC on OC.numeroOrdenCompra = DOC.numOrdenCompra";

            DataTable tabla = conexion.ejecutar_consulta(sql);
            ReportDataSource ds = new ReportDataSource("DatosEstadisticasMensuales", tabla);

            rv_Meses.LocalReport.DataSources.Clear();
            rv_Meses.LocalReport.DataSources.Add(ds);
            rv_Meses.RefreshReport();
        }

        private void rv_Sucursal_Load(object sender, EventArgs e)
        {
            dtp_SucursalFechaDesde.Value = DateTime.Today;
            dtp_SucursalFechaHasta.Value = DateTime.Today;

            ObtenerEstadisticaOrdenesCompraSucursal();
        }

        private void ObtenerEstadisticaOrdenesCompraSucursal()
        {
            ConexionBD conexion = new ConexionBD();
            string stringWhere;
            string stringRes;

            stringWhere = stringFiltros(dtp_SucursalFechaDesde.Value, dtp_SucursalFechaHasta.Value);
            stringRes = stringRestriccion(dtp_SucursalFechaDesde.Value, dtp_SucursalFechaHasta.Value);

            string sql = @"SELECT E.razonSocial, SUM(OC.total) as totalSuc" +
                        " FROM OrdenCompra OC JOIN Estacion E on OC.cuitSolicitante = E.CUIT " +
                        stringWhere +
                        " GROUP BY E.razonSocial";

            DataTable tabla = conexion.ejecutar_consulta(sql);
            ReportDataSource ds = new ReportDataSource("DatosOCSucursal", tabla);

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RestriccionSucursales", stringRes);
            rv_Sucursal.LocalReport.SetParameters(parametros);

            rv_Sucursal.LocalReport.DataSources.Clear();
            rv_Sucursal.LocalReport.DataSources.Add(ds);
            rv_Sucursal.RefreshReport();
            
        }

        private void btnFiltrarSucursal_Click(object sender, EventArgs e)
        {
            ObtenerEstadisticaOrdenesCompraSucursal();
        }

        private string stringFiltros(DateTime desde, DateTime hasta)
        {
            string stringWhere = string.Empty;
            string format = "yyyy-MM-dd HH:mm:ss";

            if (desde != DateTime.Today)
            {
                stringWhere = " WHERE OC.fecha BETWEEN " + "'" + desde.ToString(format) + "'" + " AND " + "'" + hasta.ToString(format) + "' ";
            }

            else if (hasta != DateTime.Today)
            {
                stringWhere = " WHERE OC.fecha BETWEEN " + "'" + desde.ToString(format) + "'" + " AND " + "'" + hasta.ToString(format) + "' ";
            }

            else
            {
                stringWhere = string.Empty;
            }

            return stringWhere;
        }


        private string stringRestriccion(DateTime desde, DateTime hasta)
        {
            string stringRestriccion = string.Empty;
            string shortFormat = "dd-MM-yyyy";

            stringRestriccion = stringRestriccion = "Entre: " + "'" + desde.ToString(shortFormat) + "'" + " Y " + "'" + hasta.ToString(shortFormat) + "'";

            return stringRestriccion;
        }

        private void btn_LimpiarFiltrosSucursal_Click(object sender, EventArgs e)
        {
            dtp_SucursalFechaDesde.Value = DateTime.Today;
            dtp_SucursalFechaHasta.Value = DateTime.Today;

            ObtenerEstadisticaOrdenesCompraSucursal();
        }

        private void btnFiltrarGeneral_Click(object sender, EventArgs e)
        {
            ObtenerEstadisticaOrdenesCompra();
        }

        private void btnLimpiarFiltrosGeneral_Click(object sender, EventArgs e)
        {
            dtp_GeneralFechaDesde.Value = DateTime.Today;
            dtp_GeneralFechaHasta.Value = DateTime.Today;

            ObtenerEstadisticaOrdenesCompra();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
