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
    public partial class AgregarLectura : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALDB();
        private IUsuariosDAL usuariosDAL = new UsuariosDALDB();
        private ILecturasDAL lecturasDAL = new LecturasDALDB();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //se obtiene los medidores y usuarios de la db
            if (!IsPostBack) 
            {
                this.medidorDDL.DataSource = this.medidoresDAL.ObtenerMedidores();
                this.medidorDDL.DataTextField = "Id";
                this.medidorDDL.DataValueField = "Id";
                this.medidorDDL.DataBind();

                this.usuarioDDL.DataSource = this.usuariosDAL.ObtenerUsuarios();
                this.usuarioDDL.DataTextField = "Nombre";
                this.usuarioDDL.DataValueField = "Id";
                this.usuarioDDL.DataBind();
            }

        }

        protected void ingresaBtn_Click(object sender, EventArgs e)
        {
            Lectura lectura = new Lectura();
            lectura.Consumo = Convert.ToDecimal(this.consumoTXT.Text.Trim());
            lectura.IdMedidor = Convert.ToInt32(this.medidorDDL.SelectedItem.Value);
            lectura.IdUsuario = Convert.ToInt32(this.usuarioDDL.SelectedItem.Value);

            this.lecturasDAL.AgregarLectura(lectura);
            Response.Redirect("MostrarLectura.aspx");

        }
    }
}