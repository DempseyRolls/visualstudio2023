using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class LecturasDALDB : ILecturasDAL
    {
        private MEDIDORDBEntities medidorDB = new MEDIDORDBEntities();
        public void AgregarLectura(Lectura lectura)
        {
            this.medidorDB.Lecturas.Add(lectura);
            this.medidorDB.SaveChanges();
        }

        public Lectura Obtener(int id)
        {
            return this.medidorDB.Lecturas.Find(id);
        }

        public List<Lectura> ObtenerLecturas()
        {
            return this.medidorDB.Lecturas.ToList();
        }
    }
}
