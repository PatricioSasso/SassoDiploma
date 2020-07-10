using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

public class TeñidoGestor
{
    DALTeñido bd;

    public TeñidoGestor()
    {
        bd = new DALTeñido();
    }

    public void Teñir(Teñido teñido, string codigoTela)
    {
        List<Teñido> teñidosExistentes = GetListTeñido();
        if (teñidosExistentes.Count == 0) 
        { 
            teñido.Id = 1;
            teñido.Codigo = "TÑD" + 1;
        }
        else 
        { 
            teñido.Id = teñidosExistentes.Last().Id + 1;
            teñido.Codigo = "TÑD" + (teñidosExistentes.Last().Id + 1);
        }
        teñido.Tinte.Cantidad -= teñido.CantidadTinteUtilizada;
        teñido.Tela.Cantidad -= teñido.CantidadTelaUtilizada;
        Random r = new Random();
        teñido.Tiempo = r.Next(3600, 5400); //Puede durar entre 1 hora y 1 hora y media sin importar la cantidad de tela (limitado por el límite de la máquina). 
        // El promedio de teñido suele durar entre 1 hora a 1 hora y media y puede extenderse un poco más dependiendo a que 
        //otros procesos de control de teñido se exponga. En este caso suponemos que puede durar entre 1 a 1 hora y media únicamente.
        // Aunque estos datos son generalizados y con máquinas promedio, ya que el tiempo puede ser más o menos según bastantes factores
        // relacionados a la máquina, a la tela y otros factores que exeden el nivel de complejidad del proyecto.
        int telasObtenidas = teñido.CantidadTelaUtilizada;
        TinteGestor tinteGestor = new TinteGestor();
        tinteGestor.Modificar(teñido.Tinte);
        TelaGestor telaGestor = new TelaGestor();
        List<Tela> telasExistentes = telaGestor.GetListTela();
        if (telasExistentes.Exists(t => t.Codigo == codigoTela) && telasExistentes.Exists(t => t.Color == teñido.Tinte.Color))
        {
            Tela existente = telaGestor.GetTela(telasExistentes.Find(t => t.Codigo == codigoTela));
            existente.Cantidad += telasObtenidas;
            existente.Color = teñido.Tinte.Color;
            existente.Teñido = true;
            telaGestor.Modificar(existente);
        }
        else
        {
            telaGestor.Alta(new Tela(telasExistentes.Last().Id + 1, codigoTela, teñido.Tela.Descripcion, telasObtenidas, teñido.Tinte.Color , true));
        }
        bd.Alta(teñido);
    }

    public void Baja(Teñido teñido)
    {
        bd.Baja(teñido);
    }

    public Teñido GetTeñido(Teñido teñido)
    {
        return bd.GetTeñido(teñido);
    }

    public List<Teñido> GetListTeñido()
    {
        return bd.GetListTeñido();
    }
}

