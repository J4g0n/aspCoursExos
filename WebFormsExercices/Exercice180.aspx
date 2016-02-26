<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercice180.aspx.cs" Inherits="WebFormsExercices.Exercice180" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="nomAgent" runat="server"/>
        <asp:Button ID="suivant" Text="Suivant" runat="server" OnClick="suivant_Click" />
        <asp:Button ID="precedent" Text="Precedent" runat="server" OnClick="precedent_Click" />
    </form>
</body>
</html>
