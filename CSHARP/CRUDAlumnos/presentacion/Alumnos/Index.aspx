<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="presentacion.Alumnos.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="btnCrear" runat="server" Text="Crear" OnClick="btnCrear_Click" />
    <asp:GridView ID="gvAlumnos" runat="server" AutoGenerateColumns="False" OnRowCommand="gvAlumnos_RowCommand" AllowPaging="True" OnPageIndexChanging="gvAlumnos_PageIndexChanging" PageSize="5">

        <Columns>

            <asp:BoundField DataField="id" HeaderText="Id" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="primerApellido" HeaderText="Primer Apellido" />
            <asp:BoundField DataField="segundoApellido" HeaderText="Segundo Apellido" />
            <asp:BoundField DataField="correo" HeaderText="Correo" />
            <asp:BoundField DataField="telefono" HeaderText="Telefono" />
            <asp:BoundField DataField="idEstadoOrigen" HeaderText="Estado" />
            <asp:BoundField DataField="idEstatus" HeaderText="Estatus" />

            <asp:ButtonField CommandName="btnDetalles" Text="Detalles">
                <ControlStyle CssClass="btn btn-warning btn-sm" />
            </asp:ButtonField>
            <asp:ButtonField CommandName="btnEditar" Text="Editar">
                <ControlStyle CssClass="btn btn-success btn-sm" />
            </asp:ButtonField>
            <asp:ButtonField CommandName="btnEliminar" Text="Eliminar">
                <ControlStyle CssClass="btn btn-danger btn-sm" />
            </asp:ButtonField>
        </Columns>



    </asp:GridView>
</asp:Content>
