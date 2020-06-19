using System;
using System.Collections.Generic;

namespace Entities
{
    public class Usuario
    {
        string nombreUsuario;
        string contraseña;
        string nombre;
        string apellido;
        List<Rol> roles;

        public Usuario(string nombreUsuario, string contraseña, string nombre, string apellido, List<Rol> roles)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Nombre = nombre;
            Apellido = apellido;
            Roles = roles;
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public List<Rol> Roles { get => roles; set => roles = value; }
    }
}
