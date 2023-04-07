<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DebiWebForm.aspx.cs" Inherits="ClientApplication.DebiWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <h1> &nbsp; <em>==============Debi Hotel management System =========</em></h1>
        <p> <em><strong>User Selection </strong></em> </p>
        <p> <em><strong>Please select &nbsp;your Userlevel to continue</strong></em></p>
        <p> 
            <em>Admin</em></p>
        <p> 
            <asp:Button ID="btnAdmin" runat="server" Height="79px" Text="Admin" Width="531px" OnClick="btnAdmin_Click1" />
        </p>
        <p> 
            <em>Customer </em> </p>
        <p> 
            <asp:Button ID="btnCustomer" runat="server" Height="89px" Text="Customer" Width="533px" OnClick="btnCustomer_Click1" />
        </p>
        <p> 
            &nbsp;</p>
        <p> &nbsp;</p>
    </form>
    <p>
        <strong style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span>&nbsp;</span></strong><span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></p>
</body>
</html>
