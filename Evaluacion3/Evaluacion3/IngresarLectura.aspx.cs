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
    public partial class IngresarLectura : System.Web.UI.Page
    {
        private IMedidoresDAL medidorDAL = new IMedidoresDALObjetos();
        private ILecturasDAL lecturaDAL = new ILecturasDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidores = medidorDAL.ObtenerMedidores();
                this.MedidorDbl.DataSource = medidores;
                this.MedidorDbl.DataTextField = "numeroSerie";
                this.MedidorDbl.DataValueField = "tipoMedidor";
                this.MedidorDbl.DataBind();
                
            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {

            //obtiene el valor del dropdown
            string medidorValor = this.MedidorDbl.SelectedValue;
            //obtiene el valor del texto del dropdown
            string medidorTexto = this.MedidorDbl.SelectedItem.Text;
            // construir el objeto de tipo medidor
            List<Medidor> medidores = medidorDAL.ObtenerMedidores();
            Medidor medidor = medidores.Find(b => b.NumeroSerie == this.MedidorDbl.SelectedItem.Value);
            //obtener los datos del formulario
            DateTime fecha = this.fechaTxt.SelectedDate;
            string hora = this.horaTxt.Text.Trim();
            string minutos = this.minutosTxt.Text.Trim();
            string horaCompleta = hora + ":" + minutos;
            double valorConsumo = Convert.ToDouble(this.valorConsumoTxt.Text.Trim());

            // construir el objeto de tipo lectura
            Lectura lectura = new Lectura()
            {
                MedidorLectura = medidor,
                FechaLectura = fecha,
                HoraLectura = horaCompleta,
                ValorConsumo = valorConsumo

            };

            //llamar al dal
            lecturaDAL.AgregarLectura(lectura);

            //4.mostrar mensaje de exito
            this.mensajesLbl.Text = "lectura guardada correctamente";

        }
    }
}