using System.Windows.Forms;

namespace GUI
{
    class Controller
    {
        Form form;
        ControlDeAcceso controlDeAcceso = new ControlDeAcceso();

        public Controller(Form formulario)
        {
            form = formulario;
        }

        public string LogIn()
        {
            ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
            if (controlDeAccesoGestor.LogIn(GetNombreUsuario(), GetContraseña()))
            {
                controlDeAcceso.UsuarioActual = controlDeAccesoGestor.GetUsuario(GetNombreUsuario());
                if (controlDeAcceso.UsuarioActual != null)
                {
                    controlDeAcceso.GetInstance();
                }
                return "Inicio de sesión correcto";
            }
            return "Inicio de sesión fallido";
        }

        public void LogOut()
        {
            controlDeAcceso.UsuarioActual = null;
        }

        public string GetNombreUsuario()
        {
            return (form.Controls["gbox_LogIn"].Controls["txt_NombreUsuario"] as TextBox).Text;
        }

        public string GetContraseña()
        {

            return (form.Controls["gbox_LogIn"].Controls["txt_Contraseña"] as TextBox).Text;
        }
    }
}
