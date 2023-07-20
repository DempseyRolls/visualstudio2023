using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class UsuariosDALDB : IUsuariosDAL
    {
        private MEDIDORDBEntities medidorDB = new MEDIDORDBEntities();
        public void AgregarUsuario(Usuario usuario)
        {
            this.medidorDB.Usuarios.Add(usuario);
            this.medidorDB.SaveChanges();
        }

        public Usuario Obtener(int id)
        {
            return this.medidorDB.Usuarios.Find(id);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return this.medidorDB.Usuarios.ToList();
        }
    }
}
