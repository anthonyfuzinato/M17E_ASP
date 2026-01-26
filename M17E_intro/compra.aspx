<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="compra.aspx.cs" Inherits="M17E_intro.Imagens.compra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Comprar um pc</h1>
            <!-- nome-->
            Nome: <asp:TextBox ID="tb_nome" runat="server" required="True" placeholder="Nome do cliente" MaxLength="50"></asp:TextBox>
            <br />  
       
            <!-- Data de nascimento-->
            Data de Nascimento: <asp:TextBox ID="c_data_nasc" runat="server" type="date" required ="false"></asp:TextBox>
            <br />

            <!-- email-->
            Email: <asp:TextBox ID="tb_email" runat="server" required="True" Type="email" placeholder="Email do cliente"></asp:TextBox>

            <!-- marca  dropdownlist-->
            Marca: <asp:DropDownList ID="ddl_marca" runat="server" OnSelectedIndexChanged="ddl_marca_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Value="0">Escolha um</asp:ListItem>
                <asp:ListItem Value="1">Asus</asp:ListItem>
                <asp:ListItem Value="2">Acer</asp:ListItem>
                </asp:DropDownList>
            <br />  

            <!-- modelo dropdownlist-->        
            Modelo: <asp:DropDownList ID="ddl_modelo" runat="server">
                <asp:ListItem Value="">Escolha um</asp:ListItem>
                </asp:DropDownList>
            <br />

            <!-- Processador radio button list-->
            <asp:RadioButton GroupName="Processador" ID="rb_intel" runat="server" Text="Intel" /><br />
            <asp:RadioButton GroupName="Processador" ID="rb_amd" runat="server" Text="AMD" /><br />
            <asp:RadioButton GroupName="Processador" ID="rb_outro" runat="server" Text="Outro" /><br />

            <!-- Aceitar as condiçoes check box-->
            <asp:CheckBox ID="cb_aceitar" runat="server" Text="Aceito as condições"/>
            <br />

            <!-- foto perfil upload-->
            Foto de Perfil: <asp:FileUpload ID="fu_foto_perfil" runat="server" />
            <br />

            <!-- button finalizar-->
            <asp:Button ID="bt_comprar" runat="server" Text="Finalizar a compra" OnClick="bt_comprar_Click" />
            <br />
            <asp:Label ID="lb_erro" runat="server" />

        </div>
    </form>
</body>
</html>
