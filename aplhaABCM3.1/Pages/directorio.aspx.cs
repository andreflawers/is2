using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad;
using Controlador;
using System.Data;

namespace aplhaABCM3._1.Pages
{
    public partial class directorio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            fillDropDownLists();

        }

        private void fillDropDownLists()
        {
            CCMarca oCCMarca = new CCMarca();

            DataTable oDt = oCCMarca.getMarcaAll();
            drpMarca.DataSource = oDt;
            drpMarca.DataTextField = "txt_desc";
            drpMarca.DataValueField = "cod_marca";
            drpMarca.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnMarca_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/FomMarca.aspx");
        }

        protected void btnModelo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/FormModelo.aspx");
        }

        protected void btnUnidad_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/FormUnidad_Medida.aspx");
        }
    }
}