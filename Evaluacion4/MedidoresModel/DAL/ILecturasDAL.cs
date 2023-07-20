using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface ILecturasDAL
    {
        List<Lectura> ObtenerLecturas();

        Lectura Obtener(int id);

        void AgregarLectura(Lectura lectura);
    }
}
