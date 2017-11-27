using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Proyecto2Consola.Controlador_central
{
    public interface Subject_Observer
    {

        void registrarObserver(Observer o);

        void eliminarObserver(Observer o);

        void notificarObservadores();
    }
}
