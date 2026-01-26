using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_intro
{
    public partial class cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // se ele existir esconder a div_aviso
            if (Request.Cookies["12H"] != null)
            {
                div_aviso.Visible = false;
            } 
        }
    }
}