<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercice11.aspx.cs" Inherits="WebFormsExercices.Exercice11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form runat="server">
        <asp:Calendar ID="calendar" runat="server" OnSelectionChanged="calendar_SelectionChanged" />
        <asp:Label ID="labelDate" runat="server" >Date</asp:Label>
    </form>
</body>
</html>
