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
using ProyectoPAV1_Grupo7;

namespace ProyectoPAV1_Grupo7
{
    public partial class frm_ConsultaOrdenCompra : Form
    {
        int OrdenSeleccionada = 0;
        int DetalleSeleccionado = 0;
        int CantidadSeleccionada = 0;

        public frm_ConsultaOrdenCompra()
        {
            InitializeComponent();
            //OrdenCompra OrdenSeleccionada = new OrdenCompra();
            //DetalleOC DetalleSeleccionado = new DetalleOC();
            

        }

        private void frm_ConsultaOrdenCompra_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            ConexionBD conexion = new ConexionBD();

            string sql = string.Format("SELECT OC.numeroOrdenCompra , OC.fecha, E.nombre + E.apellido AS apenom, S.razonSocial, OC.total" +
                " FROM OrdenCompra OC JOIN Empleado E ON OC.legajo = E.legajo " +
                "JOIN Estacion S ON OC.cuitSolicitante = S.CUIT ");

            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrOrdenCompra.DataSource = tabla;

        }

        private void dgrOrdenCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if(indice != -1)
            {
                
                DataGridViewRow fila = dgrOrdenCompra.Rows[indice];
                string numOrden = fila.Cells["Numero"].Value.ToString();
                OrdenSeleccionada = int.Parse(numOrden);
                CargarGrilla2(numOrden);

            }
        }

        private void dgrDetallesOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice != -1)
            {
                DataGridViewRow fila = dgrDetallesOrden.Rows[indice];
                string numDetalle = fila.Cells["idProducto"].Value.ToString();
                MessageBox.Show(numDetalle);
                string cantidad = fila.Cells["Cantidad"].Value.ToString();
                MessageBox.Show(cantidad);
                DetalleSeleccionado = int.Parse(numDetalle);
                CantidadSeleccionada = int.Parse(cantidad);
            }
        }

        private void CargarGrilla2(string numOrden)
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT DC.numOrdenCompra, P.descripcion, P.idProducto, DC.cantidad, UM.nombre, P.precioCompra * DC.cantidad AS precitotal, UR.nombre"
                + " FROM DetalleOrdenCompra DC "
                + "JOIN Producto P ON DC.idProducto = P.idProducto "
                + "JOIN UnidadMedida UM ON DC.idUnidadMedida = UM.idUnidadMedida "
                + "JOIN Urgencia UR ON DC.idUrgencia = UR.idUrgencia " +
                "WHERE DC.numOrdenCompra = '" + numOrden + "'";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrDetallesOrden.DataSource = tabla;

        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            //(MessageBox.Show("Usted seleccionó Orden de Compra: " + OrdenSeleccionada + ", Detalle: " + DetalleSeleccionado + ", Cantidad: " + CantidadSeleccionada);
            
            try
            {
                ConexionBD conexion = new ConexionBD();
                string consulta = "SELECT P.stockActual FROM Producto P WHERE P.idProducto like '"+DetalleSeleccionado+"'";
                DataTable stockActualProducto = conexion.ejecutar_consulta(consulta);
                int stockActual = int.Parse(stockActualProducto.Rows[0][0].ToString());
                MessageBox.Show("Stock actual producto: " + stockActual);
                int nuevaCantidad = stockActual + CantidadSeleccionada;
                string sql = "UPDATE Producto SET stockActual = " + nuevaCantidad + " WHERE idProducto = " + DetalleSeleccionado;
                conexion.ejecutar_consulta(sql);
            } catch (Exception)
            {
                MessageBox.Show("error");
            }

            
            
            
            

        }

        
    }
}
