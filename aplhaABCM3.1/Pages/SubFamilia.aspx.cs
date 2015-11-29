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
    public partial class SubFamilia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            listar_grillaSubFamilia();
            llenar_combo();
            llenar_combo2();
            llenar_combo3();
            //actualizaDataGrid();
        }

        protected void Buttoncancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SubFamilia.aspx");
        }
        private void llenar_combo()
        {
            CCSubFamilia oCCSubFam = new CCSubFamilia();
            DataTable oDt = oCCSubFam.getllenarcombo();
            DropDownListid_Familia.DataSource = oDt;
            DropDownListid_Familia.DataTextField = "id_empresa";
            DropDownListid_Familia.DataValueField = "id_empresa";
            DropDownListid_Familia.DataBind();
        }
        private void llenar_combo2()
        {
            CCSubFamilia oCCSubFam = new CCSubFamilia();
            DataTable oDt = oCCSubFam.getllenarcombo2();
            DropDownListcod.DataSource = oDt;
          //DropDownListid_Familia.DataSource = oDt;
            DropDownListcod.DataTextField = "cod_iso_idio_orgn";
            DropDownListcod.DataValueField = "cod_iso_idio_orgn";
            DropDownListcod.DataBind();
          //DropDownListid_Familia.DataTextField = "id_empresa";
          //DropDownListid_Familia.DataValueField = "id_empresa";
          //DropDownListid_Familia.DataBind();
        }
        private void llenar_combo3()
        {
            CCSubFamilia oCCSubFam = new CCSubFamilia();
            DataTable oDt = oCCSubFam.getllenarcombo3();
            DropDownListcategoria.DataSource = oDt;
            DropDownListcategoria.DataTextField = "cod_cate";
            DropDownListcategoria.DataValueField = "cod_cate";
            DropDownListcategoria.DataBind();
        }
        private void listar_grillaSubFamilia()
        {
            CCSubFamilia oCCSUb = new CCSubFamilia();
            GridViewSubFamilia.DataSource= oCCSUb.getlistar_SubFamilia();
            GridViewSubFamilia.DataBind();
        }

        protected void Buttonimpiar_Click(object sender, EventArgs e)
        {
            TextBoxid.Text = string.Empty;
            TextBoxNommbreSub.Text = string.Empty;
        }
        public Entidad.SubFamilia getObjetoSubFamilia()
        {
            Entidad.SubFamilia oSubfamilia = new Entidad.SubFamilia();
            oSubfamilia.id_Empresa = int.Parse( DropDownListid_Familia.Text.Trim());
            oSubfamilia.cod_iso_idio = DropDownListcod.Text.Trim();
            oSubfamilia.cod_cate = DropDownListcategoria.Text.Trim();
            oSubfamilia.Id_SubFamilia = TextBoxid.Text.Trim();
            oSubfamilia.nombre_SubFamilia = TextBoxNommbreSub.Text.Trim();
            oSubfamilia.Nombre = TextBox7.Text.Trim();
            return oSubfamilia;
        }

        protected void Buttonaceptar_Click(object sender, EventArgs e)
        {
            Entidad.SubFamilia OSUB = new Entidad.SubFamilia();
            CCSubFamilia OCC = new CCSubFamilia();
            OCC.getinsertarsubfamilia(getObjetoSubFamilia());
            actualizaDataGrid();
            GridViewSubFamilia.DataBind();
            Response.Redirect("~/SubFamilia.aspx");

        }

        private void habilitar_cajasdetexto()
        {
            TextBoxid.Enabled = true;
            TextBoxNommbreSub.Enabled = true;
            DropDownListid_Familia.Enabled = true;
            DropDownListcod.Enabled = true;
            DropDownListcategoria.Enabled = true;
            TextBox7.Enabled = true;
        }
        protected void Buttoninsertar_Click(object sender, EventArgs e)
        {
            PanelSubFamilia.Visible = true;
            TextBoxid.Enabled = false;
            TextBoxNommbreSub.Enabled = false;
            DropDownListid_Familia.Enabled = false;
            Buttonbuscar.Visible = false;
            TextBox4.Visible = false;
            Buttonaceptar.Enabled = false;
            Buttonimpiar.Enabled = false;
            Buttoninsertar.Enabled = false;
            DropDownListcategoria.Enabled = false;
            DropDownListcod.Enabled = false;
            TextBox7.Enabled = false;

        }
        public void actualizaDataGrid()
        {
            CCSubFamilia occ = new CCSubFamilia();
            GridViewSubFamilia.DataSource = occ.getlistar_SubFamilia();
            GridViewSubFamilia.DataBind();
        }

        protected void GridViewSubFamilia_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                GridViewSubFamilia.EditIndex = e.NewEditIndex;
                //actualizaDataGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void GridViewSubFamilia_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                Entidad.SubFamilia osubfam = new  Entidad.SubFamilia();
                TextBox oTextBox = new TextBox();

                oTextBox = (TextBox)GridViewSubFamilia.Rows[e.RowIndex].FindControl("TextBox1");
                osubfam.id_Empresa = int.Parse(oTextBox.Text.Trim());

                oTextBox = (TextBox)GridViewSubFamilia.Rows[e.RowIndex].FindControl("TextBox2");
                osubfam.cod_iso_idio = (oTextBox.Text.Trim());

                oTextBox = (TextBox)GridViewSubFamilia.Rows[e.RowIndex].FindControl("TextBox5");
                osubfam.cod_cate = (oTextBox.Text.Trim());

                oTextBox = (TextBox)GridViewSubFamilia.Rows[e.RowIndex].FindControl("TextBox6");
                osubfam.Id_SubFamilia = (oTextBox.Text.Trim());

                oTextBox = (TextBox)GridViewSubFamilia.Rows[e.RowIndex].FindControl("TextBox3");
                osubfam.nombre_SubFamilia = oTextBox.Text.Trim();

                oTextBox = (TextBox)GridViewSubFamilia.Rows[e.RowIndex].FindControl("TextBox4");
                osubfam.Nombre = oTextBox.Text.Trim();
                CCSubFamilia oCC = new CCSubFamilia();
                oCC.getActualizarSubFamilia(osubfam);
                GridViewSubFamilia.DataBind();
                GridViewSubFamilia.EditIndex = -1;
                actualizaDataGrid();
            }
            catch
            {
                throw;
            }
        }

        protected void GridViewSubFamilia_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Entidad.SubFamilia oSub = new Entidad.SubFamilia();
            oSub.Id_SubFamilia = GridViewSubFamilia.DataKeys[e.RowIndex].Values["cod_clase"].ToString();
            CCSubFamilia oCCcat = new CCSubFamilia();
            GridViewSubFamilia.DataSource = oCCcat.geteliminar(oSub.Id_SubFamilia);
            GridViewSubFamilia.EditIndex = -1;
            GridViewSubFamilia.DataBind();
            actualizaDataGrid();
        }

        protected void GridViewSubFamilia_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                GridViewSubFamilia.EditIndex = -1;
                actualizaDataGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }

      

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            habilitar_cajasdetexto();
            Buttonimpiar.Enabled = true;
            Buttonaceptar.Enabled = true;
           
        }

        protected void GridViewSubFamilia_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            //var id = GridViewSubFamilia.Rows[GridViewSubFamilia.SelectedRow.RowIndex].FindControl("Label1") as Label  ;
            //TextBoxid.Text = id.Text;
            //var nombre = GridViewSubFamilia.Rows[GridViewSubFamilia.SelectedRow.RowIndex].FindControl("Label2") as Label;
            //TextBoxNommbreSub.Text = nombre.Text;
            //getObjetoSubFamilia();
            //TextBoxid.Text = GridViewSubFamilia.Rows[e.NewSelectedIndex].Cells[0].ToString();
            //TextBoxNommbreSub.Text = GridViewSubFamilia.Rows[e.NewSelectedIndex].Cells[1].ToString();
            //DropDownListid_Familia.Text = GridViewSubFamilia.Rows[e.NewSelectedIndex].Cells.ToString();
        }

        protected void Buttonbuscar_Click(object sender, EventArgs e)
        {
            CCSubFamilia occ = new CCSubFamilia();
            GridViewSubFamilia.DataSource= occ.getBuscar(TextBox4.Text.Trim());
            GridViewSubFamilia.DataBind();
        }

        

        

    

        

        
    

        
    }
}