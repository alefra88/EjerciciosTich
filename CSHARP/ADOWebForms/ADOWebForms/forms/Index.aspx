<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ADOWebForms.forms.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<asp:DropDownList ID="ddlEstatusAlumnos" runat="server" Height="23px"></asp:DropDownList>
<asp:GridView ID="dgvEstatusAlumnos" runat="server"></asp:GridView>

    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
    <asp:Button ID="btbDetalles" runat="server" Text="Detalles" OnClick="btbDetalles_Click" />
    <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />



</asp:Content>
