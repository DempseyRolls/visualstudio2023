using Proyecto_2.comunicacion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int puerto = Convert.ToInt32( ConfigurationManager.AppSettings["puerto"]);
            Console.WriteLine("iniciando servidor en puerto {0}", puerto);
            ServerSocket servidor = new ServerSocket(puerto);

            if (servidor.Iniciar())
            {
                //OK, se puede conectar
                Console.WriteLine("servidor iniciado");

                //solicitando clientes infinitamente
                while (true) 
                {
                    Console.WriteLine("Esperando cliente...");
                    Socket socketCliente = servidor.ObtenerCliente();

                    // construir el mecanismo para escribir y leer cliente
                    ClienteCom cliente = new ClienteCom(socketCliente);
                    //aqui esta el protocolo de comunicacion
                    cliente.Escribir("Hola mundo cliente, dime tu nombre: ");
                    string respuesta = cliente.Leer();
                    Console.WriteLine("El cliente envio: {0}", respuesta);
                    cliente.Escribir("Chaoo nos vimos");
                    cliente.Desconectar();

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
