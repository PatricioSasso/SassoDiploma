using Interfaces;
using System.Collections.Generic;

public class Permiso : IComponente
{
    int id;
    string nombre;
    string descripcion;

    public Permiso()
    {

    }

    public Permiso(int id, string nombre, string descripcion)
    {
        Id = id;
        Nombre = nombre;
        Descripcion = descripcion;
    }

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }

    public List<IComponente> Hijos => null;

    public void AgregarHijo(IComponente agregar)
    {
        throw new System.NotImplementedException();
    }

    public void QuitarHijo(IComponente quitar)
    {
        throw new System.NotImplementedException();
    }

    public void Vaciar()
    {
        throw new System.NotImplementedException();
    }
}
