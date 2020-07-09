using DAL;
using System.Collections.Generic;

public class TelaGestor
{
    DALTela bd;

    public TelaGestor()
    {
        bd = new DALTela();
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

    public Tela GetTela(Tela tela)
    {
        return bd.GetTela(tela);
    }

    public List<Tela> GetListTela()
    {
        return bd.GetListTela();
    }

    public List<Tela> GetListTelaSinTeñir()
    {
        List<Tela> sinTeñir = new List<Tela>();
        foreach (var t in bd.GetListTela())
        {
            if (!t.Teñido) { sinTeñir.Add(t); }
        }
        return sinTeñir;
    }

    public List<Tela> GetListTelaTeñida()
    {
        List<Tela> teñidas = new List<Tela>();
        foreach (var t in bd.GetListTela())
        {
            if (t.Teñido) { teñidas.Add(t); }
        }
        return teñidas;
    }
}
