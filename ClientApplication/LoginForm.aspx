<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="ClientApplication.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
       
        .div{
            margin:80px,480px;
            padding:20px;
            border:1px;
        }
        .txt{
            width:300px;
            height:30px;
        }
       .btn{
           height:40px;
           width:300px;
           margin-top:10px;
       }
       .Username{
            text-align:center;
       }
       .Username1{
            text-align:center;
       }
       .Password{
            text-align:center;
       }
       .Password1{
            text-align:center;
       }
        .auto-style1 {
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1> &nbsp; =====Log in page======</h1>
        <div>
            <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server" Width="389px"></asp:TextBox>
            <br /> 
            <asp:Label CssClass="Password" ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" Width="392px"></asp:TextBox>
            <br />
            <asp:Button CssClass="auto-style1" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" Height="37px" Width="187px" />
        </div>
        <p>
            <strong>
            <asp:Label ID="Label1" runat="server" Text="*Dont have a account Register here"></asp:Label>
        &nbsp;* </strong>
        </p>
        <p>
            <asp:Button ID="btnRegister" runat="server" Text="register" OnClick="btnRegister_Click" Height="35px" Width="147px" />
        </p>
    </form>
</body>
</html>
