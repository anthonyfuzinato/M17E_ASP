using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_intro
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["perfil"] == null)
                Response.Redirect("login.aspx");
            
            if (Session["perfil"].ToString() != "0")
            {
                Response.Redirect("login.aspx");
            }

            if (Session["ip"] != Request.UserHostAddress || Session["useragent"].ToString() != Request.UserAgent)
            {
                //Terminar sessão
                bt_logout_Click(sender, e);
            }
        }

        protected void bt_logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("login.aspx");
        }
    }
}