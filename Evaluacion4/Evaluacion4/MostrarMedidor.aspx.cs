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
    public partial class MostrarMedidor : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALDB();

        private void cargaGrilla(List<Medidor> medidores) 
        {
            this.grillaMedidor.DataSource = medidores;
            this.grillaMedidor.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                this.cargaGrilla(this.medidoresDAL.ObtenerMedidores());
            }
        }

        protected void tipoDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filtro
            string tipo = this.tipoDDL.SelectedValue;
            List<Medidor> medidores = this.medidoresDAL.ObtenerMedidores(tipo);
            //se carga la grilla con el filtro aplicado
            this.cargaGrilla(medidores);

        }
    }
}