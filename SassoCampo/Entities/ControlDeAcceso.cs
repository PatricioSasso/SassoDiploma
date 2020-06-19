using Entities;
using System;

public class ControlDeAcceso
{
    Usuario usuarioActual;
    bool autenticado;
    ControlDeAcceso singleton;

    public ControlDeAcceso(Usuario usuarioActual, bool autenticado)
    {
        //todo: Implementar Singleton.
        UsuarioActual = usuarioActual;
        Autenticado = autenticado;
    }

    public Usuario UsuarioActual { get => usuarioActual; set => usuarioActual = value; }
    public bool Autenticado { get => autenticado; set => autenticado = value; }
}
