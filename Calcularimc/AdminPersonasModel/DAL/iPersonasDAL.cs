using Calcularimc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersonasModel.DAL
{
    public interface iPersonasDAL
    {
        void AgregarPersona(Persona p);

        List<Persona> ObtenerPersonas();

        List<Persona> FiltrarPersonas( string nombre);
    }
}
