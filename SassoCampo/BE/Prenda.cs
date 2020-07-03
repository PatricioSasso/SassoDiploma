using System;

public class Prenda : Producto
{
    string talle;
    int tiempoConfección;
    bool confeccionada;

    public Prenda()
    {

    }

    public Prenda(int id, string codigo, string descripcion, int cantidad) : base(id, codigo, descripcion, cantidad)
    {
        Id = id;
        Codigo = codigo;
        Descripcion = descripcion;
        Cantidad = cantidad;
    }

    public string Talle { get => talle; set => talle = value; }
    public int TiempoConfección { get => tiempoConfección; set => tiempoConfección = value; }
    public bool Confeccionada { get => confeccionada; set => confeccionada = value; }
}
