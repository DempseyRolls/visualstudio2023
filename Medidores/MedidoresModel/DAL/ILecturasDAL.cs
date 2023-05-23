using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface ILecturasDAL
    {
        void AgregarLectura(Lectura lectura);

        List<Lectura> ObtenerLectura();
    }
}
