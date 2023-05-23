using MedidoresModel.DAL;
using MedidoresModel.DTO;
using ServidorSocketUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medidores.Comunicacion
{
    public class HebraCliente
    {
        private ClienteCom clienteCom;
        private ILecturasDAL lecturasDAL = LecturasDALArchivos.GetInstancia();

        public HebraCliente(ClienteCom clienteCom)
        {
            this.clienteCom = clienteCom;
        }

        public void ejecutar() 
        {
            clienteCom.Escribir("Ingrese numero de medidor: ");
            string nroMedidor = clienteCom.Leer();
            clienteCom.Escribir("Ingrese fecha:YYYY-MM-DD hh:mm:ss ");
            string fecha = clienteCom.Leer();
            clienteCom.Escribir("Ingrese el valor del consumo: ");
            string valorConsumo = clienteCom.Leer();
            Lectura lectura = new Lectura()
            {
                NroMedidor = (int)Convert.ToInt64(nroMedidor),
                Fecha = fecha,
                ValorConsumo = (double)Convert.ToDouble(valorConsumo)
            };
            lock (lecturasDAL)
            {
                lecturasDAL.AgregarLectura(lectura);
            }
            clienteCom.Desconectar();

        }
    }
}
