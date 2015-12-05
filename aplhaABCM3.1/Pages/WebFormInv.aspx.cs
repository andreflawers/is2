using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad;
using Controlador;
using System.Data;
using System.Data.SqlClient;

namespace aplhaABCM3._1.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (!IsPostBack)
                {
                    this.llenarComboinv();
                    this.llenarComboAlm();
                    this.llenarGrillaTotal();
                }

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
               

        }
        private void llenarComboinv()
        {
            CCInventario oCCInventario= new CCInventario();
            DataTable oDt = oCCInventario.getInventarioList();
            dpdl_inv.DataSource = oDt;
            dpdl_inv.DataTextField = "nom_est";
            dpdl_inv.DataValueField = "id_est";
            dpdl_inv.DataBind();
            dpdl_inv.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
        }

        private void llenarComboAlm()
        {
            CCInventario oCCInverntario = new CCInventario();
            DataTable odt = oCCInverntario.getAlmacenList();
            dpdl_alm.DataSource = odt;
            dpdl_alm.DataTextField = "nom_alm";
            dpdl_alm.DataValueField = "id_alm";
            dpdl_alm.DataBind();
            dpdl_alm.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));
        }
        private void llenarGrillaTotal()
        {
            CCInventario oCCInventario = new  CCInventario();
            DataTable oDt =oCCInventario.getInvAll();
            Gdv_inv.DataSource = oDt;
            Gdv_inv.DataBind();
                Gdv_inv.DataSource = oDt;
                Gdv_inv.DataBind();        

        }

        

        private void filtrarGrillaCombos()
        {
            CCInventario oCCInventario = new CCInventario();
            CEInventario oCEInventario = new CEInventario();
            oCEInventario.tipo_Inventario = dpdl_inv.SelectedItem.Text.Trim();
            oCEInventario.almacen = dpdl_alm.SelectedItem.Text.Trim();
            DataTable oDT= oCCInventario.getinventarioGriewList(oCEInventario);
            Gdv_inv.DataSource = oDT;
            Gdv_inv.DataBind();
               
        }

        protected void btn_Aceptar_Click(object sender, EventArgs e)
        {

            filtrarGrillaCombos();
        }


    }
}