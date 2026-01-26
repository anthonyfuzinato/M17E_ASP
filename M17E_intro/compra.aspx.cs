using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17E_intro.Imagens
{
    public partial class compra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                AtualizarDDMarcas();
        }

        private void AtualizarDDMarcas()
        {
            ddl_marca.Items.Add(new ListItem("Apple", "3"));
        }

        protected void ddl_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_marca.SelectedIndex <= 0)
            {
                return;
            }
            if (ddl_marca.SelectedValue == "1")
            {
                ddl_modelo.Items.Clear();
                ddl_modelo.Items.Add(new ListItem("Asus 1", "1"));
                ddl_modelo.Items.Add(new ListItem("Asus 2", "2"));
                ddl_modelo.Items.Add(new ListItem("Asus 3", "3"));
            }
            if (ddl_marca.SelectedValue == "2")
            {
                ddl_modelo.Items.Clear();
                ddl_modelo.Items.Add(new ListItem("HP 1", "1"));
                ddl_modelo.Items.Add(new ListItem("HP 2", "2"));
                ddl_modelo.Items.Add(new ListItem("HP 3", "3"));
            }
            if (ddl_marca.SelectedValue == "3")
            {
                ddl_modelo.Items.Clear();
                ddl_modelo.Items.Add(new ListItem("iPhone 1 Pro", "1"));
                ddl_modelo.Items.Add(new ListItem("iPhone 2", "2"));
                ddl_modelo.Items.Add(new ListItem("iPhone 3", "3"));
            }

        }

        protected void bt_comprar_Click(object sender, EventArgs e)
        {
            // validaçao dos dados do formulario
            try { 
            // nome obrigatorio e no minimo 5 letras
                string nome = tb_nome.Text;
                if (string.IsNullOrEmpty(nome) || nome.Length < 5)
                {
                    throw new Exception("Nome obrigatorio e no minimo 5 letras");
                    
                }
                //email obrigatorio e formato valido
                string email = tb_email.Text.Trim();
                if (string.IsNullOrEmpty(email) || !email.Contains("@") || !email.Contains("."))
                {
                    throw new Exception("Email obrigatorio e formato valido");
                }
                // data de nascimento maior de 18 anos 
                DateTime data = DateTime.Parse(c_data_nasc.Text);
                TimeSpan idade = DateTime.Now - data;
                if (idade.TotalDays / 365 < 18)
                {
                    throw new Exception("Data de nascimento maior de 18 anos");
                }
                // marca obrigatorios
                string marca = ddl_marca.SelectedValue;
                if (string.IsNullOrEmpty(marca) || ddl_marca.SelectedIndex <= 0)
                {
                    throw new Exception("Marca obrigatorio");
                }
                // modelo obrigatorios
                string modelo = ddl_modelo.SelectedValue;
                if (string.IsNullOrEmpty(modelo) || ddl_modelo.SelectedIndex < 0)
                {
                    throw new Exception("Modelo obrigatorio");
                }
                // processador so pode ter 1 
                if(!rb_amd.Checked && !rb_intel.Checked && !rb_outro.Checked)
                {
                    throw new Exception("So pode escolher 1 processador");
                }
                // aceitou as condiçoes obrigatorio
                if(!cb_aceitar.Checked)
                {
                    throw new Exception("Aceita as condiçoes obrigatorio");
                }
                // guardar imagem
                
                // existe ficheiro?
                if(fu_foto_perfil.HasFile)
                {
                    throw new Exception("Tem de enviar uma foto");
                }
                // validaçao do tipo de ficheiro
                if (fu_foto_perfil.PostedFile.ContentType != "image/jpeg" &&
                        fu_foto_perfil.PostedFile.ContentType != "image/png")
                {
                    throw new Exception("O ficheiro tem de ser jpeg ou png");
                }
                // validar o tamanho maximo
                if (fu_foto_perfil.PostedFile.ContentLength == 0 ||
                    fu_foto_perfil.PostedFile.ContentLength > 50000000)
                    throw new Exception("O ficheiro nao tem o tamanho correto");
                // guardar
                string ficheiro = Server.MapPath("~/Imagens/") + fu_foto_perfil.FileName;
                fu_foto_perfil.SaveAs(ficheiro);
            }
            
            catch (Exception ex)
            {
                lb_erro.Text = "Ocorreu o seguinte erro:" + ex.Message;
            }
        }
    }
}