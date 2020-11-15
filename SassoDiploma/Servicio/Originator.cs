using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using BE;

namespace Service
{
    public class Originator
    {
        Hilado estado;

        public Originator()
        {

        }

        public void CreateMemento()
        {
            MementoGestor mementoGestor = new MementoGestor();
            mementoGestor.CreateMemento(estado);
        }

        public void SetMemento(Hilado hilado)
        {
            this.estado = hilado;
        }

        public void RestoreMemento(Hilado objeto, Memento memento)
        {
            MementoGestor mementoGestor = new MementoGestor();
            mementoGestor.RestoreMemento(objeto, memento);
        }

        public List<Memento> GetMementos(Memento memento)
        {
            MementoGestor mementoGestor = new MementoGestor();
            return mementoGestor.GetMementos(memento);
        }
    }
}
