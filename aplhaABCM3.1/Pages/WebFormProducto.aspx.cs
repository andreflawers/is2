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
    public partial class WebFormProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            llenarGrillaConProcedimiento();
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
        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            CCProducto occproducto = new CCProducto();
            if (txtbuscarid.Text == "")
            {
                grd_Producto.DataSource = occproducto.getProductoListDescripcion(txtbuscardescripcion.Text);
                grd_Producto.DataBind();
            }
            if (txtbuscardescripcion.Text == "")
            {
                grd_Producto.DataSource = occproducto.getProductoListid(txtbuscarid.Text);
                grd_Producto.DataBind();
            }
            if (txtbuscardescripcion.Text.Length > 0 & txtbuscarid.Text.Length > 0)
            {
                grd_Producto.DataSource = occproducto.getProductoListDescp_id(txtbuscarid.Text, txtbuscardescripcion.Text);
                grd_Producto.DataBind();
            }
        }

        protected void lkb_editar_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/Pages/directorio.aspx");
            //LinkButton lnk = (LinkButton)sender;
            //string codigo = lnk.CommandArgument;
            //Result_transaccion obj_transac = new Result_transaccion();
            //CEModelo obj_modelo = CCModelo.Modelo_Consultar_datos(obj_transac, codigo);
            //if (obj_transac.resultado == 1)
            //{
            //    lbl_titulo.Text = "Consultando datos del modelo";
            //    txt_id_empresa.Text = obj_modelo.id_empresa + "";
            //    txt_cod_modelo.Text = obj_modelo.cod_modelo;
            //    txt_txt_abrv.Text = obj_modelo.txt_abrv;
            //    txt_txt_desc.Text = obj_modelo.txt_desc;
            //    lbl_confirmacion.Text = "";
            //    this.Modo_Edicion = "E";
            //}
            //else
            //{
            //    txt_id_empresa.Text = "";
            //    txt_cod_modelo.Text = "";
            //    txt_txt_abrv.Text = "";
            //    txt_txt_desc.Text = "";
            //    lbl_confirmacion.ForeColor = System.Drawing.Color.Red;
            //    lbl_confirmacion.Text = obj_transac.msg_error;
            //}
        }

        protected void lkb_eliminar_Click(object sender, EventArgs e)
        {
            LinkButton lkb = (LinkButton)sender;
            string codigo = lkb.CommandArgument;

            Result_transaccion obj_transac = new Result_transaccion();
            CCProducto.Prodcucto_Eliminar(obj_transac,codigo);
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