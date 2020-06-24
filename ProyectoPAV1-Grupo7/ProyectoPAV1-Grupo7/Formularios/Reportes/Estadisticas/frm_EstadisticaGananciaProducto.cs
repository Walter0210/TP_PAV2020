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
    public partial class frm_EstadisticaGananciaProducto : Form
    {
        private string where = string.Empty;
        private bool eligioFechaDesde = false;
        private bool eligioFechaHasta = false;

        public frm_EstadisticaGananciaProducto()
        {
            InitializeComponent();
        }

        private void frm_EstadisticaGananciaProducto_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            cargarCombos();
            //List<Producto> listaProductos = new List<Producto>();
            //Producto prod1 = new Producto("prod1", 500, 50, 100, DateTime.Now);
            //Producto prod2 = new Producto("prod2", 500, 50, 100, DateTime.Now);
            //listaProductos.Add(prod1);
            //listaProductos.Add(prod2);
            //this.checkedListBox1.DataSource = listaProductos.ToList();


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            buscarProductos();
        }

        private void buscarProductos()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string consulta = @"select P.descripcion as 'producto', P.precioCompra, P.precioVenta, "
                                + "(P.precioVenta - P.precioCompra) as 'ganancia', ROUND(((P.precioVenta - P.precioCompra) * 100.0 / P.precioCompra), 2) as 'porcentajeGanancia'"
                                   + " from Producto P "
                                   + where;
                DataTable tablaGananciaProductos = conexion.ejecutar_consulta(consulta);
                ReportDataSource ds = new ReportDataSource("DatosGananciaProducto", tablaGananciaProductos);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer2.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer2.LocalReport.DataSources.Add(ds);
                reportViewer1.LocalReport.Refresh();
                reportViewer2.LocalReport.Refresh();
                reportViewer1.RefreshReport();
                reportViewer2.RefreshReport();
                where = string.Empty;

            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
                this.Dispose();
            }
        }
        private void cargarCombos()
        {
            cmb_Comparacion.Items.Add(">");
            cmb_Comparacion.Items.Add("<");
            cmb_Comparacion.Items.Add("=");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmarStringFiltros();
            buscarProductos();
        }

        private void ArmarStringFiltros()
        {
            string format = "yyyy-MM-dd";


            if (txt_nombre.Text.ToString().Trim() != "")
            {
                if (where == string.Empty)
                {
                    where = "WHERE P.descripcion like '%" + txt_nombre.Text.ToString() + "%'";
                }
            }

           
            if (cmb_Comparacion.SelectedIndex != -1)
            {
                if (where == string.Empty)
                {
                    where = "WHERE ROUND(((P.precioVenta - P.precioCompra) * 100.0 / P.precioCompra), 2) " + cmb_Comparacion.SelectedItem + " " + txt_porcentaje.Text.ToString();
                    //stringRestriccion = "Estacion = " + cmb_Estacion.Text;
                }
                else
                {
                    where += " AND ROUND(((P.precioVenta - P.precioCompra) * 100.0 / P.precioCompra), 2) " + cmb_Comparacion.SelectedItem + " " + txt_porcentaje.Text.ToString();
                    //stringRestriccion += " | Estacion = " + cmb_Estacion.Text;
                }
            }

            if ((eligioFechaDesde || eligioFechaHasta))
            {
               
                if (where == string.Empty)
                {
                    where = "WHERE P.fechaUltimaActualizacion BETWEEN " + "'" + dateTime_desde.Value.ToString(format) + "'" + " AND " + "'" + dateTime_hasta.Value.ToString(format) + "'";
                }
                else
                {
                    where += " AND P.fechaUltimaActualizacion BETWEEN " + "'" + dateTime_desde.Value.ToString(format) + "'" + " AND " + "'" + dateTime_hasta.Value.ToString(format) + "'";
                }

            }
        }

        private void txtCaracter_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar.ToString() != "," && e.KeyChar.ToString() != ".")
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }*/

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }


        private void dateTime_desde_ValueChanged(object sender, EventArgs e)
        {
            eligioFechaDesde = true;
        }

        private void dateTime_hasta_ValueChanged(object sender, EventArgs e)
        {
            eligioFechaHasta = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            cmb_Comparacion.SelectedIndex = -1;
            txt_porcentaje.Text = "";
            dateTime_desde.Value = DateTime.Now;
            dateTime_hasta.Value = DateTime.Now;
            eligioFechaDesde = false;
            eligioFechaHasta = false;
            where = string.Empty;

            buscarProductos();
        }
    }

}
