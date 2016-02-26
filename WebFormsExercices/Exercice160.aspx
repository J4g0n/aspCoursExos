<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercice160.aspx.cs" Inherits="WebFormsExercices.Exercice160" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="name" runat="server" /><br />
        <asp:TextBox ID="password" runat="server" /><br />
        <asp:ListBox ID="country" runat="server" Rows="4">
            <asp:ListItem>France</asp:ListItem>
            <asp:ListItem>Danemark</asp:ListItem>
            <asp:ListItem>Norvège</asp:ListItem>
            <asp:ListItem>Allemagne</asp:ListItem>
            <asp:ListItem>Angleterre</asp:ListItem>
            <asp:ListItem>Suède</asp:ListItem>
            <asp:ListItem>Espagne</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Button ID="valider" runat="server" Text="Valider" OnClick="valider_Click" />
    </form>
</body>
</html>
