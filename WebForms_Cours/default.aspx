<%@ Page Language="C#" Theme="Bleu" %>

<!DOCTYPE html>
<script runat="server">

    protected void btn_Annuler_Click(object sender, EventArgs e)
    {

    }

    protected void btn_Valider_Click(object sender, EventArgs e)
    {
        lbl_Affichage.Text = "Vous avez cliqué";
    }
</script>




<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<meta charset="utf-8" />
</head>
<body>
    <form   runat="server" ID="form">
        <asp:Label ID="lbl_hello"
            runat="server"
            Text="Hello de asp.net"
            font-Size="large"
            font-color="CC8866">
        </asp:Label>
        <asp:Label ID="lbl_Affichage"
            runat="server"
            Text="..."
            font-Size="large"
            font-color="CC8866">
        </asp:Label>
        <asp:Button 
            ID="btn_Valider"
            runat="server"
            Text="Valider" OnClick="btn_Valider_Click"
        />
        <asp:Button
            ID="btn_Annuler"
            runat="server"
            Text="Annuler" OnClick="btn_Annuler_Click"
        />
    </form>
</body>
</html>
