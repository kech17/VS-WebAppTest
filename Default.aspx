<%@ Page Language="C#" AutoEventWireup="true" Codebehind="Default.aspx.cs" Inherits="kechangTest._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="homestyle.css?=t<?php filemtime( 'style.css' ); ?>" />
    <title>Home Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main">
            <asp:Label ID="userName" CssClass="text" runat="server" Text="Username" Width="95px"></asp:Label>
            <asp:TextBox ID="userText" runat="server"></asp:TextBox>
            <!--OnTextChanged="TextBox1_TextChanged"-->
            <br />
            <asp:Label ID="password" CssClass="text" runat="server" Text="Password" Width="95px"></asp:Label>
            <asp:TextBox ID="passText" runat="server"></asp:TextBox><br />
            <!--OnTextChanged="TextBox1_TextChanged"-->
            <br />
            <asp:Button ID="logInBtn" CssClass="button" runat="server" Text="Log In" OnClick="onClick"
                OnClientClick="" />
            &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            <asp:Button ID="registerBtn" CssClass="button" runat="server" Text="Register" OnClick="onClick"
                OnClientClick="" />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
            <asp:Button ID="searchBtn" CssClass="button" runat="server" OnClick="onClick"
                Text="Search" /><br />
            <br />
            &nbsp;
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True"
                DataSourceID="ObjectDataSource1" PageSize="10">
            </asp:GridView>
        </div>
    </form>
    <p>
        <a class="tooltip" href="#">HELP<span class="custom help"><img src="upvote.png" alt="Error"
            height="48" width="48" /><em>Critical</em>This is just an example of what you can
            do using a CSS tooltip, feel free to get creative and produce your own!</span></a></p>
    <p>
        &nbsp;</p>
    <p>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetTable"
            TypeName="kechangTest.Structure.infoTable" ></asp:ObjectDataSource>
        &nbsp;&nbsp;
    </p>
</body>
</html>
