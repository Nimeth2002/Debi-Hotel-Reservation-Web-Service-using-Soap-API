<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="ClientApplication.Manage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 0px;
        }
        .auto-style2 {
            margin-left: 75px;
        }
        .auto-style3 {
            margin-left: 19px;
        }
        .auto-style4 {
            margin-left: 49px;
        }
        .auto-style5 {
            margin-left: 47px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1> =======Manage========== </h1>
        <p> 
            <asp:Label ID="lblRoomId" runat="server" Text="RoomId:"></asp:Label>
            <asp:TextBox ID="txtRoomId" runat="server" CssClass="auto-style4" Width="318px"></asp:TextBox>
        </p>
        <p> 
            <asp:Label ID="lblRoomType" runat="server" Text="Room type"></asp:Label>
            :<asp:TextBox ID="txtRoomType" runat="server" CssClass="auto-style3" Width="319px"></asp:TextBox>
        </p>
        <p> 
            <asp:Label ID="lblCountry" runat="server" Text="Country:"></asp:Label>
            <asp:TextBox ID="txtCountry" runat="server" CssClass="auto-style5" Width="316px"></asp:TextBox>
        </p>
        <p> 
            <asp:Label ID="lblprice" runat="server" Text="Price"></asp:Label>
            :<asp:TextBox ID="txtPrice" runat="server" CssClass="auto-style2" Width="319px"></asp:TextBox>
        </p>
        <p> 
            &nbsp;</p>
        <p> 
            <asp:Button ID="btnAdd" runat="server" Text="Add" Height="57px" OnClick="btnAdd_Click" Width="85px" />
&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="auto-style1" Height="56px" OnClick="btnDelete_Click" Width="103px" />
&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" Height="55px" OnClick="btnUpdate_Click" Width="98px" />
        </p>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="RoomId" DataSourceID="SqlDataSource1" CssClass="auto-style1" Width="683px" Height="266px">
                <Columns>
                    <asp:BoundField DataField="RoomId" HeaderText="RoomId" ReadOnly="True" SortExpression="RoomId" />
                    <asp:BoundField DataField="RoomType" HeaderText="RoomType" SortExpression="RoomType" />
                    <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB97_42ConnectionString5 %>" SelectCommand="SELECT [RoomId], [RoomType], [Country], [Price] FROM [Reservation]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
