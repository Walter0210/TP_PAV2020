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
    public partial class frm_ListadoEmpleados : Form
    {
        private bool eligioFechaDesde = false;
        private bool eligioFechaHasta = false;
        private string where = string.Empty;

        public frm_ListadoEmpleados()
        {
            InitializeComponent();
        }

        private void frm_ListadoEmpleados_Load(object sender, EventArgs e)
        {
            this.rv_empleadosGeneral.RefreshReport();
            this.rv_empleadosXjefe.RefreshReport();

            cargarCombos();
        }


        private void rv_empleadosGeneral_Load(object sender, EventArgs e)
        {
            buscarEmpleados();
        }

        private void rv_empleadosXjefe_Load(object sender, EventArgs e)
        {
            buscarListadoEmpleados();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            ArmarStringFiltros();
            buscarEmpleados();
        }

        private void buscarEmpleados()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string consulta = @"select E.legajo"
                                    + ", E.nombre"
                                    + ", E.apellido"
                                    + ", TD.nombre as 'tipodni'"
                                    + ", E.nroDoc as 'dni'"
                                    + ", CONVERT (char, E.fechaNacimiento, 103) as 'fechaNacimiento'"
                                    + ", CONVERT (char, E.fechaAlta, 103) as 'fechaAlta'"
                                    + ", J.nombre + ' ' + J.apellido as 'Jefe'"
                                    + "from Empleado E left join TipoDocumento TD on E.tipoDoc = TD.idTipoDocumento "
                                                     + "left join Empleado J on E.legajoSuperior = J.legajo "
                                    + where;

                DataTable tablaEmpleados = conexion.ejecutar_consulta(consulta);
                ReportDataSource ds = new ReportDataSource("DatosEmpleados", tablaEmpleados);

                rv_empleadosGeneral.LocalReport.DataSources.Clear();
                rv_empleadosGeneral.LocalReport.DataSources.Add(ds);
                rv_empleadosGeneral.LocalReport.Refresh();
                rv_empleadosGeneral.RefreshReport();
                where = string.Empty;
            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
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

        private void ArmarStringFiltros()
        {
            string format = "yyyy-MM-dd";

            if (txt_legajo.Text.ToString().Trim() != "" || txt_dni.Text.ToString().Trim() != "")
            {
                if (txt_legajo.Text.ToString().Trim() != "")
                {
                    if (txt_dni.Text.ToString().Trim() == "")
                    {
                        where = "WHERE E.legajo = " + txt_legajo.Text.ToString();
                    }
                    else
                    {
                        where = "WHERE E.legajo = " + txt_legajo.Text.ToString() + " OR E.nroDoc = " + txt_dni.Text.ToString();
                    }
                }

                if (txt_dni.Text.ToString().Trim() != "")
                {
                    where = "WHERE E.nroDoc = " + txt_dni.Text.ToString();
                }

                if ((where.Contains("WHERE E.legajo = ") || where.Contains("WHERE E.nroDoc = ")) && eligioFechaDesde || eligioFechaHasta)
                {
                    where += " AND E.fechaAlta BETWEEN " + "'" + dateTime_desde.Value.ToString(format) + "'" + " AND " + "'" + dateTime_hasta.Value.ToString(format) + "'";
                }
            }
            else if (where == string.Empty && eligioFechaDesde || eligioFechaHasta)
            {
                where = "WHERE E.fechaAlta BETWEEN " + "'" + dateTime_desde.Value.ToString(format) + "'" + " AND " + "'" + dateTime_hasta.Value.ToString(format) + "'";
                if ((where.Contains("WHERE E.legajo = ") || where.Contains("WHERE E.nroDoc = ")))
                {
                    where += " AND E.fechaAlta BETWEEN " + "'" + dateTime_desde.Value.ToString(format) + "'" + " AND " + "'" + dateTime_hasta.Value.ToString(format) + "'";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_legajo.Text = "";
            txt_dni.Text = "";
            dateTime_desde.Value = DateTime.Now;
            dateTime_hasta.Value = DateTime.Now;
            eligioFechaDesde = false;
            eligioFechaHasta = false;
            where = string.Empty;

            buscarEmpleados();
        }

        private void cargarCombos()
        {

            cmb_JefeEmpleado.DataSource = buscarJefes();
            cmb_JefeEmpleado.DisplayMember = "apeNom";
            cmb_JefeEmpleado.ValueMember = "legajo";
            cmb_JefeEmpleado.SelectedIndex = -1;

        }

        private DataTable buscarJefes()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string sql = @"SELECT E.legajo, E.nombre + ' ' + E.apellido as apeNom
                                FROM Empleado E
                                WHERE E.legajo IN (SELECT legajoSuperior FROM Empleado) OR E.legajoSuperior is Null";
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

        private void lblEmpleadoJefe_Click(object sender, EventArgs e)
        {

        }

        private void buscarListadoEmpleados()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string consulta = @"select E.legajo"
                                    + ", E.nombre"
                                    + ", E.apellido"
                                    + ", TD.nombre as 'tipoDoc'"
                                    + ", E.nroDoc as 'nroDoc'"
                                    + ", CONVERT (char, E.fechaNacimiento, 103) as 'fechaNacimiento'"
                                    + ", CONVERT (char, E.fechaAlta, 103) as 'fechaAlta'"
                                    + ", J.nombre + ' ' + J.apellido as 'Jefe'"
                                    + "from Empleado E left join TipoDocumento TD on E.tipoDoc = TD.idTipoDocumento "
                                                     + "left join Empleado J on E.legajoSuperior = J.legajo ";

                DataTable tablaEmpleados = conexion.ejecutar_consulta(consulta);
                ReportDataSource ds = new ReportDataSource("empleadosXjefe", tablaEmpleados);

                rv_empleadosXjefe.LocalReport.DataSources.Clear();
                rv_empleadosXjefe.LocalReport.DataSources.Add(ds);
                rv_empleadosXjefe.LocalReport.Refresh();
                rv_empleadosXjefe.RefreshReport();
                where = string.Empty;
            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
            }
        }

        private void btnFiltrarEmpleados2_Click(object sender, EventArgs e)
        {
            buscarEmpleadosPorJefe();
        }

        private void buscarEmpleadosPorJefe()
        {

            where = "WHERE E.legajoSuperior = " + cmb_JefeEmpleado.SelectedValue; 

            try
            {
                ConexionBD conexion = new ConexionBD();
                string consulta = @"select E.legajo"
                                    + ", E.nombre"
                                    + ", E.apellido"
                                    + ", TD.nombre as 'tipoDoc'"
                                    + ", E.nroDoc as 'nroDoc'"
                                    + ", CONVERT (char, E.fechaNacimiento, 103) as 'fechaNacimiento'"
                                    + ", CONVERT (char, E.fechaAlta, 103) as 'fechaAlta'"
                                    + ", J.nombre + ' ' + J.apellido as 'Jefe'"
                                    + "from Empleado E left join TipoDocumento TD on E.tipoDoc = TD.idTipoDocumento "
                                                     + "left join Empleado J on E.legajoSuperior = J.legajo "
                                    + where;

                DataTable tablaEmpleados = conexion.ejecutar_consulta(consulta);
                ReportDataSource ds = new ReportDataSource("empleadosXjefe", tablaEmpleados);

                rv_empleadosXjefe.LocalReport.DataSources.Clear();
                rv_empleadosXjefe.LocalReport.DataSources.Add(ds);
                rv_empleadosXjefe.LocalReport.Refresh();
                rv_empleadosXjefe.RefreshReport();
                where = string.Empty;
            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
            }
        }

        private void btn_filtrar_Click_1(object sender, EventArgs e)
        {
            ArmarStringFiltros();
            buscarEmpleados();
        }

        private void btnLimpiarFiltros2_Click(object sender, EventArgs e)
        {
            cmb_JefeEmpleado.SelectedIndex = -1;
            rv_empleadosXjefe.Clear();
            buscarListadoEmpleados();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_legajo.Clear();
            txt_dni.Clear();
            rv_empleadosGeneral.Clear();
            buscarListadoEmpleados();
        }
    }
}
