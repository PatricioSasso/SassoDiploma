using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using Interfaces;
using System.Windows.Forms;

namespace Service
{
    public class TraduccionIdiomaGestor : ISujeto<Idioma>
    {
        DALTraduccionIdioma bd;
        Idioma idioma;
        List<IObservador<Idioma>> observando;

        public TraduccionIdiomaGestor()
        {

        }

        public TraduccionIdiomaGestor(Idioma idioma)
        {
            bd = new DALTraduccionIdioma();
            this.Idioma = bd.GetIdioma(idioma);
            observando = new List<IObservador<Idioma>>();
        }

        public Idioma Idioma { get => idioma; set => idioma = value; }

        public void CambiarIdioma(Idioma idioma)
        {
            if (idioma.Nombre != this.idioma.Nombre)
            {
                this.Idioma = bd.GetIdioma(idioma);
                Notificar(this.idioma);
            }
        }

        public void Desuscribir(IObservador<Idioma> observer)
        {
            observando.Remove(observer);
        }

        public void Notificar(Idioma idioma)
        {
            foreach (IObservador<Idioma> form in observando)
            {
                form.UpdateObserver(bd.GetIdioma(idioma));
            }
        }

        public void Suscribir(IObservador<Idioma> observer)
        {
            observando.Add(observer);
            CambiarIdioma(this.Idioma);

        }

        public void Traducir(Control control)
        {
            if (Idioma.Traducciones.Exists(t => t.Nombre == control.Name))
            {
                control.Text = Idioma.Traducciones.Find(t => t.Nombre == control.Name).Texto;
            }
        }

        public void Traducir(List<Control> controles)
        {
            List<Control> controlesATraducir = new List<Control>();
            foreach (var control in controles)
            {
                if (typeof(TextBox) != control.GetType() && typeof(ComboBox) != control.GetType() && typeof(MenuStrip) != control.GetType() && typeof(DataGridView) != control.GetType() && typeof(ListBox) != control.GetType() && control.Text != "" && control.Name != "")
                {
                    if(control.Name != "lbl_NombreUsuario2" && control.Name != "lbl_NombreYApellido" && control.Name != "lbl_Rol")
                    {
                        controlesATraducir.Add(control);
                    }
                }
            }
            foreach (var control in controlesATraducir)
            {
                if (Idioma.Traducciones.Exists(t => t.Nombre == control.Name))
                {
                    control.Text = Idioma.Traducciones.Find(t => t.Nombre == control.Name).Texto;
                }
               /* else
                {
                    MessageBox.Show("Falta traducir " + control.Name + " con texto " + control.Text + " a " + idioma.Nombre + ".");
                }*/
            }
        }

        public List<string> GetAllNameIdioma()
        {
            return bd.GetAllNameIdioma();
        }
    }
}
