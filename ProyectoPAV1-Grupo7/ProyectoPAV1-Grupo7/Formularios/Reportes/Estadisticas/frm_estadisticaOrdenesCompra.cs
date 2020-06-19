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
        string stringWhereMeses = string.Empty;

        public frm_EstadisticaOrdenesCompra()
        {
            InitializeComponent();
        }

        private void frm_estadisticaOrdenesCompra_Load(object sender, EventArgs e)
        {
            rv_Meses.RefreshReport();
            rv_EstadisticaGeneral.RefreshReport();
            rv_Sucursal.RefreshReport();
        }

        private void rv_EstadisticaGeneralLoad(object sender, EventArgs e)
        {
            ObtenerEstadisticaOrdenesCompra();
        }

        private void ObtenerEstadisticaOrdenesCompra()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT OC.numeroOrdenCompra as nroOrdenCompra, COUNT(DC.idProducto) as cantidad" +
                " FROM OrdenCompra OC JOIN DetalleOrdenCompra DC ON OC.numeroOrdenCompra = DC.numOrdenCompra" +
                " GROUP BY OC.numeroOrdenCompra";

            DataTable tabla = conexion.ejecutar_consulta(sql);
            ReportDataSource ds = new ReportDataSource("DatosEstadisticaOrdenesCompra", tabla);

            rv_EstadisticaGeneral.LocalReport.DataSources.Clear();
            rv_EstadisticaGeneral.LocalReport.DataSources.Add(ds);
            rv_EstadisticaGeneral.LocalReport.Refresh();
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
            //DataTable table = new DataTable();
            //ReportDataSource ds = new ReportDataSource("DatosOCSucursal", ObtenerEstadisticaOrdenesCompraSucursal());

            //rv_Sucursal.LocalReport.DataSources.Clear();
            //rv_Sucursal.LocalReport.DataSources.Add(ds);
            //rv_Sucursal.RefreshReport();
            ObtenerEstadisticaOrdenesCompraSucursal();
        }

        private void ObtenerEstadisticaOrdenesCompraSucursal()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = @"SELECT E.razonSocial, SUM(OC.total) as totalSuc" +
                        " FROM OrdenCompra OC JOIN Estacion E on OC.cuitSolicitante = E.CUIT " + 
                        stringWhereMeses +
                        " GROUP BY E.razonSocial";

            DataTable tabla = conexion.ejecutar_consulta(sql);
            
            ReportDataSource ds = new ReportDataSource("DatosOCSucursal", tabla);

            rv_Sucursal.LocalReport.DataSources.Clear();
            rv_Sucursal.LocalReport.DataSources.Add(ds);
            rv_Sucursal.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            stringWhereMeses = string.Empty;

            if (dtp_FechaDesde.Value != DateTime.Today && stringWhereMeses == string.Empty)
            {
                stringWhereMeses += " WHERE OC.fecha BETWEEN " + "'" + dtp_FechaDesde.Value.ToString(format) + "'" + " AND " + "'" + dtp_fechaHasta.Value.ToString(format) + "' ";
                ObtenerEstadisticaOrdenesCompraSucursal();
            }

            if (dtp_fechaHasta.Value != DateTime.Today && stringWhereMeses == string.Empty)
            {
                stringWhereMeses += " WHERE OC.fecha BETWEEN " + "'" + dtp_FechaDesde.Value.ToString(format) + "'" + " AND " + "'" + dtp_fechaHasta.Value.ToString(format) + "' ";
                ObtenerEstadisticaOrdenesCompraSucursal();
            }
        }

        private void btn_Limpiar3_Click(object sender, EventArgs e)
        {
            dtp_FechaDesde.Value = DateTime.Today;
            dtp_fechaHasta.Value = DateTime.Today;
            stringWhereMeses = string.Empty;

            ObtenerEstadisticaOrdenesCompraSucursal();
        }
    }
}
