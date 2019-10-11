<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weekly_Calendar.aspx.cs" Inherits="Bonus_assignment.Weekly_Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>If you work or study on a certain day use the check box. IF the checkbox is empty then you dont work or study</p>
            <asp:CheckBoxList runat="server" ID="week_schedule">
                <asp:ListItem Value="Monday">Monday</asp:ListItem>
                <asp:ListItem Value="Tuesday">Tuesday</asp:ListItem>
                <asp:ListItem Value="Wednesday">Wednesday</asp:ListItem>
                <asp:ListItem Value="Thursday">Thursday</asp:ListItem>
                <asp:ListItem Value="Friday">Friday</asp:ListItem>
                <asp:ListItem Value="Saturday">Saturday</asp:ListItem>
                <asp:ListItem Value="Sunday">Sunday</asp:ListItem>
            </asp:CheckBoxList>
            <div id="month_summary" runat="server"></div>
            <asp:Button runat="server" Text="Submit"/>
        </div>
    </form>
</body>
</html>
