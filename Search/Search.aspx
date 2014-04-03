<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="kechangTest.WebForm5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="seachUser" runat="server" Text="Search Username"></asp:Label>
        <asp:TextBox ID="userTextSearch" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="searchStart" runat="server" Text="Search" OnClick="searchClick"/><br />
        <br />
        <asp:GridView ID="searchResults" runat="server" AllowPaging="True" AllowSorting="True"
            DataSourceID="ObjectDataSource1" PageSize="7">
        </asp:GridView>
    
    </div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetTable"
            TypeName="kechangTest.Structure.infoTable"></asp:ObjectDataSource>
    </form>
</body>
</html>
