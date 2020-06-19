using Entities;
using System;

public class Tela : Producto
{
    string color;
    bool teñido;

    public Tela(int id, string codigo, string descripcion, int cantidad, string color, bool teñido, Usuario ultimaModificacion) : base(id, codigo, descripcion, cantidad, ultimaModificacion)
    {
        Id = id;
        Codigo = codigo;
        Descripcion = descripcion;
        Cantidad = cantidad;
        Color = color;
        Teñido = teñido;
        UltimaModificacion = ultimaModificacion;
    }

    public string Color { get => color; set => color = value; }
    public bool Teñido { get => teñido; set => teñido = value; }
}
