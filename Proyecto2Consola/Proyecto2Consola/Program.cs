using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1.Modelo;
using Proyecto1.Controlador;
using Proyecto2Consola.Controlador_central;

namespace Proyecto2Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            //Gestor g = new Gestor();

            //g.cargarDatos();
            //Console.WriteLine("\nConsejo - Carga de datos");
            //Console.WriteLine("\nMiembros");
            //foreach (Miembro m in g.getConsejo().Miembros)
            //{
            //    Console.WriteLine(m.toString());
            //}

            //Console.WriteLine("\nSolicitudes");
            //foreach (PuntoAgenda p in g.getConsejo().Solicitudes)
            //{
            //    Console.WriteLine(p.toString());
            //}

            //Console.WriteLine("\nSesiones");
            //foreach (Sesion s in g.getConsejo().Sesiones)
            //{
            //    Console.WriteLine(s.toString());

            //    foreach (PuntoAgenda p in s.Agenda)
            //    {
            //        Console.WriteLine(p.toString());

            //        foreach (Comentario c in p.Comentarios)
            //        {
            //            Console.WriteLine(c.toString());
            //        }
            //    }
            //}

            //Console.WriteLine("\nSesion Actual");

            //Console.WriteLine(g.getSesion().toString());

            //for (int i = 0; i < g.getSesion().MiembrosAsistencia.Asistencia.Count; i++)
            //{
            //    Console.WriteLine(g.getSesion().MiembrosAsistencia.Asistencia.ElementAt(i).toString());

            //    Console.WriteLine("||||||||" + g.getSesion().MiembrosAsistencia.ListaAsistencia.ElementAt(i) + "||||||||");
            //}


            //Proxy proxy = new Proxy("sc","sc");
            //Quorum.Instance.registrarObserver(proxy);

            //Console.WriteLine("Quorum actual: " + Quorum.Instance.getQuorum());

            //proxy.modificarAsistencia("kirs@gmail.com", true);

            //proxy.modificarAsistencia("kirs@gmail.com", false);

            Proxy proxySC = new Proxy("sc", "sc");

            Proxy proxyM = new Proxy("kirs@gmail.com", "kirs@gmail.com");

            Proxy proxyPC = new Proxy("aj@gmail.com", "aj@gmail.com");

            Console.WriteLine("####################################################");

            Chat_Mediator chat = new Chat_Mediator();

            proxyPC.setMediator(chat);
            proxySC.setMediator(chat);
            proxyM.setMediator(chat);

            chat.agregarUsuario(proxyM);
            chat.agregarUsuario(proxySC);
            chat.agregarUsuario(proxyPC);

            proxyM.enviarMensaje("Iván carepicha");

            Console.WriteLine("-----------------------------------------");

            proxySC.enviarMensaje("Iván el Trollazo");

            Console.WriteLine("-----------------------------------------");

            proxyPC.enviarMensaje("Iván agarrámelas que se me van");

            Console.WriteLine("-----------------------------------------");

            Console.Read();
        }
    }
}
