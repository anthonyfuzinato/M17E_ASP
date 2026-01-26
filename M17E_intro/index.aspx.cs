using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_intro
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Só para a primeira vez que a página é carregada
            if (!IsPostBack)
            {
                // Inicializar os campos
                tb_x.Text = "0";
                tb_y.Text = "0";
            }
            // verificar se existe o parametro erro na url
            if (Request.QueryString["erro"] != null)
            {
                Response.Write($"<script>alert('erro');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x, y;
            x = int.Parse(tb_x.Text);
            y = int.Parse(tb_y.Text);
            lb_resultado.Text = (x + y).ToString();
        }

        protected void bt_redirect_Click(object sender, EventArgs e)
        {
            int x, y;
            x = int.Parse(tb_x.Text);
            y = int.Parse(tb_y.Text);
            int resultado = x + y;
            
            string url = $"resultado.aspx?resultado=" + resultado.ToString();
            Response.Redirect(url);
        }

        protected void bt_cookie_Click(object sender, EventArgs e)
        {
            // criar um cookie 
            // definir prazo de validade
            HttpCookie cookie = new HttpCookie("12H");
            cookie.Expires = DateTime.Now.AddYears(1);
            cookie.Value = ("Teste");
            Response.Cookies.Add(cookie);   

        }
    }
}