<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Site.Master" AutoEventWireup="true"
    CodeBehind="Domain.aspx.cs" Inherits="Wikipedia.Domain" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Debug" runat="server">test</asp:Label>
    <asp:GridView runat="server" DataSourceID="Articles_EDS" AllowSorting="True" 
        AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" 
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:TemplateField HeaderText="Name" SortExpression="Versions.OrderBy(ver => ver.CreateDate).First().Name">
                <ItemTemplate>
                    <a runat="server" href='<%# "~/Article.aspx?id=" + Eval("Id") %>'><%# Eval ("Name") %></a>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="UserName" HeaderText="UserName" 
                SortExpression="UserName" />
            <asp:BoundField DataField="Domain.Name" HeaderText="Domain"
                SortExpression="Domain.Name" />
            <asp:CheckBoxField DataField="IsProtected" HeaderText="IsProtected" 
                SortExpression="IsProtected" />
            <asp:BoundField DataField="CreateDate" HeaderText="CreateDate" 
                SortExpression="CreateDate" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:EntityDataSource ID="Articles_EDS" runat="server" AutoGenerateWhereClause="True" 
        ConnectionString="name=WikipediaEntities" 
        DefaultContainerName="WikipediaEntities" EnableFlattening="False" 
        EntitySetName="Articles" Include="Domain, Versions" Where="">
        <WhereParameters>
            <asp:QueryStringParameter Name="DomainId" QueryStringField="id" Type="Int32" />
        </WhereParameters>
    </asp:EntityDataSource>
</asp:Content>
