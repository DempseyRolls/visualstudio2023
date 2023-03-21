using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcularimc
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            uint telefono;
            bool esValido;
            do
            {
                Console.WriteLine("ingrese su nombre");
                nombre = Console.ReadLine();
            } while (nombre.Equals(string.Empty));

            do {
                Console.WriteLine("ingrese su numero de telefono :");
                esValido = UInt32.TryParse(Console.ReadLine().Trim(), out telefono);

            }while(!esValido);



            Double peso = -1;
            Double estatura = -1;
            

            do
            {
                Console.WriteLine("ingrese su peso");
                esValido = Double.TryParse(Console.ReadLine().Trim(), out peso);
            }
            while (!esValido);

            do {
                Console.WriteLine("ingrese su estatura");
                esValido = Double.TryParse(Console.ReadLine().Trim(), out estatura);
            } while (!esValido);


            Console.WriteLine("su imc es: {0}", peso / (estatura * estatura));

            


            
            



            //forma mas rapida de transformar


            //esta es otra forma de leer datos
            Console.ReadKey();
        }
    }
}
