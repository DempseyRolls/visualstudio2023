using AdminSkyNetModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallersumativo
{
    public partial class Program
    {
        static EliminadorDAL eliminadoresDAL = new EliminadorDAL();
        static void IngresarEliminador() 
        {
            string id;
            string tipo;
            string objetivo;
            bool esValido;
            bool continuar=true;
            
            do
            {
                Console.WriteLine("ingrese id");
                id = Console.ReadLine();
            } while (id.Equals(string.Empty));

            do 
            {
                Console.WriteLine("ingrese tipo");
                Console.WriteLine("1. T-1");
                Console.WriteLine("2. T-800");
                Console.WriteLine("3. T-1000");
                Console.WriteLine("4. T-3000");
                Console.WriteLine("0. Salir");
                switch (Console.ReadLine().Trim())
                {
                    case "1":
                        tipo = "T-1";
                        break;
                    case "2":
                        tipo = "T-800";
                        break;
                    case "3":
                        tipo = "T-1000";
                        break;
                    case "4":
                        tipo = "T3000";
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("presione una de las teclas indicadas");
                        break;
                }return continuar;
            }while(tipo.Equals(string.Empty));

            int prioridadBase=-1;
            Int32 anio = -1;



        
        }

        static void BuscarEliminador() 
        {
            Console.WriteLine("ingrese tipo");
            Console.WriteLine("ingrese año");
            new EliminadorDAL().FiltrarEliminadores(Console.ReadLine().Trim()).ForEach(e => Console.WriteLine("Tipo: {0} año{1}",e.Tipo,e.Anio));

            List<Eliminador>eliminadores=new EliminadorDAL().FiltrarEliminadores(Console.ReadLine().Trim());
            foreach (Eliminador e in eliminadores) 
            {
                Console.WriteLine("Tipo: {0} año{1}", e.Tipo, e.Anio);
            }
        }

        static void MostrarEliminador() 
        {
            List<Eliminador> eliminadores = eliminadoresDAL.ObtenerEliminadores();
            for (int i = 0; i < eliminadores.Count; i++)
            {
                Eliminador actual = eliminadores[i];
                Console.WriteLine("{0}: ID {1} Tipo: {2} Objetivo: {3} Prioridad base: {4} Year: {5}", actual.ID, actual.Objetivo, actual.PrioridadBase, actual.Anio);
            }
        }

        static void DestruirSkyNet() { }
    }
}
