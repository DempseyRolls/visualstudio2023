using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosWEB.DAL
{
    public class AsistentesDALDB : IAsistentesDAL
    {
        private EventosDBEntities5 eventosDB = new EventosDBEntities5();
        public void AgregarAsistente(Asistente asistente)
        {
            this.eventosDB.Asistentes.Add(asistente);
            this.eventosDB.SaveChanges();
        }

        public void EliminarAsistente(int id)
        {
            //buscar el asistente asociado al id
            Asistente asistente = this.eventosDB.Asistentes.Find(id);
            //destruir asistente
            this.eventosDB.Asistentes.Remove(asistente);
            this.eventosDB.SaveChanges();
        }

        public Asistente Obtener(int id)
        {
            return this.eventosDB.Asistentes.Find(id);
        }

        public List<Asistente> ObtenerAsistentes()
        {
            return this.eventosDB.Asistentes.ToList();
        }

        //actualizar nombre, apellido y edad
        public void Actualizar(Asistente a) 
        {
        Asistente aOriginal = this.eventosDB.Asistentes.Find(a.Id);
            aOriginal.Nombre = a.Nombre;
            aOriginal.Apellido = a.Apellido;
            aOriginal.Edad = a.Edad;
            this.eventosDB.SaveChanges();
        }
        public List<Asistente> ObtenerAsistentes(string estado)
        {
            //linq el query esta como invertido
            var query = from a in this.eventosDB.Asistentes
                        where a.Estado == estado
                        select a;
            //lista de asistentes obtenidos con el query
            return query.ToList();
        }
    }
}
