<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerRegistrationForm.aspx.cs" Inherits="ClientApplication.CustomerRegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <h1> Registration </h1>
            <h2> <em>Register your hotel here </em> </h2>
            <table>
                  <tr> 
                      <td>Name:</td>
                      <td>
                          <asp:TextBox ID="txtName" runat="server" Width="347px"></asp:TextBox>
                      </td>
                  </tr>
                 <tr> 
                      <td>Email:</td>
                      <td>
                          <asp:TextBox ID="txtEmail1" runat="server" Width="346px"></asp:TextBox>
                      </td>
                  </tr>
                  <tr> 
                      <td>Address:</td>
                      <td>
                          <asp:TextBox ID="txtAddress1" runat="server" Height="135px" Width="354px"></asp:TextBox>
                      </td>
                  </tr>
                <tr> 
                      <td>Phonenumber:</td>
                      <td>
                          <asp:TextBox ID="txtPhonenumber1" runat="server" Width="354px"></asp:TextBox>
                      </td>
                  </tr>
                    <tr> 
                      <td>Password:</td>
                      <td>
                          <asp:TextBox ID="txtPassword1" runat="server" Width="351px"></asp:TextBox>
                      </td>
                  </tr>
                 <tr> 
                      <td>ConfirmPassword:</td>
                      <td>
                          <asp:TextBox ID="txtConfirmPassword1" runat="server" Width="348px"></asp:TextBox>
                         
                      </td>
                  </tr>
                <tr> 
                      <td> 
                          
                          <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="Button1_Click" />
                          
                      </td>
                  </tr>
            </table>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DebiWebForm.aspx">Back to main page</asp:HyperLink>
        </form>
</body>
</html>
