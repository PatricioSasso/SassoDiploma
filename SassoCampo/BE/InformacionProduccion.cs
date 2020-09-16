using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class InformacionProduccion
    {
        int id;
        DateTime fecha;
        string estacion;
        List<Tejido> tejidos;
        List<Teñido> teñidos;
        List<Corte> cortes;
        List<Confeccion> confecciones;

        public InformacionProduccion()
        {

        }

        public InformacionProduccion(int id, DateTime fecha, string estacion, List<Tejido> tejidos, List<Teñido> teñidos, List<Corte> cortes, List<Confeccion> confecciones)
        {
            this.id = id;
            this.fecha = fecha;
            this.estacion = getSeason(fecha);
            this.tejidos = tejidos;
            this.teñidos = teñidos;
            this.cortes = cortes;
            this.confecciones = confecciones;
        }

        private string getSeason(DateTime date)
        {
            float value = (float)date.Month + date.Day / 100;
            if (value <= 3.21 || value >= 12.21) return "Verano";   // Summer
            if (value <= 6.21) return "Otoño"; // Autumn
            if (value <= 9.21) return "Invierno"; // Winter
            return "Primavera";   // Spring
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Estacion { get => estacion; set => estacion = value; }
        public List<Tejido> Tejidos { get => tejidos; set => tejidos = value; }
        public List<Teñido> Teñidos { get => teñidos; set => teñidos = value; }
        public List<Corte> Cortes { get => cortes; set => cortes = value; }
        public List<Confeccion> Confecciones { get => confecciones; set => confecciones = value; }
    }
}
