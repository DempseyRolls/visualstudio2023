using MensajeroModel.DAL;
using ServidorSocketUtils;
using System;
using System.Configuration;
using System.Net.Sockets;
using System.Threading;

namespace Mensajero.Comunicacion
{
    public class HebraServidor
    {
        private static IMensajesDAL mensajesDAL = MensajeDALArchivos.GetInstancia();
        public void Ejecutar()
        {
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);
            ServerSocket servidor = new ServerSocket(puerto);
            Console.WriteLine("servidor iniciado en puerto {0}", puerto);
            if (servidor.Iniciar())
            {

                while (true)
                {
                    Console.WriteLine("S: Esperando Cliente.....");
                    Socket cliente = servidor.ObtenerCliente();
                    Console.WriteLine("S: Cliente recibido");
                    ClienteCom clienteCom = new ClienteCom(cliente);
                    HebraCliente clienteThread = new HebraCliente(clienteCom);
                    Thread t = new Thread(new ThreadStart(clienteThread.Ejecutar));
                    t.IsBackground = true;
                    t.Start();
                }


            }
            else
            {
                Console.WriteLine("FALLO!!!, se puede inciar server en {0}", puerto);
            }
        }
    }
}
