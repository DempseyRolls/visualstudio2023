using AdminPersonasModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcularimc
{
    public partial class Program
    {
        static iPersonasDAL personasDAL = new PersonasDALArchivos();
        static void MostrarPersona() 
        {
        List<Persona> personas = personasDAL.ObtenerPersonas();
            for (int i = 0; i < personas.Count; i++)
            {
                Persona actual = personas[i];
                Console.WriteLine("{0}: Nombre: {1} Peso: {2}",i,actual.Nombre,actual.Peso);
            }
        }
        static void BuscarPersona() 
        {
            Console.WriteLine("ingrese nombre");
            new PersonasDALObjetos().FiltrarPersonas(Console.ReadLine().Trim())
                             .ForEach(p=> Console.WriteLine("Nombre: {0} Peso: {1}",p.Nombre,p.Peso));

            List<Persona>personas = new PersonasDALObjetos().FiltrarPersonas(Console.ReadLine().Trim());
            foreach (Persona p in personas) 
            {
            Console.WriteLine("Nombre: {0} Peso{1}",p.Nombre,p.Peso);
            }

        }

        static void IngresarPersona()
        {
            string nombre;
            uint telefono;
            bool esValido;
            do
            {
                Console.WriteLine("ingrese su nombre");
                nombre = Console.ReadLine();
            } while (nombre.Equals(string.Empty));

            do
            {
                Console.WriteLine("ingrese su numero de telefono :");
                esValido = UInt32.TryParse(Console.ReadLine().Trim(), out telefono);

            } while (!esValido);



            Double peso = -1;
            Double estatura = -1;


            do
            {
                Console.WriteLine("ingrese su peso");
                esValido = Double.TryParse(Console.ReadLine().Trim(), out peso);
            }
            while (!esValido);

            do
            {
                Console.WriteLine("ingrese su estatura");
                esValido = Double.TryParse(Console.ReadLine().Trim(), out estatura);
            } while (!esValido);


            Persona p = new Persona() {
            Nombre = nombre,
            Estatura = estatura,
            Telefono = telefono,
            Peso = peso
            };
            p.calcularimc();
            personasDAL.AgregarPersona(p);
            
            
            Console.WriteLine("nombre: {0}", p.Nombre);
            Console.WriteLine("telefono: {0}", p.Telefono);
            Console.WriteLine("peso: {0}", p.Peso);
            Console.WriteLine("estatura: {0}", p.Estatura);
            Console.WriteLine("su IMC es: {0}", p.IMC.Texto);


            Console.ReadKey();
        }
    }
}
