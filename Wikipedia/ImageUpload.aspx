<%@ Page Title="Wikipedia:Upload" Language="C#" MasterPageFile="~/Layouts/Site.Master" AutoEventWireup="true"
    CodeBehind="ImageUpload.aspx.cs" Inherits="Wikipedia.ImageUpload" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Image Upload</h1>
    <p><asp:FileUpload ID="File" runat="server" /></p>
    <p><asp:Button ID="UploadButton" runat="server" Text="Upload" OnClick="UploadClick" /></p>
</asp:Content>
