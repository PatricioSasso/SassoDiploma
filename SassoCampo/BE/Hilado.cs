public class Hilado : Producto
{
    decimal peso;

    public Hilado()
    {

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
}
