<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Versaler.aspx.cs" Inherits="Versaler.Versaler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="sv">
<head runat="server">
    <title>Hur många versaler?</title>
</head>
<body>
    <h1>Hur många versaler?</h1>
    <form id="form1" runat="server">
    <div>
        <p>
             <asp:Label ID="Label1" runat="server" Text="Ange din text här:" AssociatedControlID="VersalerTextBox"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="VersalerTextBox" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox>
        </p>
        <p><asp:Label ID="ResultLabel" runat="server" Text="Label" Visible="False"></asp:Label></p>
        <asp:Button ID="SendButton" runat="server" Text="Bestäm antalet versaler" OnClick="SendButton_Click" />
    </div>
    </form>
</body>
</html>
