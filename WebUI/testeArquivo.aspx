<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="testeArquivo.aspx.cs" Inherits="WebUI.testeArquivo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FileUpload ID="fuArquivo" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   
        <asp:Button ID="btnSalvar" runat="server" BackColor="#66FF33" BorderWidth="4px" OnClick="Button1_Click" Text="Salvar" />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
