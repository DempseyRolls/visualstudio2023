using ClienteMundito.Comunicacion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMundito
{
    public class Program
    {
        static void Main(string[] args)
        {
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);
            string servidor = ConfigurationManager.AppSettings["servidor"];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("conectando a servidor {0} en puerto {1}", servidor, puerto);
            ClienteSocket clientesocket = new ClienteSocket(servidor, puerto);
            if (clientesocket.Conectar())
            {
                Console.WriteLine("conectando.......");
                //recibir lo que envia el servidor 
                string mensaje = clientesocket.Leer();
                Console.WriteLine("M : {0}", mensaje);
                string nombre = Console.ReadLine().Trim();
                clientesocket.Escribir(nombre);
                mensaje = clientesocket.Leer();
                Console.WriteLine("M : {0}", mensaje);
                clientesocket.Desconectar();
            }
            else 
            {
            Console.WriteLine("Error de comunicacion");
            }
            Console.ReadKey();
        }
    }
}
