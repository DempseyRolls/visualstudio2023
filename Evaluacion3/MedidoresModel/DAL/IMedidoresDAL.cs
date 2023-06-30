
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface IMedidoresDAL
    {
        //Método ObtenerMedidores que retorna una lista estática de medidores

        List<Medidor> ObtenerMedidores();

        void AgregarMedidores(Medidor medidor);




    }
}
