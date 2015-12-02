using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;

namespace aplhaABCM3._1.Pages
{
    public partial class Producto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            fillGrid();

             
        }

        private void fillGrid()
        {
            List<BE.Producto> oListProducto = new List<BE.Producto>();
            for (int i = 0; i <= 6; i++)
            {
                BE.Producto oProducto = new BE.Producto(i,"prueba"+i,i*10,i*30,"subFamilia"+i,"marca"+i,"presentacion"+i);
                oListProducto.Add(oProducto);
            }
            grd_producto.DataSource = oListProducto;
            grd_producto.DataBind();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = true;
            grd_producto.Visible = false;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Productos.aspx");
        }
    }
}