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
    public partial class FormMarcaModelo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            llenarGrillaConProcedimiento();
            grd_marca_modelo.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
        private void fillDropDownListMarca()
        {
            CCMarca oCCMarca = new CCMarca();
            DataTable oDt = oCCMarca.getMarcaAll();
            drp_marca.DataSource = oDt;
            drp_marca.DataTextField = "txt_desc";
            drp_marca.DataValueField = "cod_marca";
            drp_marca.DataBind();
            drp_marca.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
        }
        private void fillDropDownListModelo()
        {
            CCModelo oCCModelo = new CCModelo();
            DataTable oDt = oCCModelo.getmodeloAll();
            drp_modelo.DataSource = oDt;
            drp_modelo.DataTextField = "txt_desc";
            drp_modelo.DataValueField = "cod_modelo";
            drp_modelo.DataBind();
            drp_modelo.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
        }
        private void llenarGrillaConProcedimiento()
        {
            CCMarca_Modelo oCCMM = new CCMarca_Modelo();
            DataTable oDt = oCCMM.getMarcaModeloAll();

            if (oDt.Rows.Count > 0)
            {
                this.grd_marca_modelo.DataSource = oDt;
                this.grd_marca_modelo.DataBind();
            }
            else
            {
                this.lbl_mesg_01.Text = "No existen datos";
            }
        }

        protected void lkb_eliminar_Click(object sender, EventArgs e)
        {
            LinkButton lkb = (LinkButton)sender;
            string codigo1 = lkb.CommandArgument;
            Result_transaccion obj_transac = new Result_transaccion();
            CCMarca_Modelo.Marca_Modelo_Eliminar(obj_transac,codigo1);
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

        protected void lkb_nueva_marca_modelo_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Registrando datos de la marca y su modelo";
            fillDropDownListMarca();
            fillDropDownListModelo();
            lbl_confirmacion.Text = "";
            ModalPopupExtender1.Show();
        }

        protected void btn_grabar_Click(object sender, EventArgs e)
        {
            ModalPopupExtender1.Show();
            Result_transaccion obj_transac = new Result_transaccion();
            CEMarca_Modelo obj_marca_modelo = new CEMarca_Modelo();
            obj_marca_modelo.cod_marca = drp_marca.SelectedValue;
            obj_marca_modelo.cod_modelo = drp_modelo.SelectedValue;
            CCMarca_Modelo.Marca_Modelo_Grabar(obj_marca_modelo, obj_transac);
            if (obj_transac.resultado == 1)
            {
                
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
            ModalPopupExtender1.Hide();
        }

    }
}