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
    public partial class IngresarMedidor : System.Web.UI.Page
    {
        private IMedidoresDAL medidorDAL = new IMedidoresDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1.obtener los datos del formulario
            string numeroSerie =this.numeroMedidorTxt.Text.Trim();
            int tipoMedidor = Convert.ToInt32(this.tipoRbl.SelectedItem.Value);

            //construir objeto
            Medidor medidor = new Medidor() 
            {
            NumeroSerie = numeroSerie,
            TipoMedidor = tipoMedidor
            };

            //llamar al DAL

            medidorDAL.AgregarMedidores(medidor);

            //mostrar mensaje de exito
            this.mensajesLbl.Text = "cliente guardado correctamente";

        }
    }
}