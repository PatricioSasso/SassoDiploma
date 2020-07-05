using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal( Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        Controller controller;

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lbl_NombreUsuario.Text = controller.ControlDeAcceso.UsuarioActual.NombreUsuario;
            lbl_NombreYApellido.Text = controller.ControlDeAcceso.UsuarioActual.Nombre + " " + controller.ControlDeAcceso.UsuarioActual.Apellido;
            lbl_Rol.Text = controller.ControlDeAcceso.UsuarioActual.Rol.Nombre;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            controller.LogOut();
        }

        private void btn_IrAreaTejido_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(new AreaTejidoMenu(controller));
        }

        private void btn_GestionarUsuarios_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(new GestionUsuarios(this.controller));
        }

        private void btn_GestionarRoles_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(new GestionRoles(controller));
        }

        private void btn_AreaTeñido_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(new AreaTeñidoMenu(controller));
        }

        private void btn_AreaCortado_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(new AreaCortadoMenu(controller));
        }

        private void btn_AreaConfeccion_Click(object sender, EventArgs e)
        {
            controller.cambiarForm(new AreaConfeccionadoMenu(controller));
        }
    }
}
