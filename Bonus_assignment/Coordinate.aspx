<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Coordinate.aspx.cs" Inherits="Bonus_assignment.Coordinate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <section>
                <h2>X value:</h2>
                <asp:TextBox runat="server" ID="x_value"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please enter a x value" ControlToValidate="x_value"></asp:RequiredFieldValidator>
                <asp:CustomValidator runat="server" ControlToValidate="x_value" OnServerValidate="NumIsNotZero" ErrorMessage="Non zero values only!!"></asp:CustomValidator>
             </section>
            <section>
                <h2>Y value:</h2>
                <asp:TextBox runat="server" ID="y_value"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please enter a y value" ControlToValidate="y_value"></asp:RequiredFieldValidator>
                <asp:CustomValidator runat="server" ControlToValidate="y_value" OnServerValidate="NumIsNotZero" ErrorMessage="Non zero values only!!"></asp:CustomValidator>
             </section>
            <section>
                <div runat="server" id="position_summary"></div>
                <asp:Button runat="server" Text="Submit" />
            </section>
        </div>
    </form>
</body>
</html>
