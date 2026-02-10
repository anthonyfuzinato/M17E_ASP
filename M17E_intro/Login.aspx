<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="M17E_intro.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src ="https://www.google.com/recaptcha/api.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>Login</h1>
Email:<asp:TextBox ID="tb_email" runat="server" type="email"></asp:TextBox>
<br />
palavra passe:<asp:TextBox ID="tb_password" type="password" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="bt_login" runat="server" Text="Login" Onclick="bt_login_Click1"/>
    <br />
    <asp:Button ID="bt_RecuperarPalavraPasse" runat="server" Text="Recuperar palavra passe" Onclick="bt_RecuperarPalavraPasse_Click" />
    <br />
    <div class="g-recaptcha" data-sitekey="6LcalmUsAAAAADd56C3V-CQ29FyNmUTJqhBTzril"></div>
    <br />
    <asp:Label ID="lb_erro" runat="server" />
</asp:Content>
