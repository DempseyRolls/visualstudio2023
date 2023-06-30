
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class IMedidoresDALObjetos : IMedidoresDAL
    {

        private static List<Medidor> medidores = new List<Medidor>();
        public void AgregarMedidores(Medidor medidor)
        {
            medidores.Add(medidor);
        }

        public List<Medidor> ObtenerMedidores()
        {
            return medidores;
        }
    }
}

