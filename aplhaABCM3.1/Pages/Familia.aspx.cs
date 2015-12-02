using Controladora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad;
//using Modelo;


namespace WebApplicationFamilia
{
    public partial class Familia : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack) return;
            llenar_listacategoria();
            
            
        }
        

        private void habilitar_cajasdetexto()
        {
            TextBoxidfamilia.Enabled = true;
            TextBoxnombre.Enabled = true;
            TextBox3.Enabled = true;
            TextBox5.Enabled = true;
            TextBox6.Enabled = true;
        }
        private void llenar_listacategoria()
        {
            CCFamilia oCCFamilia = new  CCFamilia();
            GridViewFamilia.DataSource = oCCFamilia.getFamiliaAlista();
            GridViewFamilia.DataBind();

        }

        protected void Buttoninsertar_Click(object sender, EventArgs e)
        {
            TextBoxidfamilia.Enabled = false;
            TextBoxnombre.Enabled = false;
            Buttonaceptar.Enabled = false;
            Buttonlimpiar.Enabled = false;
            Buttoninsertar.Enabled = false;
            Panel1.Visible = true;
            GridViewFamilia.Visible = true;
            Btn_buscar.Visible = false;
            TextBoxbuscar.Visible = false;
            TextBox3.Enabled = false;
            TextBox5.Enabled = false;
            TextBox6.Enabled = false;
                        
        }
        public Entidad.Familia getObjetoFamilia()
        {
          Entidad.Familia ofamilia = new Entidad.Familia();
          ofamilia.id_Empresa = int.Parse(TextBox5.Text);
          ofamilia.cod_iso_idio = TextBox6.Text.Trim();
        ofamilia.Id_Familia = TextBoxidfamilia.Text.Trim();
        ofamilia.Nombre = TextBoxnombre.Text.Trim();
        ofamilia.descripcion = TextBox3.Text.Trim();
        return ofamilia;
        }
        public void actualizaDataGrid()
        {
            CCFamilia occfamilia = new  CCFamilia();
            GridViewFamilia.DataSource = occfamilia.getFamiliaAlista();
            GridViewFamilia.DataBind();
        }

        protected void Buttoncancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Familia.aspx");
        }
        
       
        protected void Buttonaceptar_Click(object sender, EventArgs e)
        {
            
            Entidad.Familia ofamilia = new Entidad.Familia();
            CCFamilia occ = new CCFamilia();
             occ.insertar_familia(getObjetoFamilia());
             GridViewFamilia.DataBind();
            actualizaDataGrid();
           
            
            Response.Redirect("~/Familia.aspx");
        }

        protected void GridViewFamilia_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                GridViewFamilia.EditIndex = e.NewEditIndex;
                actualizaDataGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void GridViewFamilia_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                Entidad.Familia ofam = new Entidad.Familia();
                TextBox oTextBox = new TextBox();

                oTextBox = (TextBox)GridViewFamilia.Rows[e.RowIndex].FindControl("TextBox3");
                ofam.id_Empresa = int.Parse(oTextBox.Text.Trim());

                oTextBox = (TextBox)GridViewFamilia.Rows[e.RowIndex].FindControl("TextBox4");
                ofam.cod_iso_idio = (oTextBox.Text.Trim());

                oTextBox = (TextBox)GridViewFamilia.Rows[e.RowIndex].FindControl("TextBoxid");
                ofam.Id_Familia = (oTextBox.Text.Trim());

                oTextBox = (TextBox)GridViewFamilia.Rows[e.RowIndex].FindControl("TextBox2");
                ofam.Nombre = oTextBox.Text.Trim();

                oTextBox = (TextBox)GridViewFamilia.Rows[e.RowIndex].FindControl("TextBox1");
                ofam.descripcion = oTextBox.Text.Trim();
                
                
                CCFamilia oCC = new CCFamilia();
                 oCC.getfamiliaactualiza(ofam);
                GridViewFamilia.DataBind();
                GridViewFamilia.EditIndex = -1;
                actualizaDataGrid();
            }
            catch
            {
                throw;
            }
        }

        protected void GridViewFamilia_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                GridViewFamilia.EditIndex = -1;
                actualizaDataGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void GridViewFamilia_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Entidad.Familia OFA = new  Entidad.Familia();
            OFA.Id_Familia = GridViewFamilia.DataKeys[e.RowIndex].Values["cod_cate"].ToString();
            CCFamilia oCCcat = new CCFamilia();
            GridViewFamilia.DataSource = oCCcat.getfamiliaeliminar(OFA.Id_Familia);
            GridViewFamilia.EditIndex = -1;
            GridViewFamilia.DataBind();
            actualizaDataGrid();
        }

        protected void Btn_buscar_Click(object sender, EventArgs e)
        {
            
            CCFamilia occ = new CCFamilia();
            GridViewFamilia.DataSource = occ.getbuscar_familia(TextBoxbuscar.Text.Trim()); 
           
           //occ.getbuscar_familia(ofam.Nombre);
            GridViewFamilia.DataBind();
            //actualizaDataGrid();
        }

        protected void Buttonlimpiar_Click(object sender, EventArgs e)
        {
            TextBoxidfamilia.Text = string.Empty;
            TextBoxnombre.Text = string.Empty;
        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            habilitar_cajasdetexto();
            Buttonlimpiar.Enabled = true;
            ButtonNuevo.Enabled = false;
            Buttonaceptar.Enabled = true;
        }
    }
}