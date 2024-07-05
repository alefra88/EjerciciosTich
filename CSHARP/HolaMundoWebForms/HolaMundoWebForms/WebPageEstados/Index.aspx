<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="HolaMundoWebForms.WebPageEstados.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div>
    <asp:Label ID="lblEstados" runat="server" Text="Label"></asp:Label>
</div>
    <div>
        <asp:DropDownList ID="ddlEstados" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="btnConsultar" runat="server" Text="Button" OnClick="btnConsultar_Click" />
    </div>
</asp:Content>
