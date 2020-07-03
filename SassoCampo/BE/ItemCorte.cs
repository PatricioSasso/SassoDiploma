public class ItemCorte
{
    int dimensiones;
    int cantidad;
    Tela tela;

    public ItemCorte()
    {

    }

    public ItemCorte(int dimensiones, int cantidad, Tela tela)
    {
        Dimensiones = dimensiones;
        Cantidad = cantidad;
        Tela = tela;
    }

    public int Dimensiones { get => dimensiones; set => dimensiones = value; }
    public int Cantidad { get => cantidad; set => cantidad = value; }
    public Tela Tela { get => tela; set => tela = value; }
}
