using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class MedidoresDALDB : IMedidoresDAL
    {
        private MEDIDORDBEntities medidorDB = new MEDIDORDBEntities();
        public void AgregarMedidor(Medidor medidor)
        {
            this.medidorDB.Medidores.Add(medidor);
            this.medidorDB.SaveChanges();
        }

        public Medidor Obtener(int id)
        {
            return this.medidorDB.Medidores.Find(id);
        }

        public List<Medidor> ObtenerMedidores()
        {
            return this.medidorDB.Medidores.ToList();
        }

        public List<Medidor> ObtenerMedidores(string tipo)
        {//LINQ
            var query = from a in this.medidorDB.Medidores
                        where a.Tipo == tipo
                        select a;
            return query.ToList();
        }
    }
}
