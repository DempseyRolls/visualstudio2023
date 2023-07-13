using EventosModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosWebTest
{
    public partial class AgregarAsistente : System.Web.UI.Page
    {
        private IRegionesDAL regionesDAL = new RegionesDALDB();
        private IAsistentesDAL asistentesDAL = new AsistentesDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            //se obtiene las regiones de la db
            //en webconfig pegar el connectionStrings del app.config de EventosModel
            if (!IsPostBack)
            {
                this.regionDDL.DataSource = this.regionesDAL.ObtenerRegiones();
                this.regionDDL.DataTextField = "Nombre";
                this.regionDDL.DataValueField = "Id";
                this.regionDDL.DataBind();
            }
        }
    }
}