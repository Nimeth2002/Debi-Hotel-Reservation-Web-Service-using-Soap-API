<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationWebForm.aspx.cs" Inherits="ClientApplication.RegistrationWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Registration </h1>
            <h2> <em>Register your hotel here </em> </h2>
            <table>
                  <tr> 
                      <td>HotelId:</td>
                      <td>
                          <asp:TextBox ID="txtHotelId" runat="server" Width="351px" OnTextChanged="txtHotelId_TextChanged"></asp:TextBox>
                      </td>
                  </tr>
                 <tr> 
                      <td>HotelName:</td>
                      <td>
                          <asp:TextBox ID="txtHotelName" runat="server" Width="347px"></asp:TextBox>
                      </td>
                  </tr>
                 <tr> 
                      <td>Email:</td>
                      <td>
                          <asp:TextBox ID="txtEmail" runat="server" Width="346px"></asp:TextBox>
                      </td>
                  </tr>
                  <tr> 
                      <td>Address:</td>
                      <td>
                          <asp:TextBox ID="txtAddress" runat="server" Height="135px" Width="354px"></asp:TextBox>
                      </td>
                  </tr>
                <tr> 
                      <td>Phonenumber:</td>
                      <td>
                          <asp:TextBox ID="txtPhonenumber" runat="server" Width="354px"></asp:TextBox>
                      </td>
                  </tr>
                   <tr> 
                      <td>Location:</td>
                      <td>
                          <asp:TextBox ID="txtLocation" runat="server" Width="352px"></asp:TextBox>
                      </td>
                  </tr>
                    <tr> 
                      <td>Password:</td>
                      <td>
                          <asp:TextBox ID="txtPassword" runat="server" Width="351px"></asp:TextBox>
                      </td>
                  </tr>
                 <tr> 
                      <td>ConfirmPassword:</td>
                      <td>
                          <asp:TextBox ID="txtConfirmPassword" runat="server" Width="348px"></asp:TextBox>
                         
                      </td>
                  </tr>
                <tr> 
                      <td> 
                          <asp:Button ID="btnRegistration" runat="server" Text="Registration" OnClick="btnRegistration_Click" />
                      </td>
                  </tr>
            </table>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://localhost:44358/LoginForm.aspx">Back to Logn</asp:HyperLink>
        </div>
    </form>
</body>
</html>
