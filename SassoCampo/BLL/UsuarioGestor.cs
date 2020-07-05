using DAL;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Policy;

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
            CalcularDVH(user);
            bd.AltaUsuario(user);
        }

        public void Modificar(Usuario user)
        {
            CalcularDVH(user);
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

        public void CalcularDVH(Usuario user)
        {
            ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
            string ParcialHash = controlDeAccesoGestor.GetHash(user.NombreUsuario + user.Contraseña + user.Nombre + user.Apellido + user.Rol.Id);
            user.DVH = ParcialHash;
        }
    }
}


