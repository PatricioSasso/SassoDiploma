using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class TejidoGestor
{
    DALTejido bd;

    public TejidoGestor()
    {
        bd = new DALTejido();
    }

    public void Tejer(Tejido tejido, string codigoTela)
    {
        tejido.Codigo = tejido.Hilado.Codigo + "_TJD";
        tejido.Hilado.Cantidad -= tejido.CantidadUtilizada;
        tejido.Tiempo = tejido.CantidadUtilizada * decimal.ToInt32(decimal.Floor(tejido.Hilado.Peso)) / 160; // Uso 160 porque es la velocidad promedio de los telares que encontré. La fórmula sería Tiempo = (tamaño + peso) / velocidad de tejido.
        int telasObtenidas = tejido.CantidadUtilizada / tejido.AreaTela;
        HiladoGestor hiladoGestor = new HiladoGestor();
        hiladoGestor.Modificar(tejido.Hilado);
        TelaGestor telaGestor = new TelaGestor();
        List<Tela> telasExistentes = telaGestor.GetListTela();
        if(telasExistentes.Exists(t => t.Codigo == codigoTela))
        {
            Tela existente = telaGestor.GetTela(telasExistentes.Find(t => t.Codigo == codigoTela));
            existente.Cantidad += telasObtenidas;
            telaGestor.Modificar(existente);
        }
        else
        {
            telaGestor.Alta(new Tela(codigoTela, "Proviene de " + tejido.Hilado.Descripcion + ".", telasObtenidas , "", false)); // cada 20 metros de tela utilizadas se crea 1 tela.
        }
        bd.Alta(tejido);
    }

    public void Baja(Tejido tejido)
    {
        bd.Baja(tejido);
    }

    public Tejido GetTejido(Tejido tejido)
    {
        return bd.Get(tejido);
    }

    public List<Tejido> GetListTejido()
    {
        return bd.GetList();
    }
}
