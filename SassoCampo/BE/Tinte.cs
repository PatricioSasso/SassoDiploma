public class Tinte : Producto
{
    string color;

    public Tinte(int id, string codigo, string descripcion, int cantidad, string color, Usuario ultimaModificacion) : base(id, codigo, descripcion, cantidad, ultimaModificacion)
    {
        Id = id;
        Codigo = codigo;
        Descripcion = descripcion;
        Cantidad = cantidad;
        Color = color;
        UltimaModificacion = ultimaModificacion;
    }

    public string Color { get => color; set => color = value; }
}
