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
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controller.LogIn(txt_NombreUsuario.Text, txt_Contraseña.Text));
        }
    }
}
