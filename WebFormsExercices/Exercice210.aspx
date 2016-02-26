<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercice210.aspx.cs" Inherits="WebFormsExercices.Exercice210" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:MultiView ID="multiview" runat="server" ActiveViewIndex="0">
            <asp:View ID="view1" runat="server">
                <h5>Vous êtes:</h5>
                <asp:RadioButton ID="btnHomme" runat="server" Text="Un homme" OnCheckedChanged="btnHomme_CheckedChanged"/><br />
                <asp:RadioButton ID="btnFemme" runat="server" Text="Une femme" OnCheckedChanged="btnFemme_CheckedChanged" />
            </asp:View><br />
            <asp:View ID="view2" runat="server">
                <h5>Situation professionnelle:</h5>
                <asp:RadioButton ID="btnEtudiant" runat="server" Text="Etudiant" OnCheckedChanged="btnEtudiant_CheckedChanged"/><br />
                <asp:RadioButton ID="btnSalarie" runat="server" Text="Salarie" OnCheckedChanged="btnSalarie_CheckedChanged" />
            </asp:View><br />
            <asp:View ID="view3" runat="server">
                <h5>Situation professionnelle:</h5>
                <asp:RadioButton ID="btnBasket" runat="server" Text="Basket" OnCheckedChanged="btnSport_CheckedChanged"/><br />
                <asp:RadioButton ID="btnFootball" runat="server" Text="Football" OnCheckedChanged="btnSport_CheckedChanged" /><br />
                <asp:RadioButton ID="btnRugby" runat="server" Text="Rugby" OnCheckedChanged="btnSport_CheckedChanged" /><br />
                <asp:RadioButton ID="btnAucunSport" runat="server" Text="AucunSport" OnCheckedChanged="btnSport_CheckedChanged" />
            </asp:View><br />
            <asp:View ID="view4" runat="server">
                <h5>Merci d'avoir répondu</h5>
            </asp:View><br />
        </asp:MultiView><br />
        <asp:Button ID="suivant" runat="server" Text="Suivant" OnClick="suivant_Click" />
        <asp:Button ID="precedent" runat="server" Text="Precedent" OnClick="precedent_Click" />
        <asp:Button ID="refaire" runat="server" Text="Refaire le questionnaire" OnClick="refaire_Click"/>
        <asp:Button ID="sauvegarder" runat="server" Text="Sauvegarder"/><br />
        <asp:Label ID="lblSexe" Text="" runat="server" /><br />
        <asp:Label ID="lblStatus" Text="" runat="server" /><br />
        <asp:Label ID="lblSport" Text="" runat="server" /><br />
    </form>
</body>
</html>
