using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ConfeccionGestor
{
    DALConfeccion bd;

    public ConfeccionGestor()
    {
        bd = new DALConfeccion();
    }

    public void Confeccionar(Confeccion confeccion, string codigoPrenda)
    {
        confeccion.Codigo = confeccion.Prenda.Codigo + "_CNFCCN";
        confeccion.Prenda.Cantidad -= confeccion.Cantidad;
        // La confección aunque se realiza con máquinas también depende de el uso que le de la persona.
        // Aunque si tenemos en cuenta la velocidad de las máquinas varían entre 1200 a 300 rpm . Promedio 750 rpm.
        // Se tarda aproximadamente 2 minutos por prenda, aunque varía según la persona y la máquina.
        int prendasObtenidas = confeccion.Cantidad / 2;
        confeccion.Tiempo = prendasObtenidas * 120; //120 segundos cada 2 prendas. 
        // Debería elegir el tipo de prenda que desea confeccionar, siendo estas Remera o Pantalón y en base a eso conocer las prendas necesarias;
        PrendaGestor prendaGestor = new PrendaGestor();
        prendaGestor.Modificar(confeccion.Prenda);
        List<Prenda> prendasExistentes = prendaGestor.GetListPrenda();
        if (prendasExistentes.Exists(p => p.Codigo == codigoPrenda))
        {
            Prenda existente = prendaGestor.GetPrenda(prendasExistentes.Find(p => p.Codigo == codigoPrenda));
            existente.Cantidad += prendasObtenidas;
            prendaGestor.Modificar(existente);
        }
        else
        {
            prendaGestor.Alta(new Prenda(codigoPrenda, "Formado por " + confeccion.Prenda.Descripcion, prendasObtenidas, confeccion.Prenda.Talle, true));
        }
        bd.Alta(confeccion);
    }

    public void Baja(Confeccion confeccion)
    {
        bd.Baja(confeccion);
    }

    public Confeccion GetConfeccion(Confeccion confeccion)
    {
        return bd.Get(confeccion);
    }

    public List<Confeccion> GetList()
    {
        return bd.GetList();
    }
}
