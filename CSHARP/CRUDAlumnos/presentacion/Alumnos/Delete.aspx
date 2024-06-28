<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="presentacion.Alumnos.Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   
        
        <h2>Datos del Alumno</h2>
        <hr />
        <dl>
            <dt>ID</dt>
            <dd>
                <asp:Label ID="lblId" runat="server" Text="ID"></asp:Label></dd>

            <dt>Nombre</dt>
            <dd>
                <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label></dd>

         
                <dt>Primer Apellido</dt>
            <dd>
                <asp:Label ID="lblPA" runat="server" Text="Primer Apellido"></asp:Label></dd>

        
                <dt>Segundo Apellido</dt>
            <dd>
                <asp:Label ID="lblSA" runat="server" Text="Segundo Apellido"></asp:Label></dd>

         
                <dt>Fecha Nacimiento</dt>
            <dd>
                <asp:Label ID="lblFecNac" runat="server" Text="Fecha Nacimiento"></asp:Label></dd>

       
                <dt>CURP</dt>
            <dd>
                <asp:Label ID="lblCURP" runat="server" Text="CURP"></asp:Label></dd>

            
                <dt>Correo</dt>
            <dd>
                <asp:Label ID="lblCorreo" runat="server" Text="Correo"></asp:Label></dd>

            
                <dt>Telefono</dt>
            <dd>
                <asp:Label ID="lblTel" runat="server" Text="Telefono"></asp:Label></dd>

            
                <dt>Sueldo Mensual</dt>
            <dd>
                <asp:Label ID="lblSueldoMe" runat="server" Text="Sueldo Mensual"></asp:Label></dd>

            
                <dt>EStado</dt>
            <dd>
                <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label></dd>

            
                <dt>Estatus</dt>
            <dd>
                <asp:Label ID="lblEstatus" runat="server" Text="Estatus"></asp:Label></dd>

           
        </dl>
    <asp:Button ID="btnDelete" runat="server" Text="Eliminar" OnClick="btnDelete_Click1" />
        <div>
            <a href="index.aspx">Regresar a Lista</a>
        </div>


</asp:Content>
