using M17E_intro.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_intro
{
    public partial class recuperarpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void bt_Recuperar_Click(object sender, EventArgs e)
        {
            try
            {
                // validar a password
                string password = tb_Palavra_passe.Text.Trim();
                if (password.Length < 6)
                {
                    throw new Exception("A password deve conter pelo menos 6 caracteres.");
                }
                // guid 
                string token = Server.UrlDecode(Request["token"].ToString());
                // atualizamos a palavra passe
                Utilizadores utilizador = new Utilizadores();
                utilizador.atualizarPassword(token, password);
            }
            catch (Exception ex)
            {

            }
            //redirecionar para a página de login
            Response.Redirect("login.aspx");
        }
    }
}