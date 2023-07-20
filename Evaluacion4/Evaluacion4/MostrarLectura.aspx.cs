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
    public partial class MostrarLectura : System.Web.UI.Page
    {
        private ILecturasDAL lecturasDAL = new LecturasDALDB();

        private void cargaGrilla(List<Lectura> lecturas) 
        {
            this.grillaLectura.DataSource = lecturas;
            this.grillaLectura.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                this.cargaGrilla(this.lecturasDAL.ObtenerLecturas());
            }

        }
    }
}