﻿using Controlador;
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



        protected void lkb_eliminar_Click(object sender, EventArgs e)
        {
            LinkButton lkb = (LinkButton)sender;
            string codigo = lkb.CommandArgument;

            Result_transaccion obj_transac = new Result_transaccion();
            CCProducto.Prodcucto_Eliminar(obj_transac, codigo);
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