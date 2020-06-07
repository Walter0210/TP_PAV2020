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

namespace ProyectoPAV1_Grupo7.Formularios
{
    public partial class frm_Menu : Form
    {
        ConexionBD cn = new ConexionBD();

        public frm_Menu()
        {
            InitializeComponent();
            openChildForm(new Procesos.frm_Compra());
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            subPanel_empleado.Visible = false;
            subPanel_producto.Visible = false;
            openChildForm(new Procesos.frm_Compra());
        }

        private void hideSubMenu()
        {
            subPanel_empleado.Visible = false;
            subPanel_producto.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            } else
            {
                subMenu.Visible = false;
            }

        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            showSubMenu(subPanel_empleado);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            openChildForm(new Procesos.frm_ConsultaCompra());
            hideSubMenu();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //codigo
            hideSubMenu();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            openChildForm(new Procesos.frm_Compra());
            hideSubMenu();
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            //codigo
            showSubMenu(subPanel_producto);
        }

        private void btn_nuevo_prod_Click(object sender, EventArgs e)
        {
            openChildForm(new Procesos.frm_OrdenCompra());
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_ConsultaOrdenCompra());
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //codigo
            hideSubMenu();
        }

        private Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void surtidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.ABMs.frm_ABMSurtidor frm_ABMSurtidor = new ABMs.frm_ABMSurtidor();
            frm_ABMSurtidor.ShowDialog();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.ABMs.frm_ABMProducto frm_ABMProducto = new ABMs.frm_ABMProducto();
            frm_ABMProducto.ShowDialog();
        }

        private void estaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frm_ABMEstacion frm_ABMEstacion = new frm_ABMEstacion();
            frm_ABMEstacion.ShowDialog();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.ABMs.frm_ABMSoporte frm_AMBSoporte = new ABMs.frm_ABMSoporte("Estado");
            frm_AMBSoporte.ShowDialog();
         
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frm_ABMEmpleado frm_Empleado = new frm_ABMEmpleado();
            frm_Empleado.ShowDialog();

        }

        private void nivelDeUrgeciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.ABMs.frm_ABMSoporte frm_ABMSoporte = new ABMs.frm_ABMSoporte("Urgencia");
            frm_ABMSoporte.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tipoDeCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.ABMs.frm_ABMSoporte frm_ABMSoporte = new ABMs.frm_ABMSoporte("TipoCombustible");
            frm_ABMSoporte.ShowDialog();
        }

        private void unidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.ABMs.frm_ABMSoporte frm_ABMSoporte = new ABMs.frm_ABMSoporte("UnidadMedida");
            frm_ABMSoporte.ShowDialog();
        }

        private void tipoDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.ABMs.frm_ABMSoporte frm_ABMSoporte = new ABMs.frm_ABMSoporte("TipoDocumento");
            frm_ABMSoporte.ShowDialog();
        }

        private void listadoOrdenesToolStripItem_Click(object sender, EventArgs e)
        {
            Formularios.Reportes.frm_ListadoOrdenesCompra frm_ListadoOrdenesCompra = new Reportes.frm_ListadoOrdenesCompra();
            frm_ListadoOrdenesCompra.ShowDialog();
        }

        private void estadisticaOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Reportes.frm_EstadisticaOrdenesCompra frm_EstadisticaOrdenesCompra = new Reportes.frm_EstadisticaOrdenesCompra();
            frm_EstadisticaOrdenesCompra.ShowDialog();
        }
    }
}
