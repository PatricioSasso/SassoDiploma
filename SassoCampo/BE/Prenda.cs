using System;

public class Prenda : Producto
{
    string talle;
    int tiempoConfeccion;
    bool confeccionada;

    public Prenda()
    {

    }

    public Prenda(int id, string codigo, string descripcion, int cantidad, string talle, bool confeccionada, int tiempoConfeccion) : base(id, codigo, descripcion, cantidad)
    {
        Id = id;
        Codigo = codigo;
        Descripcion = descripcion;
        Cantidad = cantidad;
        Talle = talle;
        Confeccionada = confeccionada;
        TiempoConfeccion = tiempoConfeccion;
    }

    public string Talle { get => talle; set => talle = value; }
    public int TiempoConfeccion { get => tiempoConfeccion; set => tiempoConfeccion = value; }
    public bool Confeccionada { get => confeccionada; set => confeccionada = value; }
}
