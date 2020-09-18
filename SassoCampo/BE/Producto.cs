using System;

[Serializable]
public class Producto
{
    int id;
    string codigo;
    string descripcion;
    int cantidad;

    public Producto()
    {

    }

    public Producto(int id)
    {
        Id = id;
    }

    public Producto(int id, string codigo, string descripcion, int cantidad)
    {
        Id = id;
        Codigo = codigo;
        Descripcion = descripcion;
        Cantidad = cantidad;
    }

    public int Id { get => id; set => id = value; }
    public string Codigo { get => codigo; set => codigo = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Cantidad { get => cantidad; set => cantidad = value; }
}
