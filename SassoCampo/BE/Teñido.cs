using System;

public class Teñido
{
    int id;
    string codigo;
    int cantidadTinteUtilizada;
    int cantidadTelaUtilizada;
    int tiempo;
    DateTime fecha;
    Tinte tinte;
    Tela tela;

    public Teñido()
    {

    }

    public Teñido(int id, string codigo, int cantidadTinteUtilizada, int cantidadTelaUtilizada, int tiempo, DateTime fecha, Tinte tinte, Tela tela)
    {
        Id = id;
        Codigo = codigo;
        CantidadTinteUtilizada = cantidadTinteUtilizada;
        CantidadTelaUtilizada = cantidadTelaUtilizada;
        Tiempo = tiempo;
        Fecha = fecha;
        Tinte = tinte;
        Tela = tela;
    }

    public int Id { get => id; set => id = value; }
    public string Codigo { get => codigo; set => codigo = value; }
    public int CantidadTinteUtilizada { get => cantidadTinteUtilizada; set => cantidadTinteUtilizada = value; }
    public int CantidadTelaUtilizada { get => cantidadTelaUtilizada; set => cantidadTelaUtilizada = value; }
    public int Tiempo { get => tiempo; set => tiempo = value; }
    public DateTime Fecha { get => fecha; set => fecha = value; }
    public Tinte Tinte { get => tinte; set => tinte = value; }
    public Tela Tela { get => tela; set => tela = value; }
}
