﻿public class Tinte : Producto
{
    string color;

    public Tinte()
    {

    }

    public Tinte(int id)
    {
        Id = id;
    }

    public Tinte(string codigo, string descripcion, int cantidad, string color) : base(codigo, descripcion, cantidad)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Cantidad = cantidad;
        Color = color;
    }

    public Tinte(int id, string codigo, string descripcion, int cantidad, string color) : base(id, codigo, descripcion, cantidad)
    {
        Id = id;
        Codigo = codigo;
        Descripcion = descripcion;
        Cantidad = cantidad;
        Color = color;
    }

    public string Color { get => color; set => color = value; }
}
