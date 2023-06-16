using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolaMundoASP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void saludarBtn_Click(object sender, EventArgs e)
        {
            //para los asp components, la propiedad para obtener valor es Text
            string nombre=this.nombreTXT.Text.Trim();
            //para los html elements, 
            this.mensajeH1.InnerText = "Hola "+nombre+" , andateeeeee";
        }
    }
}