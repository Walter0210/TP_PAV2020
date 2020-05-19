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
    public partial class frm_OrdenCompra : Form
    {

        public frm_OrdenCompra()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
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
        private void CargarComboProductos()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Producto";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            cmbProducto.DataSource = tabla;
            cmbProducto.DisplayMember = "descripcion";
            cmbProducto.ValueMember = "idProducto";
            cmbProducto.SelectedIndex = -1;
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
        private void CargarComboEmpleados()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Empleado";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            cmbEmpleado.DataSource = tabla;
            cmbEmpleado.DisplayMember = "nombre";
            cmbEmpleado.ValueMember = "legajo";
            cmbEmpleado.SelectedIndex = -1;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult volver = MessageBox.Show("Volver al menú principal", "Esta seguro que desea volver?", MessageBoxButtons.YesNo);
            if (volver == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {
                //Hola
            }

        }

        private void frm_OrdenCompra_Load(object sender, EventArgs e)
        {
            //this.Parent.Parent.MinimumSize = this.MinimumSize;
            Form form = this.Parent.FindForm();
            form.Width = this.Width + 300;

            CargarComboEstacion();
            CargarComboProductos();
            CargarComboUnidadMedida();
            CargarComboEmpleados();
        }
    }
}
