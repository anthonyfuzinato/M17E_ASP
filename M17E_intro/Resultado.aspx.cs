using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_intro
{
    public partial class Resultado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ler da url o parametro "resultado"
            if (!IsPostBack)
            {               
                if (Request.QueryString["resultado"] != null)
                {
                    int resultado;
                    bool converteu= int.TryParse(Request.QueryString["resultado"], out resultado);
                    if(converteu)
                        div_resultado.InnerText = $"O resultado é: {resultado}";
                    else
                        Response.Write("<script>alert('Erro ao converter o resultado.');</script>");
                }
                else 
                {
                    //Response.Write("<script>alert('Parâmetro resultado não encontrado.');</script>");
                    //redirecionar para a página inicial e mostrar uma mensagem de erro se o parametro nao existir
                    string url = "index.aspx?erro=1";
                    Response.Redirect(url);
                    // lembrar stor dos %20 incode/decode

                }

            }
                

        }
    }
}