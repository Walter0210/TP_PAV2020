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
        private int indice2;
        public frm_OrdenCompra()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void LimpiarCampos(GroupBox grupo)
        {
            foreach (Control ctr in grupo.Controls)
            {
                if (ctr is MaskedTextBox || ctr is TextBox)
                {
                    ctr.ResetText();
                }
                else if (ctr is ComboBox)
                {
                    ((ComboBox)ctr).SelectedIndex = -1;
                }
            }
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
            string sql = "SELECT  E.nombre + ' ' + E.apellido as 'ApeNom', E.legajo FROM Empleado E";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            cmbEmpleado.DataSource = tabla;
            cmbEmpleado.DisplayMember = "ApeNom";
            cmbEmpleado.ValueMember = "legajo";
            cmbEmpleado.SelectedIndex = -1;
        }
        private void CargarComboUrgencia()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Urgencia";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            cmbUrgencia.DataSource = tabla;
            cmbUrgencia.DisplayMember = "nombre";
            cmbUrgencia.ValueMember = "idUrgencia";
            cmbUrgencia.SelectedIndex = -1;
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
            Form form = this.Parent.FindForm();
            form.Width = this.Width + 300;

            CargarComboEstacion();
            CargarComboProductos();
            CargarComboUnidadMedida();
            CargarComboEmpleados();
            CargarComboUrgencia();

            //BUSCAR EL NRO DE ORDEN DE ORDEN
            
            btnEliminarProducto.Enabled = false;
            btnModificarProducto.Enabled = false;
        }
        private void CompletarCombos()
        {
            DataGridViewRow fila = dgrDetalleOC.Rows[indice2];

            cmbProducto.SelectedValue = fila.Cells["producto"].Value;
            txtBoxCantidad.Text = fila.Cells["cantidad"].Value.ToString();
            cmbUnidadMedida.SelectedValue = fila.Cells["uniMedida"].Value;
            txtBoxPrecio.Text = fila.Cells["precio"].Value.ToString();
            cmbUrgencia.SelectedValue = fila.Cells["idUrgencia"].Value;
        }

        private void dgrDetalleOC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice2 = e.RowIndex;
            if (indice2 != -1)
            {
                LimpiarCampos(groupBoxProductos);
                btnModificarProducto.Enabled = true;
                btnEliminarProducto.Enabled = true;
                btnAgregarProducto.Enabled = false;
                CompletarCombos();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbEmpleado.SelectedIndex != -1 && cmbEstacion.SelectedIndex != -1)
            {
                OrdenCompra nuevaOrden = new OrdenCompra(int.Parse(txtBoxNroOrden.Text), dateTimePicker1.Value, (int)cmbEmpleado.SelectedValue, (int)cmbEstacion.SelectedValue);
                if (cmbProducto.SelectedIndex != -1 && txtBoxCantidad.Text != "" && cmbUnidadMedida.SelectedIndex != -1 && cmbUnidadMedida.SelectedIndex != -1)
                {

                    groupBoxDatosOC.Enabled = false;
                    int nroOrdenCompra = int.Parse(txtBoxNroOrden.Text);
                    int idProducto = (int)cmbProducto.SelectedValue;
                    int cantidad = int.Parse(txtBoxCantidad.Text);
                    int idUnidadMedida = (int)cmbUnidadMedida.SelectedValue;
                    float precio = float.Parse(txtBoxPrecio.Text);
                    int idUrgencia = (int)cmbUrgencia.SelectedValue;

                    dgrDetalleOC.Rows.Add(nroOrdenCompra, idProducto, cantidad, idUnidadMedida, precio, idUrgencia);
                    //txtBoxCantidad.Focus();
                    CalcularTotal();
                    LimpiarCampos(groupBoxProductos);
                }
                else
                {
                    MessageBox.Show("Los datos del producto a pedir están incompletos!");
                }
            }
            else
            {
                MessageBox.Show("Primero debe completar los datos de la Orden de Compra!");
            }
        }

        private void cmbProducto_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex != -1)
            {
                ConexionBD conexion = new ConexionBD();
                string sql = "SELECT precioCompra FROM Producto WHERE idProducto = " + cmbProducto.SelectedValue;
                DataTable tabla = conexion.ejecutar_consulta(sql);
                txtBoxPrecio.Text = tabla.Rows[0]["precioCompra"].ToString();
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (indice2 != -1)
            {
                dgrDetalleOC.Rows.RemoveAt(indice2);
                LimpiarCampos(groupBoxProductos);
                CalcularTotal();
                btnAgregarProducto.Enabled = true;
            }
        }

        private void CalcularTotal()
        {
            int total = 0;
            foreach (DataGridViewRow r in dgrDetalleOC.Rows)
                {
                total += Convert.ToInt32(r.Cells["precio"].Value) * Convert.ToInt32(r.Cells["cantidad"].Value);
                }
            lblTotalCalculado.Text = total.ToString();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            int nroOrdenCompra = int.Parse(txtBoxNroOrden.Text);
            int idProducto = (int)cmbProducto.SelectedValue;
            int cantidad = int.Parse(txtBoxCantidad.Text);
            int idUnidadMedida = (int)cmbUnidadMedida.SelectedValue;
            float precio = float.Parse(txtBoxPrecio.Text);
            int idUrgencia = (int)cmbUrgencia.SelectedValue;

            dgrDetalleOC.Rows[indice2].SetValues(nroOrdenCompra, idProducto, cantidad,idUnidadMedida, precio, idUrgencia);

            CalcularTotal();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Armar detalles

            //llamar acceso a datos pasando los objetos
        }


    }
}
