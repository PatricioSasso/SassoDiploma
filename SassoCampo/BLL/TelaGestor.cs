using DAL;
using System.Collections.Generic;

public class TelaGestor
{
    AccesoADatos bd;

    public TelaGestor()
    {
        bd = new AccesoADatos();
    }

    public void Alta(Tela tela)
    {
        bd.AltaTela(tela);
    }

    public void Modificar(Tela tela)
    {
        bd.ModificarTela(tela);
    }

    public void Baja(Tela tela)
    {
        bd.BajaTela(tela);
    }

    public List<Tela> GetListTela()
    {
        return bd.GetListTela();
    }
}
