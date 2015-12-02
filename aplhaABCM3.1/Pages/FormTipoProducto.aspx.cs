using Controlador;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aplhaABCM3._1.Pages
{
    public partial class FormTipoProducto : System.Web.UI.Page
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
            Panel_mant_tipo.Visible = false;
        }
        private void llenarGrillaConProcedimiento()
        {
            CCTipoProducto oCCTipo = new CCTipoProducto();
            DataTable oDt = oCCTipo.gettipoProductoAll();

            if (oDt.Rows.Count > 0)
            {
                this.grd_tipo.DataSource = oDt;
                this.grd_tipo.DataBind();
            }
            else
            {
                this.lbl_mesg_01.Text = "No existen datos";
            }
        }
        private void fillDropDownListCategoria()
        {
            CCCategoria oCCCategoria = new CCCategoria();
            DataTable oDt = oCCCategoria.getcategoriaAll();
            drp_cate.DataSource = oDt;
            drp_cate.DataTextField = "txt_desc";
            drp_cate.DataValueField = "cod_cate";
            drp_cate.DataBind();
        }
        private void fillDropDownListClase()
        {
            CCClase oCCClase = new CCClase();
            DataTable oDt = oCCClase.getclaseAll();
            drp_clase.DataSource = oDt;
            drp_clase.DataTextField = "txt_desc";
            drp_clase.DataValueField = "cod_clase";
            drp_clase.DataBind();
        }
        protected void lkb_nuevo_tipo_producto_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Registrando datos del tipo de producto";
            txt_id_empresa.Text = "";
            fillDropDownListCategoria();
            fillDropDownListClase();
            lbl_cod_tipo.Text = "";
            txt_txt_abrv.Text = "";
            txt_txt_desc.Text = "";
            this.Modo_Edicion = "N";
            Panel_mant_tipo.Visible = true;
        }

        protected void btn_grabar_Click(object sender, EventArgs e)
        {
            Result_transaccion obj_transac = new Result_transaccion();
            CETipoProducto obj_tipo = new CETipoProducto();
            obj_tipo.id_empresa = int.Parse(txt_id_empresa.Text);
            obj_tipo.cod_cate = drp_cate.SelectedValue;
            obj_tipo.cod_clase = drp_clase.SelectedValue;
            obj_tipo.cod_tipo = lbl_cod_tipo.Text;
            obj_tipo.txt_abrv = txt_txt_abrv.Text;
            obj_tipo.txt_desc = txt_txt_desc.Text;
            CCTipoProducto.Tipo_Producto_Grabar(Modo_Edicion, obj_tipo, obj_transac);
            if (obj_transac.resultado == 1)
            {
                if (this.Modo_Edicion == "N")
                {
                    lbl_cod_tipo.Text = obj_tipo.cod_tipo;
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
            Panel_mant_tipo.Visible = false;
        }

        protected void lkb_editar_Click(object sender, EventArgs e)
        {
            LinkButton lnk = (LinkButton)sender;
            string codigo = lnk.CommandArgument;
            Result_transaccion obj_transac = new Result_transaccion();
            CETipoProducto obj_tipo = CCTipoProducto.Tipo_Producto_Consultar_datos(obj_transac, codigo);
            if (obj_transac.resultado == 1)
            {
                lbl_titulo.Text = "Consultando datos del tipo de producto";
                txt_id_empresa.Text = obj_tipo.id_empresa + "";
                drp_cate.Text = obj_tipo.cod_cate;
                drp_clase.Text = obj_tipo.cod_clase;
                lbl_cod_tipo.Text = obj_tipo.cod_tipo;
                txt_txt_abrv.Text = obj_tipo.txt_abrv;
                txt_txt_desc.Text = obj_tipo.txt_desc;
                lbl_confirmacion.Text = "";
                this.Modo_Edicion = "E";
            }
            else
            {
                txt_id_empresa.Text = "";
                // fillDropDownListCategoria();
                lbl_cod_tipo.Text = "";
                txt_txt_abrv.Text = "";
                txt_txt_desc.Text = "";
                lbl_confirmacion.ForeColor = System.Drawing.Color.Red;
                lbl_confirmacion.Text = obj_transac.msg_error;
            }

            Panel_mant_tipo.Visible = true;
        }

        protected void lkb_eliminar_Click(object sender, EventArgs e)
        {
            LinkButton lkb = (LinkButton)sender;
            string codigo = lkb.CommandArgument;

            Result_transaccion obj_transac = new Result_transaccion();
            CCTipoProducto.Tipo_Producto_Eliminar(obj_transac, codigo);
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