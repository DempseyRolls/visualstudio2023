using HolaMundoHebra.Hebra_Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HolaMundoHebra
{
    internal class Program
    {
        static void ejecutar() 
        {
            int i = Convert.ToInt32(Thread.CurrentThread.Name);
            Thread.Sleep(i*1000);
            Console.WriteLine("hola mundo desde hebra {0}",i);
            
        }

        static void ejecutarParametro(object o) 
        {
        int i=(int)o;
            Thread.Sleep(i*1000);
            Console.WriteLine("Hola hebra parametro {0}",i);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("iniciando thread");
            for (int i = 1; i < 7; i++)
            {   //formas de hacerlo sin la clase Hebra
                //Thread t = new Thread(new ThreadStart(ejecutar));
                //Thread t = new Thread(new ParameterizedThreadStart(ejecutarParametro));
                //t.Name = i.ToString();
                //t.Start(i);
                Hebra he = new Hebra(i);
                Thread t = new Thread(new ThreadStart(he.ejecutar));
                t.Start();
            }
            Console.WriteLine("iniciando");
            Console.ReadKey();




        }
    }
}
