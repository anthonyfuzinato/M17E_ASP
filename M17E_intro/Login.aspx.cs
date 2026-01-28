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

        protected void bt_login_Click(object sender, EventArgs e)
        {
            // validaçao dos dados do formulario
            if (tb_email.Text != "" && tb_password.Text != "")
            {
                lb_erro.Text = "Loguin falhou! Tente novamente.";
                return;
            }

            // consulta à base de dados para verificar se o utilizador existe
            Utilizadores utilizador = new Utilizadores();
            

            // Sessão - perfil,email,nome do utilizador

            // redirecionar o utilizador de acordo com o perfil

        }
    }
}