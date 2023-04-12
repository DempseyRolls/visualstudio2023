using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallersumativo
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            while (Menu());
        }

        static bool Menu() 
        {
            bool continuar = true;
            Console.WriteLine("1. Ingresar eliminador");
            Console.WriteLine("2. Buscar eliminador");
            Console.WriteLine("3. Mostrar eliminador");
            Console.WriteLine("4. Destruir SkyNet");
            Console.WriteLine("0. Salir");

            switch (Console.ReadLine().Trim())
            {
                case "1":
                    IngresarEliminador();
                    break;
                case "2":
                    BuscarEliminador();
                    break;
                case "3":
                    MostrarEliminador();
                    break;
                case "4":
                    DestruirSkyNet();
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Apriete bien una tecla");
                    break;

            }
            return continuar;
        }
    }
}
