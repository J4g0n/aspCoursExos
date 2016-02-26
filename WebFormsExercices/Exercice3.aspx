<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercice3.aspx.cs" Inherits="WebFormsExercices.Exercice3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <table>
        <tr>
            <% for(char i = 'A'; i < 'M'; i++) {%>
                    <td><%=i%></td>
            <%}%>
        </tr>
        <tr>
            <% for(char i = 'M'; i <= 'Z'; i++) {%>
                    <td><%=i%></td>
            <%}%>
        </tr>
    </table>
</body>
</html>
