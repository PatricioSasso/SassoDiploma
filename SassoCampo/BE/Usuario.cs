using System.Collections.Generic;

namespace BE { }
public class Usuario
{
    string nombreUsuario;
    string contraseña;
    string nombre;
    string apellido;
    Rol rol;
    string dVH;

    public Usuario()
    {
        
    }

    public Usuario(string nombreUsuario)
    {
        NombreUsuario = nombreUsuario;
    }

    public Usuario(string nombreUsuario, string contraseña, string nombre, string apellido, Rol rol)
    {
        NombreUsuario = nombreUsuario;
        Contraseña = contraseña;
        Nombre = nombre;
        Apellido = apellido;
        Rol = rol;
    }

    public Usuario(string nombreUsuario, string contraseña, string nombre, string apellido, Rol rol, string DVH)
    {
        NombreUsuario = nombreUsuario;
        Contraseña = contraseña;
        Nombre = nombre;
        Apellido = apellido;
        Rol = rol;
        this.DVH = DVH;
    }

    public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
    public string Contraseña { get => contraseña; set => contraseña = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public Rol Rol { get => rol; set => rol = value; }
    public string DVH { get => dVH; set => dVH = value; }
}
