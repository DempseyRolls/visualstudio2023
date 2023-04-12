using Tallersumativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSkyNetModel.DAL
{
    public class EliminadorDAL
    {
        //clear lista para guardar eliminadores
        private static List<Eliminador> eliminadores = new List<Eliminador>();

        public void AgregarEliminador(Eliminador e) 
        {
        eliminadores.Add(e);
        }

        public List<Eliminador>ObtenerEliminadores() 
        {
        return eliminadores;
        }

        public List<Eliminador> FiltrarEliminadores(string id) 
        {
        return eliminadores.FindAll(e=>e.ID ==id);
        }

    }
}
