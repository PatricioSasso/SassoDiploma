using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Windows.Forms;

namespace Service
{
    public class TraduccionIdiomaGestor
    {
        DALTraduccionIdioma bd;
        Idioma idioma;

        public TraduccionIdiomaGestor(string idioma)
        {
            bd = new DALTraduccionIdioma();
            this.idioma = bd.GetIdioma(idioma);
        }

        public void CambiarIdioma(string idioma)
        {
            this.idioma = bd.GetIdioma(idioma);
        }

        public Idioma GetIdioma(string idioma)
        {
            return bd.GetIdioma(idioma);
        }

        public void Traducir(Control control)
        {
            if (idioma.Traducciones.Exists(t => t.Nombre == control.Name))
            {
                control.Text = idioma.Traducciones.Find(t => t.Nombre == control.Name).Texto;
            }
            else if (control.Text != "")
            {
                MessageBox.Show("Falta traducir " + control.Name + " con texto " + control.Text + ".");
            }
        }

        public void Traducir(List<Control> controles)
        {
            List<Control> controlesATraducir = new List<Control>();
            foreach (var control in controles)
            {
                if (typeof(TextBox) != control.GetType() && typeof(ComboBox) != control.GetType() && typeof(MenuStrip) != control.GetType())
                {
                    controlesATraducir.Add(control);
                }
            }
            foreach (var control in controlesATraducir)
            //foreach (var control in controles)
            {
                if (idioma.Traducciones.Exists(t => t.Nombre == control.Name))
                {
                    control.Text = idioma.Traducciones.Find(t => t.Nombre == control.Name).Texto;
                }
                else
                {
                    MessageBox.Show("Falta traducir " + control.Name + " con texto " + control.Text + " a " + idioma.Nombre + ".");
                }
            }
        }
    }
}
