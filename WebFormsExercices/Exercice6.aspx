<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercice6.aspx.cs" Inherits="WebFormsExercices.Exercice6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form runat="server">
        <asp:FileUpload ID="file_upload" runat="server" />
        <asp:Button ID="valider" runat="server" OnClick="valider_Click" Text="Valider" />
    </form>
    <asp:Image ID="photo_upload" runat="server" />
</body>
</html>
