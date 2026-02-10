<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="recuperarpassword.aspx.cs" Inherits="M17E_intro.recuperarpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Recuperação de palavra passe</h1>
            Nova palavra passe: <asp:TextBox ID="tb_Palavra_passe" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Button ID="bt_Recuperar" runat="server" Text="Recuperar" OnClick="bt_Recuperar_Click" />

        </div>
    </form>
</body>
</html>
