using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerSumativo2.ClienteSocket;

namespace EjercicioCliente1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese servidor");
            string servidor = Console.ReadLine().Trim();
            int puerto;
            do 
            {
            Console.WriteLine("ingrese puerto");
            }while (Int32.TryParse(Console.ReadLine().Trim(),out puerto));

            Console.WriteLine("conectando...");
            ClienteSocket clienteSocket = new ClienteSocket(servidor,puerto);

            if (clienteSocket.Conectar())
            {
                GenerarComunicacion(clienteSocket);
            }
            else 
            {
            Console.WriteLine("error de comunicacion");

            }
            Console.ReadKey();
        }
        static void GenerarComunicacion(ClienteSocket clienteSocket) 
        {
            bool terminar = false;
            while (!terminar) 
            {
                Console.WriteLine("En que le podemos ayudar.. :");
                string mensaje = Console.ReadLine().Trim();
                clienteSocket.Escribir(mensaje);
                if (mensaje.ToLower() == "chao")
                {
                    terminar = true;
                }
                else 
                {
                    mensaje = clienteSocket.Leer();
                    if (mensaje = !=null) { }
                }
            }
        }
    }
}
