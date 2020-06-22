using System.Collections.Generic;

namespace BE { }
public class Usuario
{
    string nombreUsuario;
    string contraseña;
    string nombre;
    string apellido;
    Rol rol;

    public Usuario()
    {
        
    }

    public Usuario(string nombreUsuario, string contraseña, string nombre, string apellido, Rol rol)
    {
        NombreUsuario = nombreUsuario;
        Contraseña = contraseña;
        Nombre = nombre;
        Apellido = apellido;
        Rol = rol;
    }

    public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
    public string Contraseña { get => contraseña; set => contraseña = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public Rol Rol { get => rol; set => rol = value; }
}
