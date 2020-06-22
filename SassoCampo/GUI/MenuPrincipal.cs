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

        public MenuPrincipal(Form form, Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            logIn = form;
        }

        Controller controller;
        Form logIn;

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lbl_NombreUsuario.Text = controller.ControlDeAcceso.UsuarioActual.NombreUsuario;
            lbl_NombreYApellido.Text = controller.ControlDeAcceso.UsuarioActual.Nombre + "" + controller.ControlDeAcceso.UsuarioActual.Apellido;
            lbl_Rol.Text = controller.ControlDeAcceso.UsuarioActual.Rol.Nombre;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.LogOut();
            this.Hide();
            logIn.Show();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.AltaUsuario();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ModificarUsuario();
        }

        private void darDeBajaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.BajaUsuario();
        }

        private void darPermisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.DarPermiso();
        }

        private void quitarPermisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.QuitarPermiso();
        }

        private void btn_IrAreaTejido_Click(object sender, EventArgs e)
        {
            AreaTejidoMenu menu = new AreaTejidoMenu(this, controller);
            this.Hide();
            menu.Show();
        }
    }
}
