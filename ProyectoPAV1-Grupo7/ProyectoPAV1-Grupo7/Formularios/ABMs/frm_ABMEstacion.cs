using ProyectoPAV1_Grupo7.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV1_Grupo7.Formularios
{
    public partial class frm_ABMEstacion : Form
    {

        public frm_ABMEstacion()
        {
            InitializeComponent();
        }
        
        //boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Inicio de VENTANA
        private void frm_ABMEstacion_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            CargarGrilla();
        }

        //FUNCION LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtBoxCalle.Text = "";
            txtBoxCuit.Text = "";
            txtBoxNumero.Text = "";
            txtBoxRazonSocial.Text = "";
        }

        //FUNCION CARGAR GRILLA
        private void CargarGrilla()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT CUIT , razonSocial FROM Estacion";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrEstacion.DataSource = tabla;

        }

        //BOTON LIMPIAR CAMPOS
        private void bynLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //Control De existencia de estacion.
        private bool ExisteEstacion(int Criterio)
        {
            bool resultado = false;
            for (int i = 0; i < dgrEstacion.Rows.Count; i++)
            {
                if (dgrEstacion.Rows[i].Cells["Cuit"].Value.Equals(Criterio))
                {
                    resultado = true;
                    MessageBox.Show("Ya existe una estacion con ese CUIT");
                    break;

                }
            }
            return resultado;

        }

        //Guardar en base de datos.
        private bool GuardarEstacionBD(Estacion estacion)
        {
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "INSERT INTO Estacion VALUES ('"+ estacion.Cuit+"','"+ estacion.RazonSocial+"','"+ estacion.Calle+"','"+ estacion.Nro +"','"+estacion.FechaHabilitacion+"' )";
                
                conexion.insertar(sql);
                
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar datos de persona: Base de datos corrompida");
            }
            return resultado;
        }

        //BOTON GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estacion estacion = ObtenerDatosEstacion();
            if (CargoCampos(estacion) && ExisteEstacion(estacion.Cuit).Equals(false))
            {
                bool resultado = GuardarEstacionBD(estacion);
                if (resultado)
                {
                    MessageBox.Show("Estacion cargada con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    txtBoxCuit.Focus();
                }
            }
            
        }

        //OBTENER DATOS DE LOS CAMPOS DE TEXTO
        private Estacion ObtenerDatosEstacion()
        {
            //VARIABLES DE CONTROL
            string CUIT = txtBoxCuit.Text.Trim();
            string razonSocial = txtBoxRazonSocial.Text.Trim();
            string calle = txtBoxRazonSocial.Text.Trim();
            string numero = txtBoxNumero.Text.Trim();
            DateTime fechaHabilitacion = DateTime.Parse(dtFechaAta.Text);
            if (CUIT.Equals("") || numero.Equals(""))
            {
                CUIT = "0";
                numero = "0";
            }
            Estacion est = new Estacion(int.Parse(CUIT), razonSocial, calle, int.Parse(numero), fechaHabilitacion);

            return est;
        }

        //Valida datos obligatorios
        private bool CargoCampos(Estacion estacion)
        {
            bool resultado = true;
            if (estacion.Cuit.Equals(0) || estacion.RazonSocial.Equals(0) || estacion.Calle.Equals(""))
            {
                resultado = false;
                MessageBox.Show("CUIT, razon social y calle son obligatorios");

            }

            return resultado;
        }
    }
}
