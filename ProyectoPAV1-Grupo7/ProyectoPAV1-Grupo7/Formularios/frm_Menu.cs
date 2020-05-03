﻿using ProyectoPAV1_Grupo7.Clases;
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
            openChildForm(new frm_Empleado());
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
    }
}
