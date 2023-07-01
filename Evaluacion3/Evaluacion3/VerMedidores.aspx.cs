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
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new IMedidoresDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargagrilla();
            }
        }
        //metodo para obtener los datos de la tabla y pasarselos a la grilla
        protected void cargagrilla() 
        {
        List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
            this.grillaMedidor.DataSource = medidores;
            this.grillaMedidor.DataBind();
        }
    }
}