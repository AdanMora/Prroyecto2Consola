using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Consola.Controlador_central
{
    class Subjetct_Proxy
    {
        private Facade_M miembro_C;
        private Facade_PC presidente_C;
        private Facade_SC secretaria_C;

        int acceso = 0;
        public Subjetct_Proxy()
        {
            miembro_C = new Facade_M();
            presidente_C = new Facade_PC();
            secretaria_C = new Facade_SC();
        }


        public int Acceso
        {
            get
            {
                return acceso;
            }

            set
            {
                acceso = value;
                Acceso_Consejo();
            }
        }

        private void Acceso_Consejo()
        {
            switch (acceso)
            {
                case 0:
                    Console.WriteLine("sesion de miembros");
                    miembro_C.acceso_Miembro();
                    break;
                case 1:
                    Console.WriteLine("sesion de presidente");
                    presidente_C.acceso_Presidente();
                    break;
                case 2:
                    Console.WriteLine("sesion de secretaria");
                    secretaria_C.acceso_Secretaria();
                    break;
                default:
                    break;
            }
                                                
        }

    }
}
