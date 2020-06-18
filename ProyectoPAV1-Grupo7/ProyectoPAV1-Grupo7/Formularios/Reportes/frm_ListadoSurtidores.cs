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
using System.Runtime.InteropServices;

namespace ProyectoPAV1_Grupo7.Formularios.Reportes
{
    public partial class frm_ListadoSurtidores : Form
    {
        private string stringWhere = string.Empty;
        private string stringRestriccion = string.Empty;

        public frm_ListadoSurtidores()
        {
            InitializeComponent();
        }

        private void frm_ListadoSurtidores_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            cargarCombos();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ArmarStringFiltros();
            buscarSurtidores();


        }

        private void buscarSurtidores()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string consulta = "select S.numeroSurtidor as 'numSurtidor', E.razonSocial as 'estacion' , Estado.nombre as 'estado', TC.nombre as 'tipoCombustible'"
                                    + "from Surtidor S join Estado on S.idEstado = Estado.idEstado "
                                                    + "join Estacion E on S.cuit = E.CUIT "
                                                    + "join TipoCombustible TC on S.idTipoCombustible = TC.idTipoCombustible "
                                    + stringWhere;

                DataTable tablaSurtidores = conexion.ejecutar_consulta(consulta);
                ReportDataSource ds = new ReportDataSource("DatosSurtidores", tablaSurtidores);

                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("restriccion", "");
                reportViewer1.LocalReport.SetParameters(parametros);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
                stringWhere = string.Empty;
            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
            }
        }

        private void ArmarStringFiltros()
        {
            if (cmb_Estado.SelectedIndex != -1)
            {
                if (stringWhere == string.Empty)
                {
                    stringWhere = "WHERE Estado.idEstado = " + cmb_Estado.SelectedValue;
                    stringRestriccion = "Estado = " + cmb_Estado.Text;
                }
                else
                {
                    //stringWhere += " AND Estado.idEstado = " + cmb_Estado.SelectedValue;
                    //stringRestriccion += " | Estado = " + cmb_Estado.Text;
                }
            }
            if (cmb_Estacion.SelectedIndex != -1)
            {
                if (stringWhere == string.Empty)
                {
                    stringWhere = "WHERE E.CUIT = " + cmb_Estacion.SelectedValue;
                    stringRestriccion = "Estacion = " + cmb_Estacion.Text;
                }
                else
                {
                    stringWhere += " AND E.CUIT = " + cmb_Estacion.SelectedValue;
                    stringRestriccion += " | Estacion = " + cmb_Estacion.Text;
                }
            }
            if (cmb_TipoCombustible.SelectedIndex != -1)
            {
                if (stringWhere == string.Empty)
                {
                    stringWhere = "WHERE TC.idTipoCombustible = " + cmb_TipoCombustible.SelectedValue;
                    stringRestriccion = " Tipo de Combustible = " + cmb_TipoCombustible.Text;
                }
                else
                {
                    stringWhere += " AND TC.idTipoCombustible = " + cmb_TipoCombustible.SelectedValue;
                    stringRestriccion += " | Tipo de Combustible = " + cmb_TipoCombustible.Text;
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

            // ESTADOS
            cmb_Estado.DataSource = buscarEstados();
            cmb_Estado.DisplayMember = "nombre";
            cmb_Estado.ValueMember = "idEstado";
            cmb_Estado.SelectedIndex = -1;

            // TIPO COMBUSTIBLES
            cmb_TipoCombustible.DataSource = buscarTipoCombustibles();
            cmb_TipoCombustible.DisplayMember = "nombre";
            cmb_TipoCombustible.ValueMember = "idTipoCombustible";
            cmb_TipoCombustible.SelectedIndex = -1;
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

        private DataTable buscarEstados()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string sql = "SELECT * FROM Estado";
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

        private DataTable buscarTipoCombustibles()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string sql = "SELECT * FROM TipoCombustible";
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

        private void button1_Click(object sender, EventArgs e)
        {
            stringWhere = string.Empty;
            stringRestriccion = string.Empty;

            ArmarStringFiltros();
            buscarSurtidores();
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            reportViewer1.LocalReport.SetParameters(parametros);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmb_Estacion.SelectedIndex = -1;
            cmb_Estado.SelectedIndex = -1;
            cmb_TipoCombustible.SelectedIndex = -1;
            stringWhere = string.Empty;
            stringRestriccion = string.Empty;
            buscarSurtidores();
        }
    }

}
