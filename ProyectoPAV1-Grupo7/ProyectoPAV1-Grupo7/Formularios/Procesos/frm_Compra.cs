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

namespace ProyectoPAV1_Grupo7.Formularios.Procesos
{
    public partial class frm_Compra : Form
    {
        public frm_Compra()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarComboEstacion()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Estacion";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            cmbEstacion.DataSource = tabla;
            cmbEstacion.DisplayMember = "razonSocial";
            cmbEstacion.ValueMember = "CUIT";
            cmbEstacion.SelectedIndex = -1;
        }

        private void CargarComboUnidadMedida()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM UnidadMedida";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            cmbUnidadMedida.DataSource = tabla;
            cmbUnidadMedida.DisplayMember = "nombre";
            cmbUnidadMedida.ValueMember = "idUnidadMedida";
            cmbUnidadMedida.SelectedIndex = -1;
        }

        private void CargarComboSurtidor()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Surtidor";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            cmbSurtidor.DataSource = tabla;
            cmbSurtidor.DisplayMember = "NroSurtidor";
            cmbSurtidor.ValueMember = "CUIT";
            cmbSurtidor.SelectedIndex = -1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblResponsable_Click(object sender, EventArgs e)
        {

        }

        private void frm_Compra_Load(object sender, EventArgs e)
        {
            CargarComboEstacion();
            CargarComboUnidadMedida();
            CargarComboSurtidor();

        }

        private Ticket ObtenerDatosTicket()
        {

            //VARIABLES DE CONTROL
            int estacion = (int)cmbEstacion.SelectedValue;
            int surtidor = (int)cmbSurtidor.SelectedValue;
            int cantVendida = int.Parse(tbCantidad.Text);
            int uniMedida = (int)cmbUnidadMedida.SelectedValue;

            Ticket ticket = new Ticket();

            return ticket;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbEstacion.SelectedIndex != -1 || cmbSurtidor.SelectedIndex != -1 || cmbUnidadMedida.SelectedIndex != -1)
            {
                // Empleado empleado = ObtenerDatosEmpleado();
                    // GuardarEmpleadoBDbool resultado = (empleado);

                    if (resultado)
                    {
                        MessageBox.Show("Compra cargada con exito");
                    }
                
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos");
            }
        }
    }
}
