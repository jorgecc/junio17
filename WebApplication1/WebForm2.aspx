<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PaisId" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="PaisId" HeaderText="PaisId" ReadOnly="True" SortExpression="PaisId" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:junio17ConnectionString %>" SelectCommand="SELECT * FROM [Paises]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
