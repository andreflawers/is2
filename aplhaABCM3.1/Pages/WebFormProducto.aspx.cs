using Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aplhaABCM3._1.Pages
{
    public partial class WebFormProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            llenarGrillaConProcedimiento();
            panelBusAvanzada.Visible = true;

        }
        private void llenarGrillaConProcedimiento()
        {
            CCProducto oCCModelo = new CCProducto();
            DataTable oDt = oCCModelo.getListarProducto();
            if (oDt.Rows.Count > 0)
            {
                this.grd_Producto.DataSource = oDt;
                this.grd_Producto.DataBind();
            }
            else
            {
                this.lbl_mesg_01.Text = "No existen datos";
            }
        }
    }
}