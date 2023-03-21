 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola mundo");
            Console.WriteLine("Ingrese Nombre");
            //esto es un scanner
            string nombre = Console.ReadLine();
            //Console.WriteLine("su nombre es " + nombre);
            Console.WriteLine("ingrese al edad");
            string edad = Console.ReadLine();
            Console.WriteLine("su nombre es {0} y la edad es {1}",nombre,edad);
            //esta es otra forma de leer datos
            Console.ReadKey();
            
        }
    }
}
