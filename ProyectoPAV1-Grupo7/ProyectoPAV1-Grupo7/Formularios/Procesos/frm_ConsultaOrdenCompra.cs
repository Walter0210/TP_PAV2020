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

namespace ProyectoPAV1_Grupo7
{
    public partial class frm_ConsultaOrdenCompra : Form
    {
        public frm_ConsultaOrdenCompra()
        {
            InitializeComponent();
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
                CargarGrilla2(numOrden);

            }
        }
        private void CargarGrilla2(string numOrden)
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT DC.numOrdenCompra, P.descripcion, DC.cantidad, UM.nombre, P.precioCompra * DC.cantidad AS precitotal, UR.nombre"
                + " FROM DetalleOrdenCompra DC "
                + "JOIN Producto P ON DC.idProducto = P.idProducto "
                + "JOIN UnidadMedida UM ON DC.idUnidadMedida = UM.idUnidadMedida "
                + "JOIN Urgencia UR ON DC.idUrgencia = UR.idUrgencia " +
                "WHERE DC.numOrdenCompra = '" + numOrden + "'";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrDetallesOrden.DataSource = tabla;

        }

        // duplique la primera funcion para que sea publica y devuelva la tabla de tipo DataTable para usarlo en los reportes
        // en la otra funcion no permitia que sea static

        public static DataTable ObtenerListadoOrdenesCompra()
        {
            ConexionBD conexion = new ConexionBD();

            string sql = string.Format("SELECT OC.numeroOrdenCompra as numeroOrdenCompra, OC.fecha as fecha, E.nombre + E.apellido AS legajo, S.razonSocial as cuitSolicitante, OC.total as total" +
                " FROM OrdenCompra OC JOIN Empleado E ON OC.legajo = E.legajo " +
                "JOIN Estacion S ON OC.cuitSolicitante = S.CUIT ");


            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;

        }

        public static DataTable ObtenerListadoOrdenesCompraConFiltro(int solicitante)
        {
            ConexionBD conexion = new ConexionBD();

            string sql = string.Format("SELECT OC.numeroOrdenCompra as numeroOrdenCompra, OC.fecha as fecha, E.nombre + E.apellido AS legajo, S.razonSocial as cuitSolicitante, OC.total as total" +
                " FROM OrdenCompra OC JOIN Empleado E ON OC.legajo = E.legajo " +
                "JOIN Estacion S ON OC.cuitSolicitante = S.CUIT ");


            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;

        }

        public static DataTable ObtenerEstadisticaOrdenesCompra()
        {
            ConexionBD conexion = new ConexionBD();

            string sql = string.Format("SELECT OC.numeroOrdenCompra as nroOrdenCompra, COUNT(DC.idProducto) as cantidad" +
                " FROM OrdenCompra OC JOIN DetalleOrdenCompra DC ON OC.numeroOrdenCompra = DC.numOrdenCompra " +
                "GROUP BY OC.numeroOrdenCompra");

            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;

        }
    } 
}
