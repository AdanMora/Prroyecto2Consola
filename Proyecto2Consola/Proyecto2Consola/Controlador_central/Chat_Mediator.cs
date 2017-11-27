using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Proyecto2Consola.Controlador_central
{
    class Chat_Mediator : Mediator
    {
        Collection<Usuario_Chat> usuarios = new Collection<Usuario_Chat>();

        public Chat_Mediator() { }

        public void agregarUsuario(Usuario_Chat u)
        {
            usuarios.Add(u);
        }

        public void enviarMensaje(string mensaje, string usuario)
        {
            foreach (Usuario_Chat u in usuarios)
            {
                if (u.getUsuario() == usuario)
                {
                    u.recibirMensaje("I said: " + mensaje);
                } else
                {
                    u.recibirMensaje(usuario + "said: " + mensaje);
                }
            }
        }
    }
}
