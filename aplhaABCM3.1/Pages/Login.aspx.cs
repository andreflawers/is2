using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador;

namespace aplhaABCM3._1.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //  Session.Clear();
            if (!Page.IsPostBack) return;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CCUser oCCUser = new CCUser();
            if (oCCUser.validateUSer(txtEmail.Text, txtPassword.Text))
            {
                Session.Add("user", txtEmail.Text.Substring(0, txtEmail.Text.IndexOf('@')));

                Response.Redirect("../Pages/directorio.aspx");
            }
            else
            {
                lblError.Text = "No existe combinación de usuario y contraseña";
                lblError.Visible = true;
            }
            

            
        }
    }
}