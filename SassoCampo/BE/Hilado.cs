using System;

[Serializable]
public class Hilado : Producto
{
    decimal peso;

    public Hilado()
    {

    }

    public Hilado(int id)
    {
        Id = Id;
    }

    public Hilado(int id, string codigo, string descripcion, int cantidad, decimal peso) : base(id, codigo, descripcion, cantidad)
    {
        Id = id;
        Codigo = codigo;
        Descripcion = descripcion;
        Cantidad = cantidad;
        Peso = peso;
    }

    public decimal Peso { get => peso; set => peso = value; }

    public override string ToString()
    {
        return $"Código: { Codigo } | Descripción: { Descripcion } | Cantidad: { Cantidad } | Peso: { Peso }";
    }
}
