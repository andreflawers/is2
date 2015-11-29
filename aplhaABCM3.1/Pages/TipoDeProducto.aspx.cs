using Controladora;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationFamilia
{
    public partial class TipoDeProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            llenar_grilla();
            llenar_combo();
            llenar_combo2();
            llenar_combo3();
            llenar_combo4();
            
        }
        private void llenar_grilla()
        {
                CCTipoDeProducto occtipo = new CCTipoDeProducto();
                GridViewTipoProducto.DataSource = occtipo.listartipoproducto();
                GridViewTipoProducto.DataBind();
        }
        public Entidad.TipoDeProducto getobjetotp()
        {
            Entidad.TipoDeProducto otp = new Entidad.TipoDeProducto();
            otp.id_Empresa = int.Parse(DropDownListidempresa.Text.Trim());
            otp.Cod_iso_idio = DropDownListcod_iso.Text.Trim();
            otp.cod_cate = DropDownListcategoria.Text.Trim();
            otp.cod_clase = DropDownListclase.Text.Trim();
            otp.cod_tipo = TextBoxcod_tipo.Text.Trim();
            otp.txt_abrv = TextBoxabvr.Text.Trim();
            otp.txt_desc = TextBoxdesc.Text.Trim();
            return otp;
        }
        private void llenar_combo()
        {
            CCTipoDeProducto oCCSubFam = new CCTipoDeProducto();
            DataTable oDt = oCCSubFam.getllenarcombo();
            DropDownListidempresa.DataSource = oDt;
            DropDownListidempresa.DataTextField = "id_empresa";
            DropDownListidempresa.DataValueField = "id_empresa";
            DropDownListidempresa.DataBind();
        }
        private void llenar_combo2()
        {
            CCTipoDeProducto oCCSubFam = new CCTipoDeProducto();
            DataTable oDt = oCCSubFam.getllenarcombo2();
            DropDownListcod_iso.DataSource = oDt;
            //DropDownListid_Familia.DataSource = oDt;
            DropDownListcod_iso.DataTextField = "cod_iso_idio_orgn";
            DropDownListcod_iso.DataValueField = "cod_iso_idio_orgn";
            DropDownListcod_iso.DataBind();
            //DropDownListid_Familia.DataTextField = "id_empresa";
            //DropDownListid_Familia.DataValueField = "id_empresa";
            //DropDownListid_Familia.DataBind();
        }
        private void llenar_combo3()
        {
            CCTipoDeProducto oCCSubFam = new CCTipoDeProducto();
            DataTable oDt = oCCSubFam.getllenarcombo3();
            DropDownListcategoria.DataSource = oDt;
            DropDownListcategoria.DataTextField = "cod_cate";
            DropDownListcategoria.DataValueField = "cod_cate";
            DropDownListcategoria.DataBind();
        }
        private void llenar_combo4()
        {
            CCTipoDeProducto oCCSubFam = new CCTipoDeProducto();
            DataTable oDt = oCCSubFam.getllenarcombo4();
            DropDownListclase.DataSource = oDt;
            DropDownListclase.DataTextField = "cod_clase";
            DropDownListclase.DataValueField = "cod_clase";
            DropDownListclase.DataBind();
        }
        public void actualizaDataGrid()
        {
            CCTipoDeProducto occ = new CCTipoDeProducto();
            GridViewTipoProducto.DataSource = occ.listartipoproducto();
            GridViewTipoProducto.DataBind();
        }
        protected void GridViewTipoProducto_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Entidad.TipoDeProducto oSub = new Entidad.TipoDeProducto();
            oSub.cod_tipo = GridViewTipoProducto.DataKeys[e.RowIndex].Values["cod_tipo"].ToString();
            CCTipoDeProducto oCCcat = new CCTipoDeProducto();
            GridViewTipoProducto.DataSource = oCCcat.geteliminar(oSub.cod_tipo);
            GridViewTipoProducto.EditIndex = -1;
            GridViewTipoProducto.DataBind();
            actualizaDataGrid();
        }

        protected void ButtonAcpetar_Click(object sender, EventArgs e)
        {
            CCTipoDeProducto oCC = new CCTipoDeProducto();
            oCC.getinsertartipo(getobjetotp());
            GridViewTipoProducto.DataBind();
            actualizaDataGrid();
        }

        protected void GridViewTipoProducto_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                GridViewTipoProducto.EditIndex = e.NewEditIndex;
                //actualizaDataGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void GridViewTipoProducto_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                Entidad.TipoDeProducto osubfam = new Entidad.TipoDeProducto();
                TextBox oTextBox = new TextBox();

                oTextBox = (TextBox)GridViewTipoProducto.Rows[e.RowIndex].FindControl("TextBox1");
                osubfam.id_Empresa = int.Parse(oTextBox.Text.Trim());

                oTextBox = (TextBox)GridViewTipoProducto.Rows[e.RowIndex].FindControl("TextBox2");
                osubfam.Cod_iso_idio = (oTextBox.Text.Trim());

                oTextBox = (TextBox)GridViewTipoProducto.Rows[e.RowIndex].FindControl("TextBox3");
                osubfam.cod_cate = (oTextBox.Text.Trim());

                oTextBox = (TextBox)GridViewTipoProducto.Rows[e.RowIndex].FindControl("TextBox4");
                osubfam.cod_clase = (oTextBox.Text.Trim());

                oTextBox = (TextBox)GridViewTipoProducto.Rows[e.RowIndex].FindControl("TextBox5");
                osubfam.cod_tipo = oTextBox.Text.Trim();

                oTextBox = (TextBox)GridViewTipoProducto.Rows[e.RowIndex].FindControl("TextBox6");
                osubfam.txt_abrv = oTextBox.Text.Trim();

                oTextBox = (TextBox)GridViewTipoProducto.Rows[e.RowIndex].FindControl("TextBox7");
                osubfam.txt_desc = oTextBox.Text.Trim();

                CCTipoDeProducto oCC = new  CCTipoDeProducto();
                oCC.getactualizartipoproducto(osubfam);
                GridViewTipoProducto.DataBind();
                GridViewTipoProducto.EditIndex = -1;
                actualizaDataGrid();
            }
            catch
            {
                throw;
            }
        }

        protected void GridViewTipoProducto_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                GridViewTipoProducto.EditIndex = -1;
                actualizaDataGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}