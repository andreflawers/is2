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
    public partial class FormModelo : System.Web.UI.Page
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
            grd_modelo.HeaderRow.TableSection = TableRowSection.TableHeader;
            Panel_mant_modelo.Visible = false;
        }
        private void llenarGrillaConProcedimiento()
        {
            CCModelo oCCModelo = new CCModelo();
            DataTable oDt = oCCModelo.getmodeloAll();

            if (oDt.Rows.Count > 0)
            {
                this.grd_modelo.DataSource = oDt;
                this.grd_modelo.DataBind();
            }
            else
            {
                this.lbl_mesg_01.Text = "No existen datos";
            }
        }

        protected void lkb_editar_Click(object sender, EventArgs e)
        {
            LinkButton lnk = (LinkButton)sender;
            string codigo = lnk.CommandArgument;
            Result_transaccion obj_transac = new Result_transaccion();
            CEModelo obj_modelo = CCModelo.Modelo_Consultar_datos(obj_transac, codigo);
            if (obj_transac.resultado == 1)
            {
                lbl_titulo.Text = "Consultando datos del modelo";
                txt_id_empresa.Text = obj_modelo.id_empresa + "";
                lbl_cod_modelo.Text = obj_modelo.cod_modelo;
                txt_txt_abrv.Text = obj_modelo.txt_abrv;
                txt_txt_desc.Text = obj_modelo.txt_desc;
                lbl_confirmacion.Text = "";
                this.Modo_Edicion = "E";
            }
            else
            {
                txt_id_empresa.Text = "";
                lbl_cod_modelo.Text = "";
                txt_txt_abrv.Text = "";
                txt_txt_desc.Text = "";
                lbl_confirmacion.ForeColor = System.Drawing.Color.Red;
                lbl_confirmacion.Text = obj_transac.msg_error;
            }

            Panel_mant_modelo.Visible = true;
        }

        protected void lkb_eliminar_Click(object sender, EventArgs e)
        {
            LinkButton lkb = (LinkButton)sender;
            string codigo = lkb.CommandArgument;

            Result_transaccion obj_transac = new Result_transaccion();
            CCModelo.Modelo_Eliminar(obj_transac, codigo);
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

        protected void lkb_nueva_modelo_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Registrando datos del modelo";
            txt_id_empresa.Text = "";
            lbl_cod_modelo.Text = "";
            txt_txt_abrv.Text = "";
            txt_txt_desc.Text = "";
            this.Modo_Edicion = "N";
            Panel_mant_modelo.Visible = true;
        }

        protected void btn_grabar_Click(object sender, EventArgs e)
        {
            Result_transaccion obj_transac = new Result_transaccion();
            CEModelo obj_modelo = new CEModelo();
            obj_modelo.id_empresa = int.Parse(txt_id_empresa.Text);
            obj_modelo.cod_modelo = lbl_cod_modelo.Text;
            obj_modelo.txt_abrv = txt_txt_abrv.Text;
            obj_modelo.txt_desc = txt_txt_desc.Text;
            CCModelo.Modelo_Grabar(Modo_Edicion, obj_modelo, obj_transac);
            if (obj_transac.resultado == 1)
            {
                if (this.Modo_Edicion == "N")
                {
                    lbl_cod_modelo.Text = obj_modelo.cod_modelo;
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
            Panel_mant_modelo.Visible = false;
        }
    }
}