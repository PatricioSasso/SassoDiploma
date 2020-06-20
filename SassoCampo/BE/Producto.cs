public class Producto
{
    int id;
    string codigo;
    string descripcion;
    int cantidad;
    Usuario ultimaModificacion;

    public Producto(int id, string codigo, string descripcion, int cantidad, Usuario ultimaModificacion)
    {
        Id = id;
        Codigo = codigo;
        Descripcion = descripcion;
        Cantidad = cantidad;
        UltimaModificacion = ultimaModificacion;
    }

    public int Id { get => id; set => id = value; }
    public string Codigo { get => codigo; set => codigo = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Cantidad { get => cantidad; set => cantidad = value; }
    public Usuario UltimaModificacion { get => ultimaModificacion; set => ultimaModificacion = value; }
}
