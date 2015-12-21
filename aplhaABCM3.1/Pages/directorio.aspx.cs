using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
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
            drpClase.Items.Insert(0, new ListItem("Elija una categoria..", "0"));
            drpTipoProducto.Items.Insert(0, new ListItem("Elija una clase..", "0"));
            drpModelo.Items.Insert(0, new ListItem("Elija una marca..", "0"));
            Modo_Edicion = "N";
            fillDropDownListCategoria();
            fillDropDownListMarca();
            fillDropDownListUnidadMedida();
        }
        
        private void fillDropDownListMarca()
        {
            CCMarca oCCMarca = new CCMarca();

            DataTable oDt = oCCMarca.getMarcaAll();
            drpMarca.DataSource = oDt;
            drpMarca.DataTextField = "txt_desc";
            drpMarca.DataValueField = "cod_marca";
            drpMarca.DataBind();
            drpMarca.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
        }
        private void fillDropDownListModelo()
        {
            CCModelo oCCModelo = new CCModelo();
            string cod = drpMarca.SelectedValue;
            DataTable oDt = oCCModelo.getmodeloAnterior(cod);
            drpModelo.DataSource = oDt;
            drpModelo.DataTextField = "txt_desc";
            drpModelo.DataValueField = "cod_modelo";
            drpModelo.DataBind();
            drpModelo.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
        }
        private void fillDropDownListUnidadMedida()
        {
            CCUnidad_Medida oCCUnidad = new CCUnidad_Medida();
            DataTable oDt = oCCUnidad.getunidadMedidaAll();
            drpUnidad.DataSource = oDt;
            drpUnidad.DataTextField = "txt_desc";
            drpUnidad.DataValueField = "cod_um";
            drpUnidad.DataBind();
            drpUnidad.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
        }
        private void fillDropDownListCategoria()
        {
            CCCategoria oCCCategoria = new CCCategoria();
            DataTable oDt = oCCCategoria.getcategoriaAll();
            drpCategoria.DataSource = oDt;
            drpCategoria.DataTextField = "txt_desc";
            drpCategoria.DataValueField = "cod_cate";
            drpCategoria.DataBind();
            drpCategoria.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
        }
        private void fillDropDownListClase()
        {
            CCClase oCCClase = new CCClase();
            string nom = drpCategoria.SelectedValue;
            DataTable oDt = oCCClase.getclaseAnterior(nom);
            drpClase.DataSource = oDt;
            drpClase.DataTextField = "txt_desc";
            drpClase.DataValueField = "cod_clase";
            drpClase.DataBind();
            drpClase.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
            
        }
        private void fillDropDownListTipoProducto()
        {
            CCTipoProducto oCCTipo = new CCTipoProducto();
            string cate = drpCategoria.SelectedValue;
            string clase = drpClase.SelectedValue;
            DataTable oDt = oCCTipo.gettpAnterior(cate,clase); ;
            drpTipoProducto.DataSource = oDt;
            drpTipoProducto.DataTextField = "txt_desc";
            drpTipoProducto.DataValueField = "cod_tipo";
            drpTipoProducto.DataBind();
            drpTipoProducto.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
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

        protected void drpCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDropDownListClase();
        }

        protected void drpClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDropDownListTipoProducto();
        }

        protected void drpMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDropDownListModelo();
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
            CCProducto.Producto_Grabar(Modo_Edicion,obj_prod,obj_transac);
            if (obj_transac.resultado == 1)
            {
                if (this.Modo_Edicion == "N")
                {
                    this.Modo_Edicion = "E";
                }
                lbl_confirmacion.ForeColor = System.Drawing.Color.Green;
                lbl_confirmacion.Text = "Se grabó la información con éxito";
            }
            else
            {
                lbl_confirmacion.ForeColor = System.Drawing.Color.Red;
                lbl_confirmacion.Text = "No se pudo grabar la información" + obj_transac.msg_error;
            }
        }
    }
}