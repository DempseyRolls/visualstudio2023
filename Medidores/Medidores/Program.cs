using Medidores.Comunicacion;
using MedidoresModel.DAL;
using MedidoresModel.DTO;
using ServidorSocketUtils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Medidores
{
    public class Program
    {
        private static ILecturasDAL lecturasDAL = LecturasDALArchivos.GetInstancia();

        //se crea menu
        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("seleccione una opcion");
            Console.WriteLine(" 1. Ingresar Lectura \n 2. Mostrar Lecturas \n 0. Salir");
            switch (Console.ReadLine().Trim())
            {
                case "1":
                    Ingresar();
                    break;
                case "2":
                    Mostrar();
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Ingrese de Nuevo");
                    break;
            }
            return continuar;
        }
        static void Main(string[] args)
        {
            HebraServidor hebra = new HebraServidor();
            Thread t = new Thread(new ThreadStart(hebra.Ejecutar));
            t.Start();
            while (Menu()) ;

        }

        static void Ingresar() 
        {
            Console.WriteLine("Ingrese medidor: ");
            string nroMedidor= Console.ReadLine().Trim();
            Console.WriteLine("Ingrese fecha:YYYY-MM-DD hh:mm:ss ");
            string fecha = Console.ReadLine().Trim();
            Console.WriteLine("Ingrese el valor del consumo: ");
            string valorConsumo = Console.ReadLine().Trim();
            Lectura lectura = new Lectura()
            {
                NroMedidor = (int)Convert.ToInt64(nroMedidor),
                Fecha = fecha,
                ValorConsumo =(double)Convert.ToDouble(valorConsumo)
            };
            lock (lecturasDAL) 
            {
            lecturasDAL.AgregarLectura(lectura);
            }
        }

        static void Mostrar() 
        {
            List<Lectura> lecturas = null;
            lock (lecturasDAL) 
            {
            lecturas=lecturasDAL.ObtenerLectura();
            }
            foreach(Lectura lectura in lecturas)
            {
                Console.WriteLine(lectura);
            }
        }
    }
}
