using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class LecturasDALArchivos : ILecturasDAL
    {
        //singleton
        private LecturasDALArchivos() { }

        private static LecturasDALArchivos instancia;

        public static ILecturasDAL GetInstancia() 
        {
            if (instancia == null)
            {
                instancia = new LecturasDALArchivos();
            }
            return instancia;
        }


        private static string url = Directory.GetCurrentDirectory();
        private static string archivo = url + "/lecturas.txt";

        public void AgregarLectura(Lectura lectura)
        {
            try 
            {
                using (StreamWriter write = new StreamWriter(archivo, true))
                {
                    write.WriteLine(lectura.NroMedidor + "|" + lectura.Fecha + "|" +  lectura.ValorConsumo);
                    write.Flush();
                }
            }
            catch (Exception ex) 
            {
                
            }
        }

        public List<Lectura> ObtenerLectura()
        {
            List<Lectura> lista = new List<Lectura>();
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
                            string[] arr = texto.Trim().Split('|');
                            Lectura lectura = new Lectura()
                            {
                                
                                NroMedidor = (int)Convert.ToInt64( arr[0]),
                                Fecha = arr[1],
                                ValorConsumo = (double)Convert.ToDouble( arr[2])

                            };
                            lista.Add(lectura);
                        }
                    } while (texto!=null);
                }
            }catch(Exception ex) 
            {
                lista = null;
            }
            return lista;
        }
    }
}
