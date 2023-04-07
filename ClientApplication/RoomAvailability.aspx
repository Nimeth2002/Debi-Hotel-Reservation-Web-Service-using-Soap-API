<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoomAvailability.aspx.cs" Inherits="ClientApplication.RoomAvailability" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-right: 134px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
            <br />
            &nbsp;
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Hotel_Id" DataSourceID="SqlDataSource2" Height="285px" Width="742px" CssClass="auto-style1">
            <Columns>
                <asp:BoundField DataField="Hotel_Id" HeaderText="Hotel_Id" SortExpression="Hotel_Id" ReadOnly="True" />
                <asp:BoundField DataField="Hotel_Name" HeaderText="Hotel_Name" SortExpression="Hotel_Name" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                <asp:BoundField DataField="Room_Type" HeaderText="Room_Type" SortExpression="Room_Type" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DB97_42ConnectionString7 %>" SelectCommand="SELECT [Hotel_Id], [Hotel_Name], [Country], [Location], [Room_Type], [Price] FROM [HoyelAvailability]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB97_42ConnectionString6 %>" SelectCommand="SELECT [Price], [Country], [RoomType], [RoomId] FROM [Reservation]"></asp:SqlDataSource>
    </form>
</body>
</html>
