using MedidoresModel;
using MedidoresModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluacion3
{
    public partial class MostrarLecturas : System.Web.UI.Page
    {
        private ILecturasDAL lecturasDAL = new ILecturasDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargagrilla();
            }
        }
        protected void cargagrilla()
        {
            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
            
            this.grillaLectura.DataSource = lecturas;
            this.grillaLectura.DataBind();
        }
    }
}