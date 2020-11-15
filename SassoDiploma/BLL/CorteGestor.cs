using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CorteGestor
{
    DALCorte bd;

    public CorteGestor()
    {
        bd = new DALCorte();
    }

    public void Cortar(Corte corte, string codigoPrenda)
    {
        corte.Codigo = corte.Tela.Codigo + "CRT";
        corte.Tela.Cantidad -= corte.CantidadTela;
        // velocidad de 2000 cm/s máxima aprox.
        corte.Tiempo = (corte.CantidadTela * corte.Dimensiones * 1000) / 2000; // CantidadTelas * Dimensiones * 1000 (para transformar de m2 a cm2) / velocidad máquina.
        // TO DO: Agregar tipo de prenda (remera, pantalón) y según el tipo de prenda apareceran los talles (S, M, L) correspondientes.
        int prendasObtenidas = corte.CantidadTela ;
        if (corte.Talle == "S") { prendasObtenidas = prendasObtenidas * 8; }
        else if (corte.Talle == "M") { prendasObtenidas = prendasObtenidas * 6; }
        else { prendasObtenidas = prendasObtenidas * 4; } // por ahora S = 8, M = 6, L = 4;
        // Podría usar un Interpreter para que el talle pueda ser ingresado de distintas maneras pero ser traducido a S, M o L.
        TelaGestor telaGestor = new TelaGestor();
        telaGestor.Modificar(corte.Tela);
        PrendaGestor prendaGestor = new PrendaGestor();
        List<Prenda> prendasExistentes = prendaGestor.GetListPrenda();
        if (prendasExistentes.Exists(p => p.Codigo == codigoPrenda))
        {
            Prenda existente = prendaGestor.GetPrenda(prendasExistentes.Find(p => p.Codigo == codigoPrenda));
            existente.Cantidad += prendasObtenidas;
            prendaGestor.Modificar(existente);
        }
        else
        {
            prendaGestor.Alta(new Prenda(codigoPrenda, "Corte de " + corte.Tela.Descripcion, prendasObtenidas, corte.Talle, false));
        }
        bd.Alta(corte);
    }

    public void Baja(Corte corte)
    {
        bd.Baja(corte);
    }

    public Corte GetCorte(Corte corte)
    {
        return bd.Get(corte);
    }

    public List<Corte> GetList()
    {
        return bd.GetList();
    }
}
