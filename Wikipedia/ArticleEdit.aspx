﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Site.Master" AutoEventWireup="true"
    CodeBehind="ArticleEdit.aspx.cs" Inherits="Wikipedia.ArticleEdit" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>Name: <asp:TextBox runat="server" ID="ArticleName" /></p>
    <p>Content: <asp:TextBox runat="server" ID="ArticleContent" TextMode="MultiLine" /></p>
    <p><asp:Button runat="server" ID="SubmitButton" Text="Submit" OnClick="SubmitClick" /></p>
</asp:Content>
