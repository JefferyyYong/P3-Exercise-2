<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmOrder.aspx.cs" Inherits="P3_Exercise_2.ConfirmOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        This is to confirm that you have ordered :<br />
        <br />
        <asp:Label ID="lblOrder" runat="server"></asp:Label>
        <br />
        <br />
        The time now is
        <asp:Label ID="lblTimeNow" runat="server"></asp:Label>
        . You will receive your order within 25 minutes.<br />
        We will reach at you doorstep before or at
        <asp:Label ID="lblReceiveTime" runat="server"></asp:Label>
        .<br />
        <br />
        Thank you.</form>
</body>
</html>
