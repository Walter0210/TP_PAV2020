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

namespace ProyectoPAV1_Grupo7.Formularios.ABMs
{
    public partial class frm_ABMSurtidor : Form
    {
        public frm_ABMSurtidor()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtBoxNroSurtidor.Text = "";
            cmbCuilEstacion.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            cmbTipoCombustible.SelectedIndex = -1;
        }

        private void CargarGrilla()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Surtidor";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrSurtidor.DataSource = tabla;

        }

        private void CargarComboEstacion()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Estacion";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            
            cmbCuilEstacion.DataSource = tabla;
            cmbCuilEstacion.DisplayMember = "razonSocial";
            cmbCuilEstacion.ValueMember = "CUIT";
            cmbCuilEstacion.SelectedIndex = -1;
        }

        private void CargarComboEstados()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Estado";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            cmbEstado.DataSource = tabla;
            cmbEstado.DisplayMember = "nombre";
            cmbEstado.ValueMember = "idEstado";
            cmbEstado.SelectedIndex = -1;
        }

        private void CargarTipoCombustible()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM TipoCombustible";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            cmbTipoCombustible.DataSource = tabla;
            cmbTipoCombustible.DisplayMember = "nombre";
            cmbTipoCombustible.ValueMember = "idTipoCombustible";
            cmbTipoCombustible.SelectedIndex = -1;
        }


        //Valida que no haya otro surtidor EN LA GRILLA con el msimo numero.
        private bool ExisteSurtidor(int Criterio)
        {
            bool resultado = false;
            for (int i = 0; i < dgrSurtidor.Rows.Count; i++)
            {
                if (dgrSurtidor.Rows[i].Cells["nroSurtidor"].Value.Equals(Criterio))
                {
                    resultado = true;
                    MessageBox.Show("Ya existe este Numero de Surtidor en el sistema.");
                    break;

                }
            }
            return resultado;
        }

        //Insertar el objeto en base de datos.
        private bool InsertarSurtidor(Surtidor surtidor)
        {
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "INSERT INTO Surtidor VALUES ('" + surtidor.CUIT + "','" + surtidor.IdEstado + "','" + surtidor.IdTipoComb + "' )";

                conexion.insertar(sql);

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al insertar datos");
            }
            return resultado;
        }

        //Arma el nuevo objeto surtidor con los datos ingresados
        private Surtidor ArmarSurtidor()
        {
            //VARIABLES DE CONTROL
            //string nroSurtidor = txtBoxNroSurtidor.Text.Trim();
            int cuit = (int)cmbCuilEstacion.SelectedValue;
            int idEstado = (int)cmbEstado.SelectedValue;
            int idTipoCombustible = (int)cmbTipoCombustible.SelectedValue;

            //Surtidor sur = new Surtidor(int.Parse(nroSurtidor), cuit, idEstado, idTipoCombustible);
            Surtidor sur = new Surtidor(cuit, idEstado, idTipoCombustible);

            return sur;
        }

        private Surtidor ObtenerSurtidor(int numeroSurtidor)
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Surtidor WHERE numeroSurtidor like '" + numeroSurtidor + "'";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            int cuit = (int)tabla.Rows[0]["cuit"];
            int idEstado = (int)tabla.Rows[0]["idEstado"];
            int idTipoCombustible = (int)tabla.Rows[0]["idTipoCombustible"];

            Surtidor surtidor = new Surtidor(cuit, idEstado, idTipoCombustible);
            return surtidor;
        }

        //BOTON GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Surtidor surtidor = ArmarSurtidor();
            if (ExisteSurtidor(surtidor.NroSurtidor).Equals(false))
            {
                bool resultado = InsertarSurtidor(surtidor);
                if (resultado)
                {
                    MessageBox.Show("Estacion cargada con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    txtBoxNroSurtidor.Focus();
                }
            }

        }

        private void frm_ABMSurtidor_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            CargarGrilla();
            CargarComboEstacion();
            CargarComboEstados();
            CargarTipoCombustible();
        }

        private void dgrSurtidor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            LimpiarCampos();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            
            DataGridViewRow fila = dgrSurtidor.Rows[indice];
            int nroSurtidor = (int)fila.Cells["nroSurtidor"].Value;
            Surtidor surtidor = ObtenerSurtidor(nroSurtidor);
            CargarCampos(surtidor);
        }

        private void CargarCampos(Surtidor surtidor)
        {
            txtBoxNroSurtidor.Text = surtidor.NroSurtidor.ToString();
            cmbCuilEstacion.SelectedIndex = 1;
        }
    }
}
