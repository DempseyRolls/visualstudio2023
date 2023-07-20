using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface IMedidoresDAL
    {
        List<Medidor> ObtenerMedidores();

        List<Medidor> ObtenerMedidores(string tipo);

        Medidor Obtener(int id);
        
        void AgregarMedidor(Medidor medidor);
    }
}
