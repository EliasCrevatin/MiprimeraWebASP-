using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["nombre"] != null)
            {
                string user = Request.QueryString["nombre"].ToString();
                lblUser.Text = user + " tu ingreso fue exitoso";
            } 

        }
    }
}