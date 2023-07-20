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
    public partial class AgregarUsuario : System.Web.UI.Page
    { private IUsuariosDAL usuariosDAL = new UsuariosDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ingresaBtn_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = this.nombreTXT.Text.Trim();
            usuario.Rut = this.rutTXT.Text.Trim();
            usuario.Password = this.passwordTXT.Text.Trim();
            usuario.Email = this.emailTXT.Text.Trim();

            this.usuariosDAL.AgregarUsuario(usuario);
            Response.Redirect("MostrarUsuario.aspx");

        }
    }
}