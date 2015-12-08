using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aplhaABCM3._1.Templates
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lblUser.Text = Session["user"].ToString();
            }
            catch
            {
                Response.Redirect("../Pages/Login.aspx");
            }
        }
    }
}