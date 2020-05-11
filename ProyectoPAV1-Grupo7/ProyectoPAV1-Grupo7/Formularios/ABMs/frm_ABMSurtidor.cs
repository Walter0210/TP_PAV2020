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

            string sql = string.Format("SELECT S.numeroSurtidor, E.razonSocial, Es.nombre, TC.nombre " +
                "FROM Surtidor S JOIN Estacion E ON S.cuit = E.CUIT " +
                "JOIN Estado Es ON S.idEstado = Es.idEstado " +
                "JOIN TipoCombustible TC ON S.idTipoCombustible = TC.idTipoCombustible");

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
            
            //int nroSurtidor = int.Parse(txtBoxNroSurtidor.Text);
            int cuit = (int)cmbCuilEstacion.SelectedValue;
            int idEstado = (int)cmbEstado.SelectedValue;
            int idTipoCombustible = (int)cmbTipoCombustible.SelectedValue;

            //Surtidor sur = new Surtidor(nroSurtidor, cuit, idEstado, idTipoCombustible);
            Surtidor sur = new Surtidor(cuit, idEstado, idTipoCombustible);

            return sur;
        }

        private Surtidor ObtenerSurtidor(int numeroSurtidor)
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Surtidor WHERE numeroSurtidor = " + numeroSurtidor.ToString();
            DataTable tabla = conexion.ejecutar_consulta(sql);

            txtBoxNroSurtidor.Text = tabla.Rows[0]["numeroSurtidor"].ToString();
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
            bool resultado = InsertarSurtidor(surtidor);
            if (resultado)
            {
                MessageBox.Show("Estacion cargada con exito");
                LimpiarCampos();
                CargarGrilla();
                txtBoxNroSurtidor.Focus();
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
            if (indice != -1)
            {
                LimpiarCampos();
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;

                DataGridViewRow fila = dgrSurtidor.Rows[indice];
                int nroSurtidor = (int)fila.Cells["nroSurtidor"].Value;
                Surtidor surtidor = ObtenerSurtidor(nroSurtidor);
                CargarCampos(surtidor);
            }
        }

        private void CargarCampos(Surtidor surtidor)
        {
            cmbCuilEstacion.SelectedValue = surtidor.CUIT;
            cmbEstado.SelectedValue = surtidor.IdEstado;
            cmbTipoCombustible.SelectedValue = surtidor.IdTipoComb;
        }

        private bool ActualizarSurtidorBD(Surtidor surtidor)
        {
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "UPDATE Surtidor SET cuit=" + surtidor.CUIT + ", idEstado =" + surtidor.IdEstado + ", idTipoCombustible=" + surtidor.IdTipoComb + "WHERE numeroSurtidor=" + surtidor.NroSurtidor;

                conexion.modificar(sql);

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar datos de persona: Base de datos corrompida");
            }
            return resultado;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Surtidor surtidor = ArmarSurtidor();
            surtidor.NroSurtidor = int.Parse(txtBoxNroSurtidor.Text);
            bool resultado = ActualizarSurtidorBD(surtidor);
            if (resultado)
            {
                MessageBox.Show("Estacion Modificada con exito");
                LimpiarCampos();
                CargarGrilla();
            }
            btnGuardar.Enabled = true;
        }

        //Borrar estacion de base de datos
        private bool BorrarSurtidorBD(Surtidor surtidor)
        {
            surtidor.NroSurtidor = int.Parse(txtBoxNroSurtidor.Text);
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "DELETE FROM Surtidor WHERE numeroSurtidor= " + surtidor.NroSurtidor;
                conexion.borrar(sql);
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo ejecutar la operacion. F");
            }
            return resultado;
        }

        //CLICK boton Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Surtidor surtidor = ArmarSurtidor();
            bool resultado = BorrarSurtidorBD(surtidor);
            if (resultado)
            {
                MessageBox.Show("Estacion Eliminada con exito");
                LimpiarCampos();
                CargarGrilla();
            }
        }
    }
}
