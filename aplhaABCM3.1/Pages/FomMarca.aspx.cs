using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidad;
using Controlador;
using System.Web.Services;
using System.Web.Script.Serialization;
using System.Data;

namespace aplhaABCM3._1.Pages
{
    public partial class FomMarca : System.Web.UI.Page
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
            grd_marca.HeaderRow.TableSection = TableRowSection.TableHeader;
            //Panel_mant_marca.Visible = false;
        }

        private void llenarGrillaConProcedimiento()
        {
            CCMarca oCCMarca = new CCMarca();

            DataTable oDt = oCCMarca.getMarcaAll();

            if (oDt.Rows.Count > 0)
            {
                this.grd_marca.DataSource = oDt;
                this.grd_marca.DataBind();
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
            CEMarca obj_marca = CCMarca.Marca_Consultar_datos(obj_transac,codigo);
            if (obj_transac.resultado == 1)
            {
                lbl_titulo.Text = "Consultando datos de la marca";
                txt_id_empresa.Text =obj_marca.id_empresa+"";
                txt_cod_idio.Text = obj_marca.cod_iso_idio_orgn;
                lbl_cod_marca.Text = obj_marca.cod_marca;
                txt_txt_abrv.Text = obj_marca.txt_abrv;
                txt_txt_desc.Text = obj_marca.txt_desc;
                lbl_confirmacion.Text = "";
                this.Modo_Edicion = "E";
            }
            else
            {
                txt_id_empresa.Text = "";
                txt_cod_idio.Text = "";
                lbl_cod_marca.Text = "";
                txt_txt_abrv.Text="";
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
            CCMarca.Marca_Eliminar(obj_transac,codigo);
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

        protected void lkb_nueva_marca_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Registrando datos de la marca";
            txt_id_empresa.Text = "";
            txt_cod_idio.Text = "";
            lbl_cod_marca.Text = "";
            txt_txt_abrv.Text = "";
            txt_txt_desc.Text = "";
            this.Modo_Edicion = "N";
            ModalPopupExtender1.Show();
        }

        protected void btn_grabar_Click(object sender, EventArgs e)
        {
            ModalPopupExtender1.Show();
            Result_transaccion obj_transac = new Result_transaccion();
            CEMarca obj_marca = new CEMarca();
            obj_marca.id_empresa =int.Parse( txt_id_empresa.Text);
            obj_marca.cod_iso_idio_orgn = txt_cod_idio.Text;
            obj_marca.cod_marca = lbl_cod_marca.Text;
            obj_marca.txt_abrv = txt_txt_abrv.Text;
            obj_marca.txt_desc = txt_txt_desc.Text;
            CCMarca.Marca_Grabar(Modo_Edicion,obj_marca,obj_transac);
            if (obj_transac.resultado == 1)
            {
                if (this.Modo_Edicion == "N")
                {
                    lbl_cod_marca.Text = obj_marca.cod_marca;
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
            limpiarcajas();
            ModalPopupExtender1.Hide();
        }

        private void limpiarcajas()
        {
            txt_id_empresa.Text = "";
            txt_cod_idio.Text = "";
            lbl_cod_marca.Text = "";
            txt_txt_abrv.Text = "";
            txt_txt_desc.Text = "";
        }
    }
}