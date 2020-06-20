using DAL;

public class ControlDeAccesoGestor
{
    AccesoADatos bd;

    public ControlDeAccesoGestor()
    {
        bd = new AccesoADatos();
    }

    public bool LogIn(string nombreUsuario, string contraseña)
    {
        return bd.LogIn(nombreUsuario, contraseña);
    }

    public Usuario GetUsuario(string nombreUsuario)
    {
        return bd.GetUsuario(nombreUsuario);
    }
}
