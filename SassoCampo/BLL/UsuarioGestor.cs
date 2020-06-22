using DAL;

namespace BLL
{
    public class UsuarioGestor
    {
        AccesoADatos bd;

        public UsuarioGestor()
        {
            bd = new AccesoADatos();
        }

        public void Alta(Usuario user)
        {
            bd.AltaUsuario(user);
        }

        public void Modificar(Usuario user)
        {
            bd.ModificarUsuario(user);
        }

        public void Baja(Usuario user)
        {
            bd.BajaUsuario(user);
        }
    }
}


