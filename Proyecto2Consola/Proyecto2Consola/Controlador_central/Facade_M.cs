﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1.Modelo;
using Proyecto1.Controlador;
using System.Collections.ObjectModel;

namespace Proyecto2Consola.Controlador_central
{
    class Facade_M : Subject_Observer, Subject_Proxy
    {
        ControladorProyecto1 controller;

        Collection<Observer> observers = new Collection<Observer>();

        public Facade_M()
        {
            controller = UberController.Instance.getControlador();
        }
        public void acceso_Miembro()
        {
            Console.WriteLine("acceso al dashboard de miembros");
        }

        public void log_out()
        {
            Console.WriteLine("Log out");
        }

        public void agregarSolicitud(string nombre, string resultando, string considerandos, string seAcuerda, char tipo)
        {
            controller.agregarSolicitud(nombre, resultando, considerandos, seAcuerda, tipo);
        }

        public void asociarAdjunto(int idPunto, string path, string nombreArchivo, string extension)
        {
            controller.asociarAdjunto(idPunto, path, nombreArchivo, extension);
        }

        public Collection<String> getAdjuntos(int idPunto)
        {
            return controller.getAdjuntos(idPunto);
        }

        public void obtenerAdjunto(int idPunto, string nombreAdjunto, string path)
        {
            controller.obtenerAdjunto(idPunto, nombreAdjunto, path);
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

        public void nuevaSesion(string num, DateTime fecha, string lugar)
        {
            throw new NotImplementedException();
        }

        public void cerrarSesion()
        {
            throw new NotImplementedException();
        }

        public void actualizarMiembros(string path)
        {
            throw new NotImplementedException();
        }

        public void agregarPuntoAgenda(string nombre, string resultando, string considerandos, string seAcuerda, char tipo)
        {
            throw new NotImplementedException();
        }

        public void agregarComentario(int idPunto, string correoMiembro, string txt)
        {
            throw new NotImplementedException();
        }

        public void eliminarSolicitud(int id)
        {
            throw new NotImplementedException();
        }

        public void eliminarPuntoAgenda(int id)
        {
            throw new NotImplementedException();
        }

        public void aceptarSolicitud(int id)
        {
            throw new NotImplementedException();
        }

        public void agregarVotacion(int id, int aFavor, int enContra, int blanco)
        {
            throw new NotImplementedException();
        }

        public void crearAgenda(string sesion, string path)
        {
            throw new NotImplementedException();
        }

        public void crearActa(string numSesion, int tipo, string path)
        {
            throw new NotImplementedException();
        }

        public void modificarAsistencia(string correoMiembro, bool estado)
        {
            throw new NotImplementedException();
        }

        public Collection<PuntoAgenda> getSolicitudes()
        {
            throw new NotImplementedException();
        }

        public Collection<PuntoAgenda> getPuntosAgenda()
        {
            throw new NotImplementedException();
        }

        public Prototype_Miembros getAsistencia()
        {
            throw new NotImplementedException();
        }

        public Collection<Miembro> getMiembrosConsejo()
        {
            throw new NotImplementedException();
        }

        public Collection<Comentario> getComentarios(int idPunto)
        {
            throw new NotImplementedException();
        }

        public bool haySesion()
        {
            throw new NotImplementedException();
        }

        public void cambiarPosicionPunto(int posicionNueva, int posicionVieja)
        {
            throw new NotImplementedException();
        }

        public Collection<string> getAllNumeroSesiones()
        {
            throw new NotImplementedException();
        }

        public void enviarNotificacion(string numeroSesion, DateTime fecha, string correo,string pathMemo)
        {
            throw new NotImplementedException();
        }

        public void enviarAgenda(string numeroSesion, DateTime fecha, string correo, string agenda)
        {
            throw new NotImplementedException();
        }

        public void obtenerAgenda(Sesion sesion, string path)
        {
            throw new NotImplementedException();
        }

        public void asociarActa(string numSesion, string path, string nombreArchivo)
        {
            throw new NotImplementedException();
        }

        public void obtenerActa(string numSesion, string path)
        {
            throw new NotImplementedException();
        }

        public void crearAcuerdo(PuntoAgenda punto, string destinatario, string path)
        {
            throw new NotImplementedException();
        }

        public Sesion getSesion()
        {
            throw new NotImplementedException();
        }

        public Sesion getSesion(string numero)
        {
            throw new NotImplementedException();
        }
    }
}
