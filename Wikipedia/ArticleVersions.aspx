<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Site.Master" AutoEventWireup="true"
    CodeBehind="ArticleVersions.aspx.cs" Inherits="Wikipedia.ArticleVersions" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="Styles/GridView.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView runat="server" ID="Versions" AllowPaging="True" 
        AllowSorting="True" CellPadding="4" DataSourceID="Versions_EDS" 
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" />
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
    <asp:EntityDataSource runat="server" ID="Versions_EDS" 
        AutoGenerateWhereClause="True" ConnectionString="name=WikipediaEntities" 
        DefaultContainerName="WikipediaEntities" EnableDelete="True" 
        EnableFlattening="False" EntitySetName="Versions" OnDeleted="VersionDeleted">
        <WhereParameters>
            <asp:QueryStringParameter Name="ArticleId" QueryStringField="id" Type="Int32" />
        </WhereParameters>
    </asp:EntityDataSource>
</asp:Content>
