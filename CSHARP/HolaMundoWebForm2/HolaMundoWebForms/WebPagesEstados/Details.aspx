<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="HolaMundoWebForms.WebPagesEstados.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dl>
        <dt>
            <asp:Label ID="lblid" runat="server" Text="Id"></asp:Label>
        </dt>
        <dd>
            <asp:Label ID="lbliddef" runat="server" Text=""></asp:Label>
        </dd>
        <dt>
            <asp:Label ID="lblnombre" runat="server" Text="Nombre"></asp:Label>
        </dt>
        <dd>
            <asp:Label ID="lblnombredef" runat="server" Text=""></asp:Label>
        </dd>
    </dl>
</asp:Content>
