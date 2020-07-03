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

        //TODO: Aplicar dígitos verticales y horizontales. (Preguntar).
        //TODO: Aplicar los ABMS de productos y procesos.
        //TODO: Implementar Tejido, Teñido, Corte, Confeccion.

        //TODO: Modificar el CU de Solicitar Producto para que se puedan comprar en vez de solo fabricarlos.
        //TODO: Adaptar el Modelo de Clases a CAPAS bien implementadas.
    }
}
