<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerLoginWebForm.aspx.cs" Inherits="ClientApplication.CustomerLoginWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

       .Password{
            text-align:center;
       }
       .btn{
           height:40px;
           width:300px;
           margin-top:10px;
       }
       </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h1> ====Log in page=== </h1>
        <div>
            <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server" Width="257px"></asp:TextBox>
            <br /> 
            <asp:Label CssClass="Password" ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" Width="266px"></asp:TextBox>
            <br />
            <asp:Button CssClass="btn" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Dont have a account Register here"></asp:Label>
        </p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
        </p>
        <p>

            &nbsp;</p>
        </div>
    </form>
</body>
</html>
