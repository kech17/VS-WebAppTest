<%@ Page Language="C#" AutoEventWireup="true" Codebehind="WebForm3.aspx.cs" Inherits="kechangTest.WebForm3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
                AutoGenerateColumns="False" Width="366px"
                CellPadding="4" ForeColor="#333333" GridLines="None" OnSorting="sortClick">
                <Columns>
                <asp:TemplateField HeaderText="Delete">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkSelect" runat="server" />
                        </ItemTemplate>
                       
                    </asp:TemplateField>
                    
                    <asp:BoundField  DataField="Username"  HeaderText="Username" InsertVisible="False"
                        ReadOnly="False" SortExpression="Username" />
                    <asp:BoundField  DataField="Password"  HeaderText="Password" SortExpression="Password" />
                    
                </Columns>
                
            </asp:GridView>
            &nbsp;
            <asp:Button ID="Button1" runat="server" Text="Delete" OnClick = "onClick"/>
            <asp:Button ID="backBtn" runat="server" Text="Back" OnClick = "onClick"/><br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="BANK" OnClick-="onClick"/></div>
    </form>
</body>
</html>
