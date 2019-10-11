<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RaffleBundle.aspx.cs" Inherits="Bonus_assignment.RaffleBundle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>How many tickets do you want to purchase at 0.25$ per ticket:</h2>
            <asp:TextBox runat="server" ID="ticket_num"></asp:TextBox>
        </div>
        <div runat="server" id="ticket_summary"></div>
        <asp:Button runat="server" Text="Submit" />
    </form>
</body>
</html>
