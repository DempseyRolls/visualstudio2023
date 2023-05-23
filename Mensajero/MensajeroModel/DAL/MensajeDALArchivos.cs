using MensajeroModel.DTO;
using System;
using System.Collections.Generic;
using System.IO;

namespace MensajeroModel.DAL
{

    public class MensajeDALArchivos : IMensajesDAL
    {

        //implementar singleton: (para trabajar con las hebras)
        //1. contructor tiene que ser privado
        private MensajeDALArchivos() { }

        //2. debe poseer un atributo del mismo tipo de la clase y estatico
        private static MensajeDALArchivos instancia;
        //3. tener un metodo get instance , que devuelva una referencia al atributo
        public static IMensajesDAL GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new MensajeDALArchivos();
            }
            return instancia;
        }
        
        //esto se agrega cuando se implementa la interfaz IMensajesDAL




        private static string url = Directory.GetCurrentDirectory();
        private static string archivo = url + "/mensajes.txt";
        public void AgregarMensaje(Mensaje mensaje)
        {
            try
            {
                //en este caso se hace todo en un solo paso
                using (StreamWriter write = new StreamWriter(archivo, true))
                {
                    write.WriteLine(Convert.ToString( mensaje.Nombre) + ";" + mensaje.Texto + ";" + Convert.ToString( mensaje.Tipo));
                    write.Flush();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public List<Mensaje> ObtenerMensaje()
        {
            List<Mensaje> lista = new List<Mensaje>();
            try
            {
                using (StreamReader read = new StreamReader(archivo))
                {
                    string texto = "";
                    do
                    {
                        texto = read.ReadLine();
                        if (texto != null)
                        {
                            string[] arr = texto.Trim().Split(';');
                            Mensaje mensaje = new Mensaje()
                            {
                                Nombre = arr[0],
                                Texto = arr[1],
                                Tipo = arr[2]
                            };
                            lista.Add(mensaje);
                        }
                    } while (texto != null);
                }
            }
            catch (Exception ex)
            {
                lista = null;
            }
            return lista;
        }
    }
}
