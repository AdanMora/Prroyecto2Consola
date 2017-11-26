using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1.Modelo;
using Proyecto1.Controlador;

namespace Proyecto2Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Gestor g = new Gestor();

            g.cargarDatos();
            Console.WriteLine("\nConsejo - Carga de datos");
            Console.WriteLine("\nMiembros");
            foreach (Miembro m in g.getConsejo().Miembros)
            {
                Console.WriteLine(m.toString());
            }

            Console.WriteLine("\nSolicitudes");
            foreach (PuntoAgenda p in g.getConsejo().Solicitudes)
            {
                Console.WriteLine(p.toString());
            }

            Console.WriteLine("\nSesiones");
            foreach (Sesion s in g.getConsejo().Sesiones)
            {
                Console.WriteLine(s.toString());

                foreach (PuntoAgenda p in s.Agenda)
                {
                    Console.WriteLine(p.toString());

                    foreach (Comentario c in p.Comentarios)
                    {
                        Console.WriteLine(c.toString());
                    }
                }
            }

            Console.WriteLine("\nSesion Actual");

            Console.WriteLine(g.getSesion().toString());

            for (int i = 0; i < g.getSesion().MiembrosAsistencia.Asistencia.Count; i++)
            {
                Console.WriteLine(g.getSesion().MiembrosAsistencia.Asistencia.ElementAt(i).toString());

                Console.WriteLine("||||||||" + g.getSesion().MiembrosAsistencia.ListaAsistencia.ElementAt(i) + "||||||||");
            }

            Console.Read();
        }
    }
}
