using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TallerSumativo2.ServidorSocketUtils;

namespace TallerSumativo2
{
    public class Program
    {
        static void GenerarComunicacion(ClienteCom clientecom)
        {
            bool terminar = false;
            while (!terminar)
            {
                string mensaje = clientecom.Leer();
                if (mensaje != null)
                {
                    Console.WriteLine("Cli: {0}", mensaje);
                    if (mensaje.ToLower() == "chao")
                    {
                        terminar = true;

                    }
                    else
                    {
                        Console.WriteLine("Ingrese mensaje: ");
                        mensaje = Console.ReadLine().Trim();
                        clientecom.Escribir(mensaje);
                        if (mensaje.ToLower() == "chao")
                        {
                            terminar = true;
                        }
                    }
                }
                if (terminar) 
                {
                clientecom.Desconectar();
                }
            }
        }
        static void Main(string[] args)
        {
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);
            Console.WriteLine("iniciando servidor en puerto {0}", puerto);
            ServerSocket serverSocket = new ServerSocket(puerto);

            if (serverSocket.Iniciar())
            {
                //OK, se puede conectar
                

                //solicitando clientes infinitamente
                while (true)
                {
                    Console.WriteLine("esperando cliente...");
                    
                    Socket socketCliente = serverSocket.ObtenerCliente();
                    Console.WriteLine("cliente recibido");

                    // comunicacion con el cliente

                    ClienteCom clienteCom = new ClienteCom(socketCliente);
                    GenerarComunicacion(clienteCom);

                  
                    //el comando <Cr><LF> se usa para contestar al servidor con el hercules

                }

            }
            else
            {
                Console.WriteLine("ERROR!!!, el puerto {0} esta en uso", puerto);
            }
        }
    }
            
}
