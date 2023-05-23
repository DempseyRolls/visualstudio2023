using Mensajero.Comunicacion;
using MensajeroModel.DAL;
using MensajeroModel.DTO;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Mensajero
{
    public class Program
    {
        private static IMensajesDAL mensajesDAL = MensajeDALArchivos.GetInstancia();
        //se referencia mensajeromodel

        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("seleccione una opcion");
            Console.WriteLine(" 1. Ingresar \n 2. Mostrar \n 0. Salir");
            switch (Console.ReadLine().Trim())
            {
                case "1":
                    Ingresar();
                    break;
                case "2":
                    Mostrar();
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("ingrese ne nuevo");
                    break;
            }
            return continuar;
        }


        static void Main(string[] args)
        {
            //1. iniciar el servidor socket en el puerto 3000
            //2. el puerto tiene que ser configurable App.config
            //3. cuando reciba un cliente, tiene que solicitar a ese cliente el nombre, texto,agregar
            //mensaje con el tipo TCP
            //IniciarServidor();
            HebraServidor hebra = new HebraServidor();
            Thread t = new Thread(new ThreadStart(hebra.Ejecutar));
            t.Start();
            //1. como atender mas de un cliente a la vez?
            //con lock()
            //2. como evito que dos clientes ingresen al archivo a la vez?
            //3. como evitar el bloqueo mutuo?
            while (Menu()) ;

        }

        static void Ingresar()
        {
            Console.WriteLine("Ingrese Nombre: ");
            string nombre = Console.ReadLine().Trim();
            Console.WriteLine("Ingrese Texto: ");
            string texto = Console.ReadLine().Trim();
            Mensaje mensaje = new Mensaje()
            {
                Nombre = nombre,
                Texto = texto,
                Tipo = "Aplicacion"
            };
            //el lock permite hacerce cargo de la concurrencia
            lock (mensajesDAL)
            {
                mensajesDAL.AgregarMensaje(mensaje);
            }

        }

        static void Mostrar()
        {
            List<Mensaje> mensajes = null;
            lock (mensajesDAL)
            {
                mensajes = mensajesDAL.ObtenerMensaje();
            }

            foreach (Mensaje mensaje in mensajes)
            {
                Console.WriteLine(mensaje);
            }

        }
    }
}
