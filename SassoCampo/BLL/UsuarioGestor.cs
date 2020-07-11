using DAL;
using Microsoft.VisualBasic.ApplicationServices;
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
            Usuario original = bd.GetUsuario(user);
            ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
            if (original.DVH == controlDeAccesoGestor.GetHash(original.NombreUsuario + original.Contraseña + original.Nombre + original.Apellido + original.Rol.Id))
            {
                CalcularDVH(user);
                bd.Modificar(user);
            }
            else
            {
                throw new Exception("El usuario " + original.NombreUsuario + " está corrupto, verificar base de datos");
            }
        }

        public void Baja(Usuario user)
        {
            bd.Baja(user);
        }

        public Usuario GetUsuario(Usuario user)
        {
            user = bd.GetUsuario(user);
            ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
            if (user.DVH == controlDeAccesoGestor.GetHash(user.NombreUsuario + user.Contraseña + user.Nombre + user.Apellido + user.Rol.Id))
            {
                return user;
            }
            else
            {
                throw new Exception("El usuario " + user.NombreUsuario + " está corrupto, verificar base de datos");
            }
        }

        public List<Usuario> GetListUsuario()
        {
            List<Usuario> usuarios= bd.GetListUsuario();
            ControlDeAccesoGestor controlDeAccesoGestor = new ControlDeAccesoGestor();
            foreach (var user in usuarios)
            {
                if (user.DVH != controlDeAccesoGestor.GetHash(user.NombreUsuario + user.Contraseña + user.Nombre + user.Apellido + user.Rol.Id))
                {
                    throw new Exception("El usuario " + user.NombreUsuario + " está corrupto, verificar base de datos");
                }
            }
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


