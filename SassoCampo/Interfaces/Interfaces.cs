using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IABMC<T>
    {
        void Alta(T alta);
        void Baja(T baja);
        void Modificar(T modificar);
        T Get(T get);
        List<T> GetList();
    }

    public interface IHasheable
    {
        string GetHash( string input);
    }

    public interface IObservador<T>
    {
        void UpdateObserver(T idioma);
    }

    public interface ISujeto<T>
    {
        void Suscribir(IObservador<T> observer);
        void Desuscribir(IObservador<T> observer);
        void Notificar(T idioma);
        void CambiarIdioma(T idioma);
    }

    public interface ISerializer<T>
    {
        byte[] Serializar(T objeto);
        T DesSerializar(byte[] serializado);
    }

    public interface IComponente
    {
        List<IComponente> Hijos { get; }

        void AgregarHijo(IComponente agregar);
        void QuitarHijo(IComponente quitar);
        void Vaciar();
    }
}
