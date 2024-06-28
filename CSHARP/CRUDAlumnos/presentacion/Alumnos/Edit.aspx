<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="presentacion.Alumnos.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h2>Datos del Alumno</h2>

    <div>
        <asp:Label ID="lblEstatus" runat="server" Text="Estatus"></asp:Label>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtBxNombre" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Primer Apellido"></asp:Label>
    <asp:TextBox ID="txtBxPA" runat="server"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Text="SegundoApellido"></asp:Label>
    <asp:TextBox ID="txtBxSA" runat="server"></asp:TextBox>
    <asp:Label ID="Label4" runat="server" Text="Correo"></asp:Label>
    <asp:TextBox ID="txtBxCorreo" runat="server"></asp:TextBox>

    <asp:Label ID="IDtxtbxTel" runat="server" Text="telefono"></asp:Label>
    <asp:TextBox ID="txtBxTelefono" runat="server"></asp:TextBox>

    <asp:Label ID="Label6" runat="server" Text="fecha nacimiento"></asp:Label>
    <asp:TextBox ID="txtBxFecNac" runat="server"></asp:TextBox>

    <asp:Label ID="Label7" runat="server" Text="curp"></asp:Label>
    <asp:TextBox ID="txtBxCurp" runat="server"></asp:TextBox>

    <asp:Label ID="Label8" runat="server" Text="ID Estado"></asp:Label>
    <asp:TextBox ID="txtBxIdEdo" runat="server"></asp:TextBox>

    <asp:Label ID="Label9" runat="server" Text="ID Estatus"></asp:Label>
    <asp:TextBox ID="txtBxIdEstatus" runat="server"></asp:TextBox>
        <asp:Button ID="btnEdit" runat="server" Text="Guardar" OnClick="btnEdit_Click" />
    </div>
        <div>
            <a href="index.aspx">Regresar a Lista</a>
        </div>


</asp:Content>
