using DAL;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace BLL
{
    public class UsuarioGestor
    {
        DALUsuario bd;

        public UsuarioGestor()
        {
            bd = new DALUsuario();
        }

        public void Alta(Usuario user)
        {
            CalcularDVH(user);
            bd.Alta(user);
        }

        public void Modificar(Usuario user)
        {
            CalcularDVH(user);
            bd.Modificar(user);
        }

        public void Baja(Usuario user)
        {
            bd.Baja(user);
        }

        public Usuario Buscar(Usuario user)
        {
            return bd.GetUsuario(user);
        }

        public List<Usuario> GetListUsuario()
        {
            return bd.GetListUsuario();
        }

        public void CalcularDVH(Usuario user)
        {
            ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
            string ParcialHash = controlDeAccesoGestor.GetHash(user.NombreUsuario + user.Contraseña + user.Nombre + user.Apellido + user.Rol.Id);
            user.DVH = ParcialHash;
        }
    }
}


