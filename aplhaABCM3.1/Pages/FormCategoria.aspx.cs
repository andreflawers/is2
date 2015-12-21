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
    public partial class FormCategoria : System.Web.UI.Page
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
            grd_cate.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
        private void llenarGrillaConProcedimiento()
        {
            CCCategoria oCCCategoria = new CCCategoria();
            DataTable oDt = oCCCategoria.getcategoriaAll();

            if (oDt.Rows.Count > 0)
            {
                this.grd_cate.DataSource = oDt;
                this.grd_cate.DataBind();
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
            CECategoria obj_cate = CCCategoria.Categoria_Consultar_datos(obj_transac, codigo);
            if (obj_transac.resultado == 1)
            {
                lbl_titulo.Text = "Consultando datos de la categoria";
                txt_id_empresa.Text = obj_cate.id_empresa + "";
                txt_cod_cate.Text = obj_cate.cod_cate;
                txt_txt_abrv.Text = obj_cate.txt_abrv;
                txt_txt_desc.Text = obj_cate.txt_desc;
                lbl_confirmacion.Text = "";
                this.Modo_Edicion = "E";
            }
            else
            {
                txt_id_empresa.Text = "";
                txt_cod_cate.Text = "";
                txt_txt_abrv.Text = "";
                txt_txt_desc.Text = "";
                lbl_confirmacion.ForeColor = System.Drawing.Color.Red;
                lbl_confirmacion.Text = obj_transac.msg_error;
            }
            ModalPopupExtender1.Show();
        }

        protected void lkb_eliminar_Click(object sender, EventArgs e)
        {
            LinkButton lkb = (LinkButton)sender;
            string codigo = lkb.CommandArgument;

            Result_transaccion obj_transac = new Result_transaccion();
            CCCategoria.Categoria_Eliminar(obj_transac, codigo);
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



        protected void btn_grabar_Click(object sender, EventArgs e)
        {
            ModalPopupExtender1.Show();
            Result_transaccion obj_transac = new Result_transaccion();
            CECategoria obj_cate = new CECategoria();
            obj_cate.id_empresa = int.Parse(txt_id_empresa.Text);
            obj_cate.cod_cate = txt_cod_cate.Text;
            obj_cate.txt_abrv = txt_txt_abrv.Text;
            obj_cate.txt_desc = txt_txt_desc.Text;
            CCCategoria.Categoria_Grabar(Modo_Edicion, obj_cate, obj_transac);
            if (obj_transac.resultado == 1)
            {
                if (this.Modo_Edicion == "N")
                {
                    txt_cod_cate.Text = obj_cate.cod_cate;
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
            limpiartextbox();
        }

        private void limpiartextbox()
        {
            txt_id_empresa.Text = "";
            txt_cod_cate.Text = "";
            txt_txt_abrv.Text = "";
            txt_txt_desc.Text = "";
            lbl_confirmacion.Text = "";
        }

        protected void lkb_nueva_categoria_Click1(object sender, EventArgs e)
        {
            ModalPopupExtender1.Show();
            lbl_titulo.Text = "Registrando datos de la categoria";
            limpiartextbox();
            Modo_Edicion = "N";
        }

    }
}