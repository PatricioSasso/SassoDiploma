public class ItemCorte
{
    Tela tela;
    int dimensiones;
    int cantidad;

    public ItemCorte(Tela tela, int dimensiones, int cantidad)
    {
        Tela = tela;
        Dimensiones = dimensiones;
        Cantidad = cantidad;
    }

    public Tela Tela { get => tela; set => tela = value; }
    public int Dimensiones { get => dimensiones; set => dimensiones = value; }
    public int Cantidad { get => cantidad; set => cantidad = value; }
}
