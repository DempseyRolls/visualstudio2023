﻿using StarCapModel;
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
                List<Cliente> clientes = clientesDAL.Obtener();
                this.grillaCliente.DataSource = clientes;
                this.grillaCliente.DataBind();
            }
            

        }
    }
}