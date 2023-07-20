using MedidoresModel;
using MedidoresModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluacion4
{
    public partial class MostrarUsuario : System.Web.UI.Page
    {
        private IUsuariosDAL usuariosDAL = new UsuariosDALDB();

        private void cargaGrilla(List<Usuario> usuarios) 
        {
            this.grillaUsuario.DataSource = usuarios;
            this.grillaUsuario.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) 
            {
            this.cargaGrilla(this.usuariosDAL.ObtenerUsuarios());
            }

        }
    }
}