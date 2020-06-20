using System.Collections.Generic;

public class Confeccion
{
    int id;
    string codigo;
    List<Prenda> prenda;
    int cantidad;
    int tiempo;

    public int Id { get => id; set => id = value; }
    public string Codigo { get => codigo; set => codigo = value; }
    public List<Prenda> Prenda { get => prenda; set => prenda = value; }
    public int Cantidad { get => cantidad; set => cantidad = value; }
    public int Tiempo { get => tiempo; set => tiempo = value; }
}
