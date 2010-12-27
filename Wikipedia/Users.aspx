<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Site.Master" AutoEventWireup="true"
    CodeBehind="Users.aspx.cs" Inherits="Wikipedia.Users" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="Styles/GridView.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView runat="server" ID="UserList" OnItemDataBound="ItemDataBound">
        <ItemTemplate>
            <tr>
                <td><%# Eval("UserName") %></td>
                <td><%# Eval("Email") %></td>
                <td><asp:CheckBox runat="server" ID="Editor" OnCheckedChanged="RoleChange" AutoPostBack="true"
                Checked='<%# Roles.IsUserInRole((string) Eval("UserName"), "Editor") %>' /></td>
                <td><asp:CheckBox runat="server" ID="Admin" OnCheckedChanged="RoleChange" AutoPostBack="true"
                Checked='<%# Roles.IsUserInRole((string) Eval("UserName"), "Admin") %>' /></td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table>
                <tr>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Editor</th>
                    <th>Admin</th>
                </tr>
                <tr runat="server" id="itemPlaceholder" />
            </table>
        </LayoutTemplate>
    </asp:ListView>
</asp:Content>
