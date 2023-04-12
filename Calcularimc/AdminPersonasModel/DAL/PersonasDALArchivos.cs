using Calcularimc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersonasModel.DAL
{
    public class PersonasDALArchivos : iPersonasDAL
    {
        //se crean variables locales
        private static string archivo = "persona.txt";
        private static string ruta = Directory.GetCurrentDirectory() + "/" + archivo;
        public void AgregarPersona(Persona p)
        {
            //1. Crear el StreamWritter
            //2. agregar una linea 
            //3. Cerrar el StreamWritter(importante)
            try 
            {
            using (StreamWriter write = new StreamWriter(ruta, true)) 
                {
                string texto = p.Nombre + ";" + p.Estatura +";" +p.Telefono + ";"+ p.Peso + ";";
                    write.WriteLine(texto);
                    //el write.flush() envia y confirma los datos
                    write.Flush();
                }
            } 
            catch (Exception ex) 
            {
                Console.WriteLine("error al escribir el archivo" + ex.Message);
            }
        }

        public List<Persona> FiltrarPersonas(string nombre)
        {
            return ObtenerPersonas().FindAll(p => p.Nombre == nombre);
        }

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> personas = new List<Persona>();
            using (StreamReader reader = new StreamReader(ruta)) 
            {
                string texto;
                do
                {
                    //leer desde el archivo hasta que no haya nada
                    texto = reader.ReadLine();
                    if (texto != null) 
                    { 
                    //nombre, estatura, telefono,peso
                    string[] textoArr = texto.Trim().Split(';');
                    string nombre = textoArr[0];
                    double estatura = Convert.ToDouble(textoArr[1]);
                    uint telefono = (uint)Convert.ToInt32(textoArr[2]);
                    double peso = Convert.ToDouble(textoArr[3]);
                    // crear persona

                    Persona p = new Persona()
                    {
                        Nombre = nombre,
                        Estatura = estatura,
                        Telefono = telefono,
                        Peso = peso
                    };
                    //calcular imc
                    p.calcularimc();

                    //agregar a ala lista
                    personas.Add(p);

                    }

                } while (texto != null);
                
            }
            return personas;
        }
    }
}
