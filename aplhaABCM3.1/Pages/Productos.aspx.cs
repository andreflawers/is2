using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador;
using Entidad;

namespace aplhaABCM3._1.Pages
{
    public partial class Producto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            fillDropDownLists();
            fillGrid();

             
        }

        private void fillGrid()
        {
            CCProducto oCCProducto = new CCProducto();
            grd_producto.DataSource = oCCProducto.getProductoList();
            grd_producto.DataBind();
        }
        private void fillDropDownLists()
        {
            
            //Fill SubFamilia
            CCSubFamilia oCCSubFamilia = new CCSubFamilia();
            dpwSubFamilia.DataSource = oCCSubFamilia.getSubFamiliaAll();
            dpwSubFamilia.DataValueField = "Id_SubFamilia";
            dpwSubFamilia.DataTextField = "nombre_SubFamilia";
            dpwSubFamilia.DataBind();

            //Fill Marca
            CCMarca oCCMarca = new CCMarca();
            dpwMarca.DataSource = oCCMarca.getMarcaAll();
            dpwMarca.DataValueField = "id_marca";
            dpwMarca.DataTextField = "nombre_marca";
            dpwMarca.DataBind();

            //Fill Presentacion
            CCPresentacion oCCPresentacion = new CCPresentacion();
            dpwPresentacion.DataSource = oCCPresentacion.getPresentacionAll();
            dpwPresentacion.DataValueField = "id_Presentacion";
            dpwPresentacion.DataTextField = "caracterstica_Presentacion";
            dpwPresentacion.DataBind();

           
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

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            CEProducto oCEProducto = new CEProducto();
            oCEProducto.id_Producto = 0;
            oCEProducto.descripción_Producto = txtDescripcion.Text;
            oCEProducto.cantidad_Producto = int.Parse(txtCantidad.Text);
            oCEProducto.precio_Producto = double.Parse(txtPrecio.Text);
            oCEProducto.Id_SubFamilia = dpwSubFamilia.SelectedValue.ToString().Trim();
            oCEProducto.id_marca = dpwMarca.SelectedValue.ToString().Trim();
            oCEProducto.id_Presentacion = dpwPresentacion.SelectedValue.ToString().Trim();
             CCProducto oCCProducto = new CCProducto();
             int id = oCCProducto.productoCreate(oCEProducto);
             if (id != 0)
             {
                 clearTxt();
                 pnlForm.Visible = false;
                 fillGrid();
                 grd_producto.Visible = true;
             }
             else
             {
                 clearTxt();
                 lblError.Text = "Error al insertar";
             }

        }
        private void clearTxt()
        {
            txtDescripcion.Text = "";
            txtIdProducto.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
        }
    }
}