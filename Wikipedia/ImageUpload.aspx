<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Site.Master" AutoEventWireup="true"
    CodeBehind="ImageUpload.aspx.cs" Inherits="Wikipedia.ImageUpload" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FileUpload ID="File" runat="server" />
    <asp:Button ID="UploadButton" runat="server" Text="Upload" OnClick="UploadClick" />
</asp:Content>
