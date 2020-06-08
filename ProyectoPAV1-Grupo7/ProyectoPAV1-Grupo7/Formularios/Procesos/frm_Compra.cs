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
        private Ticket nuevoTicket;
        private int numeroNuevoTicket;
        private int indiceActual;

        public frm_Compra()
        {
            InitializeComponent();
        }
        private void BuscarnroTicket()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "select MAX(numTicket) as ultimoTicket " +
                "from Ticket";
          
            DataTable tabla = conexion.ejecutar_consulta(sql);
            numeroNuevoTicket = (int)tabla.Rows[0]["ultimoTicket"] + 1;

            txtBoxNroTicket.Text = numeroNuevoTicket.ToString();
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
            string sql = "SELECT * FROM Surtidor WHERE cuit = " + cmbEstacion.SelectedValue;
            DataTable tabla = conexion.ejecutar_consulta(sql);

            cmbSurtidor.DataSource = tabla;
            cmbSurtidor.DisplayMember = "numeroSurtidor";
            cmbSurtidor.ValueMember = "numeroSurtidor";
            cmbSurtidor.SelectedIndex = -1;
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

        private void frm_Compra_Load(object sender, EventArgs e)
        {
            //Form form = this.Parent.FindForm();
            //form.Width = this.Width + 300;
            //form.Height = this.Height + 50;

            BuscarnroTicket();
            

            CargarComboEstacion();
            CargarComboUnidadMedida();
            //CargarComboSurtidor(); Se hace despues de elegir la estacion
            CargarComboProductos();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbSurtidor.SelectedIndex != -1 && cmbEstacion.SelectedIndex != -1 && cmbUnidadMedida.SelectedIndex != -1 && txtBoxCantidadCombustible.Text != "")//Valida que primero complete los datos del ticket
            {   
                if (cmbProducto.SelectedIndex != -1 && txtBoxCantidad.Text != "")//Valida los datos del detalle
                {
                    if (ExisteProducto((int)cmbProducto.SelectedValue) == false)
                    {
                        grpTicket.Enabled = false;
                        cmbEstacion.Enabled = false;

                        int nroTicket = numeroNuevoTicket;
                        int idProducto = (int)cmbProducto.SelectedValue;
                        string cantidad = txtBoxCantidad.Text;
                        float precioxcantidad = float.Parse(txtBoxTotal.Text);

                        dgrTicketxProducto.Rows.Add(nroTicket, idProducto, cantidad, precioxcantidad);
                        
                        CalcularTotal();
                        LimpiarCampos(grpDetalle);
                    }
                }
                else
                {
                    MessageBox.Show("Los datos del producto!");
                }
            }
            else
            {
                MessageBox.Show("Primero debe completar los datos generales de la venta!");
            }

        }

        private void CalcularTotal()
        {
            int total = 0;
            //int cantidad = 0;
            foreach (DataGridViewRow r in dgrTicketxProducto.Rows)
            {
                total += Convert.ToInt32(r.Cells["precioxcantidad"].Value);
                //cantidad += Convert.ToInt32(r.Cells["cantidad"].Value);
            }
            lblTotalCalculado.Text = total.ToString();
            //lblCantidadVendida.Text = cantidad.ToString();
        }

        private bool ExisteProducto(int idProducto)
        {
            bool resultado = false;
            if (dgrTicketxProducto.Rows.Count > 0)
            {
                foreach (DataGridViewRow r in dgrTicketxProducto.Rows)
                {
                    if ((int)r.Cells["idProducto"].Value == idProducto && r.Index != indiceActual)
                    {
                        MessageBox.Show("Ya existe este producto en la lista!");
                        r.Selected = true;
                        //indiceActual = r.Index;
                        CompletarCombos(r.Index);
                        resultado = true;
                        break;
                    }
                    else
                    {
                        resultado = false;
                    }
                }
            }
            return resultado;
        }

        private void CompletarCombos(int indiceProducto)
        {
            DataGridViewRow fila = dgrTicketxProducto.Rows[indiceProducto];

            cmbProducto.SelectedValue = fila.Cells["idProducto"].Value;
            txtBoxCantidad.Text = fila.Cells["cantidad"].Value.ToString();
            txtBoxTotal.Text = fila.Cells["precioxcantidad"].Value.ToString();
        }

        private void cmbProducto_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex != -1)
            {
                ConexionBD conexion = new ConexionBD();
                string sql = "SELECT precioVenta FROM Producto WHERE idProducto = " + cmbProducto.SelectedValue;
                DataTable tabla = conexion.ejecutar_consulta(sql);
                lblPrecioUnitario.Text = tabla.Rows[0]["precioVenta"].ToString();
            }
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

        private void txtBoxCantidad_Leave(object sender, EventArgs e)
        {
            //test
        }

        private void txtBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            int totalVendido;
            if (txtBoxCantidad.Text != "")
            {
                totalVendido = int.Parse(txtBoxCantidad.Text.Trim()) * int.Parse(lblPrecioUnitario.Text);
                txtBoxTotal.Text = totalVendido.ToString();
            }
            else
            {
                txtBoxTotal.Text = "0";
            }
        }

        private void dgrTicketxProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceActual = e.RowIndex;
            if (indiceActual != -1)
            {
                LimpiarCampos(grpDetalle);
                btnModificarProducto.Enabled = true;
                btnEliminarProducto.Enabled = true;
                btnAgregarProducto.Enabled = false;
                CompletarCombos(indiceActual);
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (ExisteProducto((int)cmbProducto.SelectedValue) == false)
            {
                int nroTicket = numeroNuevoTicket;
                int idProducto = (int)cmbProducto.SelectedValue;
                int cantidad = int.Parse(txtBoxCantidad.Text);
                int precioxcantidad = int.Parse(txtBoxTotal.Text);
                dgrTicketxProducto.Rows[indiceActual].SetValues(nroTicket, idProducto, cantidad, precioxcantidad);

                CalcularTotal();
                LimpiarCampos(grpDetalle);
                btnAgregarProducto.Enabled = true;
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (indiceActual != -1)
            {
                dgrTicketxProducto.Rows.RemoveAt(indiceActual);
                LimpiarCampos(grpDetalle);
                CalcularTotal();
                btnAgregarProducto.Enabled = true;
            }
            if (dgrTicketxProducto.Rows.Count == 0)
            {
                grpTicket.Enabled = true;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (cmbEstacion.SelectedIndex != -1 && cmbSurtidor.SelectedIndex != -1 && cmbUnidadMedida.SelectedIndex != -1 && txtBoxCantidadCombustible.Text != "")
            {
                DialogResult volver = MessageBox.Show("Desea finalizar el proceso de venta?", "Finalizar Venta", MessageBoxButtons.YesNo);
                if (volver == DialogResult.Yes)
                {
                    int nro = numeroNuevoTicket;
                    DateTime fecha = dateTimePicker1.Value;
                    int cuit = (int)cmbEstacion.SelectedValue;
                    int surtidor = (int)cmbSurtidor.SelectedValue;
                    int cantidadComb = int.Parse(txtBoxCantidadCombustible.Text);
                    int unidadMedida = (int)cmbUnidadMedida.SelectedValue;
                    string observaciones = txtBoxObvs.Text.ToString();
                    nuevoTicket = new Ticket(nro, fecha, cuit, surtidor, cantidadComb, unidadMedida, observaciones);

                    ConexionBD conexion = new ConexionBD();
                    conexion.iniciar_transaccion();

                    InsertarTicket(nuevoTicket, conexion);

                    if (dgrTicketxProducto.Rows.Count != 0) //Valida que hayan detalles a insertar
                    {
                        foreach (DataGridViewRow r in dgrTicketxProducto.Rows)
                        {
                            int nroticket = (int)r.Cells["numeroTicket"].Value;
                            int idProducto = (int)r.Cells["idProducto"].Value;
                            string cantidad = r.Cells["cantidad"].Value.ToString();
                            float precio = (float)r.Cells["precioxcantidad"].Value;

                            TicketProducto nuevoDetalle = new TicketProducto(nroticket, idProducto, cantidad, precio);
                            InsertarDetalle(nuevoDetalle, conexion);
                            Producto productoSeleccionado = new Producto(idProducto);
                            int nuevaCantidad = int.Parse(cantidad);
                            productoSeleccionado.actualizarStockActualProducto(-nuevaCantidad);
                        }
                        //MessageBox.Show("La venta de productos se registró correctamente!");
                        //conexion.cerrar_transaccion();
                    }
                    MessageBox.Show("La venta de combustible se registró correctamente!");
                    conexion.cerrar_transaccion();

                    LimpiarCampos(grpDetalle);
                    LimpiarCampos(grpTicket);
                    txtBoxObvs.Clear();
                    grpTicket.Enabled = true;
                    VaciarGrilla(dgrTicketxProducto);
                    BuscarnroTicket();
                    cmbEstacion.Enabled = true;
                    lblTotalCalculado.Text = "0";
                }

            }
            else
            {
                MessageBox.Show("La informacion de la venta están vacios");
            }
        }

        private void VaciarGrilla(DataGridView dgrTicketxProducto)
        {
            foreach (DataGridViewRow row in dgrTicketxProducto.Rows)
            {
                dgrTicketxProducto.Rows.Remove(row);
            }
        }

        private void InsertarDetalle(TicketProducto nuevoDetalle, ConexionBD conexion)
        {
            try
            {
                string sql = "INSERT INTO TicketXProducto VALUES (" + nuevoDetalle.NroTicket + ", " + nuevoDetalle.IdProducto + ", " + nuevoDetalle.Cantidad + ", " + nuevoDetalle.Precio + ")";
                conexion.insertar(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al insertar los datos del ticket generado");
            }
        }

        private void InsertarTicket(Ticket nuevoTicket, ConexionBD conexion)
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            //bool resultado = false;

            try
            {
                string sql = "INSERT INTO Ticket VALUES ( '" + nuevoTicket.Fecha.ToString(format) + "', " + nuevoTicket.Cuit + ", " + nuevoTicket.NroSurtidor + ", " + nuevoTicket.Cantidad + ", " + nuevoTicket.IdUnidadMedida + ", '" + nuevoTicket.Observacion.ToString() + "')";
                conexion.insertar(sql);
                //resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al insertar detalles de productos");
            }
            //return resultado;
        }

        private void cmbEstacion_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbEstacion.SelectedIndex != -1)
            {
                CargarComboSurtidor();
                cmbSurtidor.Enabled = true;
            }
        }

        private void txtBoxCantidadCombustible_TextChanged(object sender, EventArgs e)
        {
            //Totoal por cantidad de combustible
        }

        private void dgrTicketxProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //NO VA
        }
    }
}
