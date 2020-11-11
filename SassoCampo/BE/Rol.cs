using Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

public class Rol : IComponente
{
    int id;
    string nombre;
    List<IComponente> permisos;

    public Rol()
    {
        this.permisos = new List<IComponente>();
    }

    public Rol(string nombre, List<IComponente> permisos)
    {
        Id = id;
        Nombre = nombre;
        this.permisos = permisos;
    }

    public Rol(int id, string nombre, List<IComponente> permisos)
    {
        Id = id;
        Nombre = nombre;
        this.permisos = permisos;
    }

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }

    public List<IComponente> Hijos { get => permisos; }

    public void AgregarHijo(IComponente agregar)
    {
        permisos.Add(agregar);
    }

    public void QuitarHijo(IComponente quitar)
    {
        permisos.Remove(quitar);
    }

    public void Vaciar()
    {
        permisos = new List<IComponente>();
    }

    public List<Permiso> GetList()
    {
        List<Permiso> permisos = new List<Permiso>();
        foreach (var permiso in this.permisos)
        {
            permisos.Add(permiso as Permiso);
        }
        return permisos;
    }
}
