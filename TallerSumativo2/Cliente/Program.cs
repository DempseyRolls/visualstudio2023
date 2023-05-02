using Cliente.cliente;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
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
                // Bucle para mantener la conexión hasta que se envíe la palabra "chao"
                while (true)
                {
                    string input = Console.ReadLine().Trim();
                    clientesocket.Escribir(input);

                    if (input.Equals("chao"))
                    {
                        clientesocket.Desconectar();
                        break;
                    }

                    mensaje = clientesocket.Leer();
                    Console.WriteLine("M : {0}", mensaje);
                }



            }
                else
                {
                    Console.WriteLine("Error de comunicacion");
                }
                Console.ReadKey();
            

        }
    }
}
