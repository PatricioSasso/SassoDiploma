public class Tejido
{
    int id;
    string codigo;
    Hilado hilado;
    int cantidadUtilizada;
    int tiempo;

    public Tejido(int id, string codigo, Hilado hilado, int cantidadUtilizada, int tiempo)
    {
        Id = id;
        Codigo = codigo;
        Hilado = hilado;
        CantidadUtilizada = cantidadUtilizada;
        Tiempo = tiempo;
    }

    public int Id { get => id; set => id = value; }
    public string Codigo { get => codigo; set => codigo = value; }
    public Hilado Hilado { get => hilado; set => hilado = value; }
    public int CantidadUtilizada { get => cantidadUtilizada; set => cantidadUtilizada = value; }
    public int Tiempo { get => tiempo; set => tiempo = value; }
}
