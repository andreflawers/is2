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
        private string Modo_Edicion
        {
            get
            {
                object o = ViewState["Modo_Edicion"];
                return ((o == null) ? null : o.ToString());
            }
            set
            {
                ViewState["Modo_Edicion"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            llenarGrillaConProcedimiento();
            Panel_mant_producto.Visible = false;
        }
        private void llenarGrillaConProcedimiento()
        {
            CCProducto oCCProducto = new CCProducto();
            DataTable oDt = oCCProducto.getproductoAll();

            if (oDt.Rows.Count > 0)
            {
                this.grd_producto.DataSource = oDt;
                this.grd_producto.DataBind();
            }
            else
            {
                this.lbl_mesg_01.Text = "No existen datos";
            }
        }
        private void fillDropDownListMarca()
        {
            CCMarca oCCMarca = new CCMarca();

            DataTable oDt = oCCMarca.getMarcaAll();
            drpMarca.DataSource = oDt;
            drpMarca.DataTextField = "txt_desc";
            drpMarca.DataValueField = "cod_marca";
            drpMarca.DataBind();
        }
        private void fillDropDownListModelo()
        {
            CCModelo oCCModelo = new CCModelo();
            DataTable oDt = oCCModelo.getmodeloAll();
            drpModelo.DataSource = oDt;
            drpModelo.DataTextField = "txt_desc";
            drpModelo.DataValueField = "cod_modelo";
            drpModelo.DataBind();
        }
        private void fillDropDownListUnidadMedida()
        {
            CCUnidad_Medida oCCUnidad = new CCUnidad_Medida();
            DataTable oDt = oCCUnidad.getunidadMedidaAll();
            drpUnidad.DataSource = oDt;
            drpUnidad.DataTextField = "txt_desc";
            drpUnidad.DataValueField = "cod_um";
            drpUnidad.DataBind();
        }
        private void fillDropDownListCategoria()
        {
            CCCategoria oCCCategoria = new CCCategoria();
            DataTable oDt = oCCCategoria.getcategoriaAll();
            drpCategoria.DataSource = oDt;
            drpCategoria.DataTextField = "txt_desc";
            drpCategoria.DataValueField = "cod_cate";
            drpCategoria.DataBind();
        }
        private void fillDropDownListClase()
        {
            CCClase oCCClase = new CCClase();
            DataTable oDt = oCCClase.getclaseAll();
            drpClase.DataSource = oDt;
            drpClase.DataTextField = "txt_desc";
            drpClase.DataValueField = "cod_clase";
            drpClase.DataBind();
        }
        private void fillDropDownListTipoProducto()
        {
            CCTipoProducto oCCTipo = new CCTipoProducto();
            DataTable oDt = oCCTipo.gettipoProductoAll();
            drpTipoProducto.DataSource = oDt;
            drpTipoProducto.DataTextField = "txt_desc";
            drpTipoProducto.DataValueField = "cod_tipo";
            drpTipoProducto.DataBind();
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
        protected void btnClase_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/FormClase.aspx");
        }
        protected void btnCate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/FormCategoria.aspx");
        }

        protected void btnTipoProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/FormTipoProducto.aspx");
        }

        protected void lkb_nuevo_producto_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Registrando datos del producto";
            fillDropDownListMarca();
            fillDropDownListModelo();
            fillDropDownListUnidadMedida();
            fillDropDownListCategoria();
            fillDropDownListClase();
            fillDropDownListTipoProducto();
            this.Modo_Edicion = "N";
            Panel_mant_producto.Visible = true;
        }

        protected void btn_grabar_Click(object sender, EventArgs e)
        {
            Result_transaccion obj_transac = new Result_transaccion();
            CEProducto obj_prod = new CEProducto();
            obj_prod.cod_cate = drpCategoria.SelectedValue;
            obj_prod.cod_clase = drpClase.SelectedValue;
            obj_prod.cod_tipo = drpTipoProducto.SelectedValue;
            obj_prod.cod_marca = drpMarca.SelectedValue;
            obj_prod.cod_modelo = drpModelo.SelectedValue;
            obj_prod.cod_um_principal = drpUnidad.SelectedValue;
            CCProducto.Producto_Grabar(Modo_Edicion, obj_prod, obj_transac);
            if (obj_transac.resultado == 1)
            {
                if (this.Modo_Edicion == "N")
                {
                    this.Modo_Edicion = "E";
                }
                lbl_confirmacion.ForeColor = System.Drawing.Color.Green;
                lbl_confirmacion.Text = "Se grabó la información con éxito";

                llenarGrillaConProcedimiento();
            }
            else
            {
                lbl_confirmacion.ForeColor = System.Drawing.Color.Red;
                lbl_confirmacion.Text = "No se pudo grabar la información" + obj_transac.msg_error;
            }
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Panel_mant_producto.Visible = false;
        }

        protected void lkb_editar_Click(object sender, EventArgs e)
        {
            LinkButton lnk = (LinkButton)sender;
            string codigo = lnk.CommandArgument;
            Result_transaccion obj_transac = new Result_transaccion();
            CEProducto obj_prod = CCProducto.Producto_Consultar_datos(obj_transac, codigo);
            if (obj_transac.resultado == 1)
            {
                lbl_titulo.Text = "Consultando datos del producto";
                drpCategoria.Text = obj_prod.cod_cate;
                drpClase.Text = obj_prod.cod_clase;
                drpTipoProducto.Text = obj_prod.cod_tipo;
                drpMarca.Text = obj_prod.cod_marca;
                drpModelo.Text = obj_prod.cod_modelo;
                drpUnidad.Text = obj_prod.cod_um_principal;
                lbl_confirmacion.Text = "";
                this.Modo_Edicion = "E";
            }
            else
            {
                //txt_id_empresa.Text = "";
                //// fillDropDownListCategoria();
                //lbl_cod_tipo.Text = "";
                //txt_txt_abrv.Text = "";
                //txt_txt_desc.Text = "";
                lbl_confirmacion.ForeColor = System.Drawing.Color.Red;
                lbl_confirmacion.Text = obj_transac.msg_error;
            }

            Panel_mant_producto.Visible = true;
        }

        protected void lkb_eliminar_Click(object sender, EventArgs e)
        {
            LinkButton lkb = (LinkButton)sender;
            string codigo = lkb.CommandArgument;

            Result_transaccion obj_transac = new Result_transaccion();
            CCProducto.Producto_Eliminar(obj_transac, codigo);
            if (obj_transac.resultado == 1)
            {
                llenarGrillaConProcedimiento();
                lbl_mesg_01.Text = "";
            }
            else
            {
                lbl_mesg_01.Text = obj_transac.msg_error;
            }
        }
    }
}