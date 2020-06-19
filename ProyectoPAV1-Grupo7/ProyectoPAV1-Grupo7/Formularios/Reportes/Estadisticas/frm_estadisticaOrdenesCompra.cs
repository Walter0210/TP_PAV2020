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
            dtp_SucursalFechaDesde.Value = DateTime.Today;
            dtp_SucursalFechaHasta.Value = DateTime.Today;
        }

        private void rv_EstadisticaGeneralLoad(object sender, EventArgs e)
        {
            ObtenerEstadisticaOrdenesCompra();
        }

        private void ObtenerEstadisticaOrdenesCompra()
        {

            string stringWhere;
            stringWhere = stringFiltros(dtpFechaDesde1, dtpFechaHasta1);

            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT OC.numeroOrdenCompra as nroOrdenCompra, COUNT(DC.idProducto) as cantidad" +
                " FROM OrdenCompra OC JOIN DetalleOrdenCompra DC ON OC.numeroOrdenCompra = DC.numOrdenCompra" + stringWhere +
                " GROUP BY OC.numeroOrdenCompra";

            DataTable tabla = conexion.ejecutar_consulta(sql);
            ReportDataSource ds = new ReportDataSource("DatosEstadisticaOrdenesCompra", tabla);

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
            ObtenerEstadisticaOrdenesCompraSucursal();
        }

        private void ObtenerEstadisticaOrdenesCompraSucursal()
        {
            ConexionBD conexion = new ConexionBD();
            string stringWhere;

            stringWhere = stringFiltros(dtp_SucursalFechaDesde, dtp_SucursalFechaHasta);

            string sql = @"SELECT E.razonSocial, SUM(OC.total) as totalSuc" +
                        " FROM OrdenCompra OC JOIN Estacion E on OC.cuitSolicitante = E.CUIT " +
                        stringWhere +
                        " GROUP BY E.razonSocial";

            DataTable tabla = conexion.ejecutar_consulta(sql);
            ReportDataSource ds = new ReportDataSource("DatosOCSucursal", tabla);

            rv_Sucursal.LocalReport.DataSources.Clear();
            rv_Sucursal.LocalReport.DataSources.Add(ds);
            rv_Sucursal.RefreshReport();
            
        }

        private void btnFiltrarSucursal_Click(object sender, EventArgs e)
        {
            ObtenerEstadisticaOrdenesCompraSucursal();
        }

        private string stringFiltros(DateTimePicker desde, DateTimePicker hasta)
        {
            string stringWhere = string.Empty;
            string format = "yyyy-MM-dd HH:mm:ss";

            if (desde.Value != DateTime.Today)
            {
                stringWhere += " WHERE OC.fecha BETWEEN " + "'" + dtp_SucursalFechaDesde.Value.ToString(format) + "'" + " AND " + "'" + dtp_SucursalFechaHasta.Value.ToString(format) + "' ";
            }

            else if (hasta.Value != DateTime.Today)
            {
                stringWhere += " WHERE OC.fecha BETWEEN " + "'" + dtp_SucursalFechaDesde.Value.ToString(format) + "'" + " AND " + "'" + dtp_SucursalFechaHasta.Value.ToString(format) + "' ";
            }
            else
            {
                stringWhere = string.Empty;
            }

            return stringWhere;
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
            dtp_SucursalFechaDesde.Value = DateTime.Today;
            dtp_SucursalFechaHasta.Value = DateTime.Today;

            ObtenerEstadisticaOrdenesCompra();
        }
    }
}
