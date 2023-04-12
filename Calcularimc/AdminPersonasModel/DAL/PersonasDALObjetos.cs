using Calcularimc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersonasModel.DAL
{
    public class PersonasDALObjetos : iPersonasDAL
    {
        //para crear la biblioteca se debe dar click derecho en la solucion, agregar, biblioteca de clases(.netframework)
        //para crear la biblioteca de clases se debe referenciar en el proyecto, en este caso se referencia en Calcularimc, referencias, click derecho agregar referencia y en este caso seleccionar AdminPersonasModel
        //luego se mueve la carpeta DTO a adminPersonasModel
        //luego se crea la carpeta DAL y la clase personasDAL que llamara las operaciones desde la carpeta operaciones

        //1. Crear una lista para guardar personas
        private static List<Persona> personas = new List<Persona>();
        //2. crear las operaciones insgresar, mostrar y buscar
        public void AgregarPersona(Persona p) 
        {
            personas.Add(p);
        }
        
        public List<Persona> ObtenerPersonas() 
        {
        return personas;
        }

        public List<Persona> FiltrarPersonas(string nombre) 
        {
           //opcion 3

            //metodo para buscar en c#
            return personas.FindAll(p => p.Nombre == nombre);
        }
        


        /*
         * opcion1
         * 
         *  public List<Persona> FiltrarPersonas(string nombre) 
        {
            List<Persona> Filtrada = new List<Persona>();
            for (int i = 0; i < personas.Count; i++)
            {
                if (personas[i].Nombre == nombre) 
                {
                    Filtrada.Add(personas[i]);
                }
            }
            return Filtrada;
        }
         */

        /*
         * opcion 2
         * public List<Persona> FiltrarPersonas(string nombre) 
        {
            List<Persona> Filtrada = new List<Persona>();
            foreach (Persona p in personas)
            {
                if (p.Nombre == nombre) 
                {
                    Filtrada.Add(p);
                }
            }
            return Filtrada;
        }
         * 
         */
    }
}
