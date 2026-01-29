<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="M17E_intro.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Admin dashboard</h1>
            <%if (Session["perfil"].ToString() == "0") { %>
            <h2>Olá administrados</h2>
            <% } else { %>
            <h2>Olá quarquer cposa</h2>
            <% } %>
            <asp:Button ID="bt_logout" runat="server" Text="Logout" OnClick="bt_logout_Click" />
        </div>
    </form>
</body>
</html>
