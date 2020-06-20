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
            MessageBox.Show(controller.LogIn());
        }

        // TAREAS DE HOY.
        //TODO: Hacer que al tener un inicio exitoso de sesión te lleve al form del menu principal.
        //TODO: Agregar botón de log out, que lleve desde el menu principal al form de inicio de sesión.
        //TODO: Verificar que los roles y permisos se cargen bien. Comprobar que se puedan cargar más de
        // 1 permiso a un rol, si no se puede modificar la base de datos, después pasarlo directamnete a DER.
        //TODO: Aplicar Hash, dígitos verticales y horizontales.
        // TODO Deseable: Aplicar por lo menos los ABMS de productos y procesos e implementar Tejido.

        //TAREAS DE MAÑANA
        //TODO: Si no se hizo lo deseable, hacerlo.
        //TODO: Implementar Teñido, Corte y Confección.
        //TODO: Modificar el CU de Solicitar Producto para que se puedan comprar en vez de solo fabricarlos.
        //TODO: Adaptar el Modelo de Clases a CAPAS bien implementadas.
        //TODO:
    }
}
