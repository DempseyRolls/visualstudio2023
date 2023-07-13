using System;
using System.Collections.Generic;

namespace EventosWEB.DAL
{
    public interface IAsistentesDAL
    {
        List<Asistente> ObtenerAsistentes();

        List<Asistente> ObtenerAsistentes(String estado);

        Asistente Obtener(int id);

        void AgregarAsistente(Asistente asistente);

        void EliminarAsistente(int id);

    }
}
