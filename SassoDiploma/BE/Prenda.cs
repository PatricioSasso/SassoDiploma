using System;

public class Prenda : Producto
{
    string talle;
    bool confeccionada;

    public Prenda()
    {

    }

    public Prenda(int id)
    {
        Id = id;
    }

    public Prenda(string codigo, string descripcion, int cantidad, string talle, bool confeccionada) : base(codigo, descripcion, cantidad)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Cantidad = cantidad;
        Talle = talle;
        Confeccionada = confeccionada;
    }

    public Prenda(int id, string codigo, string descripcion, int cantidad, string talle, bool confeccionada) : base(id, codigo, descripcion, cantidad)
    {
        Id = id;
        Codigo = codigo;
        Descripcion = descripcion;
        Cantidad = cantidad;
        Talle = talle;
        Confeccionada = confeccionada;
    }

    public string Talle { get => talle; set => talle = value; }
    public bool Confeccionada { get => confeccionada; set => confeccionada = value; }
}
