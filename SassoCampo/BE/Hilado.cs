public class Hilado : Producto
{
    double peso;

    public Hilado(int id, string codigo, string descripcion, int cantidad, double peso, Usuario ultimaModificacion) : base(id, codigo, descripcion, cantidad, ultimaModificacion)
    {
        Id = id;
        Codigo = codigo;
        Descripcion = descripcion;
        Cantidad = cantidad;
        Peso = peso;
        UltimaModificacion = ultimaModificacion;
    }

    public double Peso { get => peso; set => peso = value; }
}
