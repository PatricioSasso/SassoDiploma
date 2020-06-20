public class Prenda : Producto
{
    string talle;
    int tiempoConfección;
    bool confeccionada;

    public Prenda(int id, string codigo, string descripcion, int cantidad, Usuario ultimaModificacion) : base(id, codigo, descripcion, cantidad, ultimaModificacion)
    {
        Id = id;
        Codigo = codigo;
        Descripcion = descripcion;
        Cantidad = cantidad;

        UltimaModificacion = ultimaModificacion;
    }

    public string Talle { get => talle; set => talle = value; }
    public int TiempoConfección { get => tiempoConfección; set => tiempoConfección = value; }
    public bool Confeccionada { get => confeccionada; set => confeccionada = value; }
}
