using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Consola.Controlador_central
{
    public class Quorum : Subject_Observer
    {
        private static Quorum instance;
        private static int cantQuorum;
        private Collection<Observer> observers = new Collection<Observer>();
        private static bool cargado;

        private Quorum() { }

        public static Quorum Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Quorum();
                    cantQuorum = 0;
                    cargado = false;
                }
                return instance;
            }
        }

        public int getQuorum()
        {
            return cantQuorum;
        }

        public void modificarQuorum(bool accion)
        {
            if (accion)
            {
                cantQuorum++;
            }
            else
            {
                cantQuorum--;
            }

            notificarObservadores();
        }

        public void cargarQuorum()
        {
            cargado = true;
        }

        public bool isCargado()
        {
            return cargado;
        }

        public void registrarObserver(Observer o)
        {
            observers.Add(o);
        }

        public void eliminarObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void notificarObservadores()
        {
            if (observers.Any())
            {
                foreach (Observer o in observers)
                {
                    o.notificarCambioQuorum();
                }
            }
        }

    }
}
