using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPAV1_Grupo7.Clases;
using Microsoft.Reporting.WinForms;

namespace ProyectoPAV1_Grupo7.Formularios.Reportes
{
    public partial class frm_EstadisticaProductosVendidos : Form
    {
        private bool eligioFechaDesde = false;
        private bool eligioFechaHasta = false;
        private string where = string.Empty;

        public frm_EstadisticaProductosVendidos()
        {
            InitializeComponent();
        }

        private void frm_EstadisticaProductosVendidos_Load(object sender, EventArgs e)
        {

            this.reportViewerProductos.RefreshReport();
            cargarCombos();
            this.reportViewerProductos2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            buscarProductos();
        }

        private void reportViewer1_Load2(object sender, EventArgs e)
        {
            buscarProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmarStringFiltros();
            buscarProductos();
        }

        private void dateTime_desde_ValueChanged(object sender, EventArgs e)
        {
            eligioFechaDesde = true;
        }

        private void dateTime_hasta_ValueChanged(object sender, EventArgs e)
        {
            eligioFechaHasta = true;
        }

        private void buscarProductos()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string consulta = @"SELECT CONVERT(varchar, P.descripcion) as Producto, SUM(CONVERT(INT, TP.cantidad)) as Cantidad"
                                    + " FROM TicketXProducto AS TP INNER JOIN "
                                          + "Ticket AS T ON TP.numeroTicket = T.numTicket INNER JOIN "
                                          + "Producto AS P ON TP.idProducto = P.idProducto INNER JOIN "
                                          + "UnidadMedida AS UM ON T.idUnidadMedida = UM.idUnidadMedida INNER JOIN "
                                          + "Estacion AS E ON T.cuit = E.CUIT "
                                    + where
                                    + " GROUP BY P.descripcion";

                DataTable tablaProductosMasVendidos = conexion.ejecutar_consulta(consulta);
                ReportDataSource ds = new ReportDataSource("DatosProductosVendidos", tablaProductosMasVendidos);

                reportViewerProductos.LocalReport.DataSources.Clear();
                reportViewerProductos2.LocalReport.DataSources.Clear();
                reportViewerProductos.LocalReport.DataSources.Add(ds);
                reportViewerProductos2.LocalReport.DataSources.Add(ds);
                reportViewerProductos.LocalReport.Refresh();
                reportViewerProductos2.LocalReport.Refresh();
                reportViewerProductos.RefreshReport();
                reportViewerProductos2.RefreshReport();
                where = string.Empty;
            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
                this.Dispose();
            }
        }

        private void ArmarStringFiltros()
        {
            string format = "yyyy-MM-dd";

            if (cmb_Estacion.SelectedIndex != -1)
            {
                if (where == string.Empty)
                {
                    where = "WHERE E.CUIT = " + cmb_Estacion.SelectedValue;
                    //stringRestriccion = "Estacion = " + cmb_Estacion.Text;
                }
                else
                {
                    where += " AND E.CUIT = " + cmb_Estacion.SelectedValue;
                    //stringRestriccion += " | Estacion = " + cmb_Estacion.Text;
                }
            }

            if ((eligioFechaDesde || eligioFechaHasta))
            {
                if (where.Contains("WHERE E.CUIT = "))
                {
                    where += " AND T.fecha BETWEEN " + "'" + dateTime_desde.Value.ToString(format) + "'" + " AND " + "'" + dateTime_hasta.Value.ToString(format) + "'";
                }
                if (where == string.Empty)
                {
                    where = "WHERE T.fecha BETWEEN " + "'" + dateTime_desde.Value.ToString(format) + "'" + " AND " + "'" + dateTime_hasta.Value.ToString(format) + "'";
                }
               
            }
        }

        private void cargarCombos()
        {
            // ESTACION
            cmb_Estacion.DataSource = buscarEstaciones();
            cmb_Estacion.DisplayMember = "razonSocial";
            cmb_Estacion.ValueMember = "CUIT";
            cmb_Estacion.SelectedIndex = -1;

        }

        private DataTable buscarEstaciones()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string sql = "SELECT * FROM Estacion";
                DataTable tabla = conexion.ejecutar_consulta(sql);
                return tabla;

            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
                DataTable vacio = new DataTable();
                return vacio;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmb_Estacion.SelectedIndex = -1;
            dateTime_desde.Value = DateTime.Now;
            dateTime_hasta.Value = DateTime.Now;
            eligioFechaDesde = false;
            eligioFechaHasta = false;
            where = string.Empty;
            //stringRestriccion = string.Empty;
            buscarProductos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
