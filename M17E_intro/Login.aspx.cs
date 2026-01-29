using M17E_intro.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_intro
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void bt_login_Click1(object sender, EventArgs e)
        {
            // validaçao dos dados do formulario
            if (tb_email.Text == "" || tb_password.Text == "")
            {
                lb_erro.Text = "Login falhou! Tente novamente.";
                return;
            }

            // consulta à base de dados para verificar se o utilizador existe
            Utilizadores novo = new Utilizadores();
            novo.email = tb_email.Text;
            novo.password = tb_password.Text;
            if (novo.VerificaLogin() == false)
            {
                lb_erro.Text = "Loguin falhou! Tente novamente.A";
                return;
            }

            // Sessão - perfil,email,nome do utilizador
            Session["id"] = novo.id;
            Session["email"] = novo.email;
            Session["perfil"] = novo.perfil;
            Session["nome"] = novo.nome;
            Session["ip"] = Request.UserHostAddress;
            Session["useragente"] = Request.UserAgent;

            // redirecionar o utilizador de acordo com o perfil
            if (novo.perfil == 0)
            {
                Response.Redirect("admin.aspx");
            }
            else
            {
                Response.Redirect("cliente.aspx");
            }
        }
    }
}