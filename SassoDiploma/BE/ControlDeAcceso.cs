public class ControlDeAcceso
{
    Usuario usuarioActual;
    bool autenticado;
    private static ControlDeAcceso singleton;

    public ControlDeAcceso GetInstance()
    {
        if (singleton == null)
        {
            singleton = new ControlDeAcceso();
        }
        return singleton;
    }

    public Usuario UsuarioActual { get => usuarioActual; set => usuarioActual = value; }
    public bool Autenticado { get => autenticado; set => autenticado = value; }
}
