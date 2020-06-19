using System;
using System.Collections.Generic;

public class Corte
{
    int id;
    string codigo;
    List<Tela> telas;
    int dimensionesTela;
    int cantidadTela;
    int cantidadPrenda;
    string talle;
    int tiempo;

    public Corte(int id, string codigo, List<Tela> telas, int dimensionesTela, int cantidadTela, int cantidadPrenda, string talle, int tiempo)
    {
        Id = id;
        Codigo = codigo;
        Telas = telas;
        DimensionesTela = dimensionesTela;
        CantidadTela = cantidadTela;
        CantidadPrenda = cantidadPrenda;
        Talle = talle;
        Tiempo = tiempo;
    }

    public int Id { get => id; set => id = value; }
    public string Codigo { get => codigo; set => codigo = value; }
    public List<Tela> Telas { get => telas; set => telas = value; }
    public int DimensionesTela { get => dimensionesTela; set => dimensionesTela = value; }
    public int CantidadTela { get => cantidadTela; set => cantidadTela = value; }
    public int CantidadPrenda { get => cantidadPrenda; set => cantidadPrenda = value; }
    public string Talle { get => talle; set => talle = value; }
    public int Tiempo { get => tiempo; set => tiempo = value; }
}
