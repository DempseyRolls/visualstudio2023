using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosWEB.DAL
{
    public class RegionesDALDB : IRegionesDAL
    {
        private EventosDBEntities5 eventosDB = new EventosDBEntities5();
        public List<Region> ObtenerRegiones()
        {
            //obtiene las regiones y las entrega en una lista
            return this.eventosDB.Regions.ToList();
        }
    }
}
