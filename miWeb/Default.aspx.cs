using System;
using System.Collections.Generic;
using System.Linq;
using System.Web; 
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace miWeb
{
    public partial class _default : System.Web.UI.Page
    {
        public string user {get;set;}
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                txtboxBuscar.Text = "Ingrese su Nombre:";
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
            user = Request.QueryString["nombre"] != null ? Request.QueryString["nombre"].ToString() : "";
            lblSaludo.Text = "hola " + user;
        }


    }
}