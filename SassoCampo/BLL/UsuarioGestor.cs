using DAL;
using System.Collections.Generic;

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

        public Usuario Buscar(Usuario user)
        {
            return bd.GetUsuario(user);
        }

        public List<Usuario> GetListUsuario()
        {
            return bd.GetListUsuario();
        }
    }
}


