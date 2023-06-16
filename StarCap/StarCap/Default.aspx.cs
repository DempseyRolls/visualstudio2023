using StarCapModel;
using StarCapModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarCap
{
    public partial class Default : System.Web.UI.Page
    {
        private IClientesDAL clienteDAL = new IClientesDALObjetos();

        private IBebidasDAL bebidaDAL = new BebidasDALObjetos();

        //metodo a utilizar cuando se carga el form
        //cuando es una peticion GET (!PostBack)
        //cuando es una peticion POST (PostBack)
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
            List<Bebida> bebidas = bebidaDAL.ObtenerBebidas();
                this.bebidaDbl.DataSource = bebidas;
                this.bebidaDbl.DataTextField = "Nombre";
                this.bebidaDbl.DataValueField = "Codigo";
                this.bebidaDbl.DataBind();
            }

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1.obtener los datos del formulario
            string nombre = this.nombreTxt.Text.Trim();
            string rut = this.rutTxt.Text.Trim();
            //obtiene el valor del dropdown
            string bebidaValor = this.bebidaDbl.SelectedValue;
            //obtiene el valor del texto del dropdown
            string bebidaTexto = this.bebidaDbl.SelectedItem.Text;

            int nivel = Convert.ToInt32(this.nivelRbl.SelectedItem.Value);
            //2.1 construir el objeto de tipo bebida
            List<Bebida> bebidas = bebidaDAL.ObtenerBebidas();
            Bebida bebida = bebidas.Find(b => b.Codigo == this.bebidaDbl.SelectedItem.Value);
            //2.2 construir el objeto de tipo cliente
            Cliente cliente = new Cliente()
            {
                Nombre= nombre,
                Rut= rut,
                Nivel= nivel,
                BebidaFavorita=bebida

            };
            //3.llamar al dal
            clienteDAL.Agregar(cliente);

            //4.mostrar mensaje de exito
            this.mensajesLbl.Text = "cliente guardado correctamente";

        }
    }
}