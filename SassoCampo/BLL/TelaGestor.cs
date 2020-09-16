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
        bd.Alta(tela);
    }

    public void Modificar(Tela tela)
    {
        bd.Modificar(tela);
    }

    public void Baja(Tela tela)
    {
        bd.Baja(tela);
    }

    public Tela GetTela(Tela tela)
    {
        return bd.Get(tela);
    }

    public List<Tela> GetListTela()
    {
        return bd.GetList();
    }

    public List<Tela> GetListTelaSinTeñir()
    {
        List<Tela> sinTeñir = new List<Tela>();
        foreach (var t in bd.GetList())
        {
            if (!t.Teñido) { sinTeñir.Add(t); }
        }
        return sinTeñir;
    }

    public List<Tela> GetListTelaTeñida()
    {
        List<Tela> teñidas = new List<Tela>();
        foreach (var t in bd.GetList())
        {
            if (t.Teñido) { teñidas.Add(t); }
        }
        return teñidas;
    }
}
