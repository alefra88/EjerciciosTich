<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="HolaMundoWebForms.WebPagesEstados.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="lblEstados" runat="server" Text="Estados"></asp:Label>
    </div>
    <div>
        <asp:DropDownList ID="ddlEstados" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
    </div>
</asp:Content>
