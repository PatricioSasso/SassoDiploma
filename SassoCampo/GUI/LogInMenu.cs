using BE;
using BLL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class LogInMenu : Form
    {
        public LogInMenu()
        {
            InitializeComponent();
        }
        
        Controller controller;

        private void LogInMenu_Load(object sender, EventArgs e)
        {
            controller = new Controller(this);
            DVVGestor dVVGestor = new DVVGestor();
            if(!dVVGestor.VerificarDVV(new DVV("Usuario", "")))
            {
                throw new Exception("La tabla Usuariod de la base de datos fue modificada desde fuera de la aplicación");
            }
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controller.LogIn(txt_NombreUsuario.Text, txt_Contraseña.Text));
        }
    }
}
