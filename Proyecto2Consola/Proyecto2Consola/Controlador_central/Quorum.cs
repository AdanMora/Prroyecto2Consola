using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Consola.Controlador_central
{
    public class Quorum
    {
        private static Quorum instance;

        private Quorum() { }

        public static Quorum Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Quorum();
                }
                return instance;
            }
        }

    }
}
