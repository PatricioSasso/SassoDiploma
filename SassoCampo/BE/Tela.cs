public class Tela : Producto
{
    string color;
    bool teñido;

    public Tela()
    {

    }

    public Tela(int id, string codigo, string descripcion, int cantidad, string color, bool teñido) : base(id, codigo, descripcion, cantidad)
    {
        Id = id;
        Codigo = codigo;
        Descripcion = descripcion;
        Cantidad = cantidad;
        Color = color;
        Teñido = teñido;
    }

    public string Color { get => color; set => color = value; }
    public bool Teñido { get => teñido; set => teñido = value; }
}
