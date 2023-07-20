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
    public partial class AgregarMedidor : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ingresaBtn_Click(object sender, EventArgs e)
        {
            Medidor medidor = new Medidor();
            medidor.Tipo = this.tipoRbl.Text.Trim();

            this.medidoresDAL.AgregarMedidor(medidor);
            Response.Redirect("MostrarMedidor.aspx");

        }
    }
}