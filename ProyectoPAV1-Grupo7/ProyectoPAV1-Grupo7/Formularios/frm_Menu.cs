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
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            subPanel_empleado.Visible = false;
            subPanel_producto.Visible = false;
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
            openChildForm(new frm_ABMEmpleado());
            hideSubMenu();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //codigo
            hideSubMenu();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //codigo
            hideSubMenu();
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            showSubMenu(subPanel_producto);
        }

        private void btn_nuevo_prod_Click(object sender, EventArgs e)
        {
            //codigo
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //codigo
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //codigo
            hideSubMenu();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
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

        private void btnNivelUrgencia_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {

        }

        private void nivelDeUrgeciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.ABMs.frm_ABMSoporte frm_ABMSoporte = new ABMs.frm_ABMSoporte("Urgencia");
            frm_ABMSoporte.ShowDialog();
        }
    }
}
