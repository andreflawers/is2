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
    public partial class FormClase : System.Web.UI.Page
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
            grd_clase.HeaderRow.TableSection = TableRowSection.TableHeader;
            //Panel_mant_clase.Visible = false;
        }
        private void fillDropDownListCategoria()
        {
            CCCategoria oCCCategoria = new CCCategoria();
            DataTable oDt = oCCCategoria.getcategoriaAll();
            drp_cate.DataSource = oDt;
            drp_cate.DataTextField = "txt_desc";
            drp_cate.DataValueField = "cod_cate";
            drp_cate.DataBind();
            drp_cate.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
        }
        private void llenarGrillaConProcedimiento()
        {
            CCClase oCCClase = new CCClase();
            DataTable oDt = oCCClase.getclaseAll();

            if (oDt.Rows.Count > 0)
            {
                this.grd_clase.DataSource = oDt;
                this.grd_clase.DataBind();
            }
            else
            {
                this.lbl_mesg_01.Text = "No existen datos";
            }
        }

        protected void lkb_eliminar_Click(object sender, EventArgs e)
        {
            LinkButton lkb = (LinkButton)sender;
            string codigo = lkb.CommandArgument;

            Result_transaccion obj_transac = new Result_transaccion();
            CCClase.Clase_Eliminar(obj_transac, codigo);
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

        protected void lkb_nueva_clase_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Registrando datos de la clase";
            txt_id_empresa.Text = "";
            fillDropDownListCategoria();
            txt_cod_clase.Text = "";
            txt_txt_abrv.Text = "";
            txt_txt_desc.Text = "";
            lbl_confirmacion.Text = "";
            this.Modo_Edicion = "N";
            ModalPopupExtender1.Show();
        }

        protected void btn_grabar_Click(object sender, EventArgs e)
        {
            ModalPopupExtender1.Show();
            Result_transaccion obj_transac = new Result_transaccion();
            CEClase obj_clase = new CEClase();
            obj_clase.id_empresa = int.Parse(txt_id_empresa.Text);
            obj_clase.cod_cate = drp_cate.SelectedValue;
            obj_clase.cod_clase = txt_cod_clase.Text;
            obj_clase.txt_abrv = txt_txt_abrv.Text;
            obj_clase.txt_desc = txt_txt_desc.Text;
            CCClase.Clase_Grabar(Modo_Edicion, obj_clase, obj_transac);
            if (obj_transac.resultado == 1)
            {
                if (this.Modo_Edicion == "N")
                {
                    txt_cod_clase.Text = obj_clase.cod_clase;
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
            ModalPopupExtender1.Hide();
        }

        protected void lkb_editar_Click(object sender, EventArgs e)
        {
            LinkButton lnk = (LinkButton)sender;
            fillDropDownListCategoria();
            string codigo = lnk.CommandArgument;
            Result_transaccion obj_transac = new Result_transaccion();
            CEClase obj_clase = CCClase.Clase_Consultar_datos(obj_transac, codigo);
            if (obj_transac.resultado == 1)
            {
                lbl_titulo.Text = "Consultando datos de la clase";
                txt_id_empresa.Text = obj_clase.id_empresa + "";
                drp_cate.Text = obj_clase.cod_cate;
                txt_cod_clase.Text = obj_clase.cod_clase;
                txt_txt_abrv.Text = obj_clase.txt_abrv;
                txt_txt_desc.Text = obj_clase.txt_desc;
                lbl_confirmacion.Text = "";
                this.Modo_Edicion = "E";
            }
            else
            {
                txt_id_empresa.Text = "";                
                txt_cod_clase.Text = "";
                txt_txt_abrv.Text = "";
                txt_txt_desc.Text = "";
                lbl_confirmacion.ForeColor = System.Drawing.Color.Red;
                lbl_confirmacion.Text = obj_transac.msg_error;
            }
            ModalPopupExtender1.Show();
        }
    }
}