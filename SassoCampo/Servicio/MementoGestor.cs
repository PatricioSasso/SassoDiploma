using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DAL;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using BE;

namespace Service
{
    public class MementoGestor : ISerializer<Hilado>
    {
        DALControlCambios dalControlCambios = new DALControlCambios();

        public MementoGestor()
        {

        }

        public void CreateMemento(Hilado hilado)
        {
            Memento memento = new Memento(DateTime.Now, hilado, Serializar(hilado));
            dalControlCambios.AddMemento(memento);
        }

        public void RestoreMemento(Hilado hilado, Memento memento)
        {
            hilado = memento.Estado;
            dalControlCambios.RestoreMemento(hilado);
        }

        public List<Memento> GetMementos(Memento memento)
        {
            List<Memento> mementos = dalControlCambios.GetMementos(memento);
            for (int i = 0; i < mementos.Count; i++)
            {
                mementos[i].Estado = DesSerializar(mementos[i].Serializado);
            }
            return mementos;
        }

        public byte[] Serializar(Hilado objeto)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream memory = new MemoryStream();
            formatter.Serialize(memory, objeto);
            byte[] serializado = memory.ToArray();
            memory.Close();
            return serializado;
        }

        public Hilado DesSerializar(byte[] serializado)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream memory = new MemoryStream(serializado);
            Hilado objeto = (Hilado)formatter.Deserialize(memory);
            memory.Close();
            return objeto;
        }
    }
}
