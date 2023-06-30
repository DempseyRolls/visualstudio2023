using StarCapModel;
using StarCapModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarCap
{
    public partial class VerClientes : System.Web.UI.Page
    {
        private IClientesDAL clientesDAL = new IClientesDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            // !IsPostBack es como si fuera un get
            if (!IsPostBack) 
            {
                cargagrilla();
            }
            

        }
        //metodo para obtener los datos de la tabla y pasarselos a la grilla
        protected void cargagrilla() 
        {
            List<Cliente> clientes = clientesDAL.Obtener();
            this.grillaCliente.DataSource = clientes;
            this.grillaCliente.DataBind();
        }
        protected void grillaCliente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "elimina") 
            {
                //significa que el usuario apreto boton
                //por lo tanto eliminar el cliente
                string rut = Convert.ToString(e.CommandArgument);
                clientesDAL.Eliminar(rut);
                cargagrilla();


            }

        }
    }
}