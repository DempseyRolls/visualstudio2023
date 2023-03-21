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
            int edad = -1;
            Console.WriteLine("ingrese al edad");
            string edadTx = Console.ReadLine().Trim();
            bool esValido = Int32.TryParse(edadTx, out edad);
            //el tryParse es lo mismo que un trycatch para intantar convertir un dato en otro 
            if (!esValido)
            {
                Console.WriteLine("ingrese bien el nombre");
            }
            else
            {
                Console.WriteLine("su nombre es {0} y la edad es {1}", nombre, edad);
            }
            //Trim = '    32    ' => '32'
            //TrimStart = '    32    ' => '32   '
            //TrimEnd = '    32    ' => '   32'
            
            
            
            //forma mas rapida de transformar

            
            //esta es otra forma de leer datos
            Console.ReadKey();
            
        }
    }
}
