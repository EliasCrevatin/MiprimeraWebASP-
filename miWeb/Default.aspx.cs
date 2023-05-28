using System;
using System.Collections.Generic;
using System.Linq;
using System.Web; 
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miWeb
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //if (Request.QueryString["nombre"] != null)
            //{
            //    string user = txtboxBuscar.Text;
            //    lblSaludo.Text = "hola " + user;
            //}
            //else
            //{
            //    lblSaludo.Text = "LOGEATE";
            //}


            //OPERADOR TERNARIO:
            string user = Request.QueryString["nombre"] != null ? Request.QueryString["nombre"].ToString() : "Logueate";
            lblSaludo.Text = "hola " + user;

        }


    }
}