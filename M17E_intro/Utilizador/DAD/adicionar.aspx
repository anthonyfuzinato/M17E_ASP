<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adicionar.aspx.cs" Inherits="M17E_intro.Utilizador.DAD.adicionar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FormView ID="FormView1" runat="server" DataSourceID="SqlUtilizadores"></asp:FormView>
            <asp:SqlDataSource runat="server" ID="SqlUtilizadores"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
