using M17E_intro.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
            // validar recaptcha
            var resposta = Request.Form["g-recaptcha-response"];
            var validou = ReCaptcha.Validate(resposta);
            if (validou == false)
            {
                lb_erro.Text = "tem de provar que não é um robot.";
                return;
            }

            // consulta à base de dados para verificar se o utilizador existe
            Utilizadores novo = new Utilizadores();
            novo.email = tb_email.Text;
            novo.palavra_passe = tb_password.Text;
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

        protected void bt_RecuperarPalavraPasse_Click(object sender, EventArgs e)
        {
            try
            {
                if( tb_email.Text.Trim().Length==0)
                {
                    throw new Exception("Tem de inserir o email para recuperar a palavra passe.");
                }
                string email = tb_email.Text.Trim();
                // confirmar se email existe 
                Classes.Utilizadores utilizador = new Classes.Utilizadores();
                DataTable dados = utilizador.devolveDadosUtilizador(email);
                if (dados.Rows.Count == 0 || dados == null)
                {
                    throw new Exception("Foi enviado uma mensagem para o seu email.");
                }
                // token => GUID
                Guid guid = Guid.NewGuid();
                string token = guid.ToString();
                utilizador.recuperarPassword(email, token);

                // criar mensagem
                string mensagem = $@"Clique no link para recuperar a sua password. <br/>";
                mensagem += $"<a href='https://"+Request.Url.Authority+"/recuperarpassword.aspx?";
                mensagem += $"token=" + Server.UrlEncode(token) + "'>Clique aqui</a>";
                // enviar email
                string meuemail = ConfigurationManager.AppSettings["email"].ToString();
                string palavrapasse = ConfigurationManager.AppSettings["password"].ToString();
                Helper.enviarMail(meuemail, palavrapasse, email, "Recuperação de password", mensagem);
                lb_erro.Text = @"Foi enviado uma mensagem para o seu email.";
            }
            catch (Exception ex)
            {
                // mostrar no lb erro que foi enviado um email
                lb_erro.Text = ex.Message;
            }
        }
    }
}