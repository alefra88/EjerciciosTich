<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="presentacion.Alumnos.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>    
    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtBxNombre" runat="server"></asp:TextBox>

    <asp:Label ID="Label2" runat="server" Text="Primer Apellido"></asp:Label>
    <asp:TextBox ID="txtBxPA" runat="server"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Text="SegundoApellido"></asp:Label>
    <asp:TextBox ID="txtBxSA" runat="server"></asp:TextBox>
    <asp:Label ID="Label4" runat="server" Text="Correo"></asp:Label>
    <asp:TextBox ID="txtBxCorreo" runat="server"></asp:TextBox>

    <asp:Label ID="Label5" runat="server" Text="telefono"></asp:Label>
    <asp:TextBox ID="txtBxTelefono" runat="server"></asp:TextBox>

    <asp:Label ID="Label6" runat="server" Text="fecha nacimiento"></asp:Label>
    <asp:TextBox ID="txtBxFecNac" runat="server"></asp:TextBox>

    <asp:Label ID="Label7" runat="server" Text="curp"></asp:Label>
    <asp:TextBox ID="txtBxCurp" runat="server"></asp:TextBox>

        <asp:Label ID="Label10" runat="server" Text="Salario"></asp:Label>
    <asp:TextBox ID="TxtBxSalario" runat="server"></asp:TextBox>

    <asp:Label ID="Label8" runat="server" Text="ID Estado"></asp:Label>
    <asp:TextBox ID="txtBxIdEdo" runat="server"></asp:TextBox>

    <asp:Label ID="Label9" runat="server" Text="ID Estatus"></asp:Label>
    <asp:TextBox ID="txtBxIdEstatus" runat="server"></asp:TextBox>
    </div>
   

    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
</asp:Content>
