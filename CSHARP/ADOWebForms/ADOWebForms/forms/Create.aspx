<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="ADOWebForms.forms.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div>
        
            <div>
                <asp:Label ID="lblid" runat="server" Text="Agregar Estatus"></asp:Label>
            </div>
            <div>
                <asp:Label ID="lblclave" runat="server" Text="Clave"></asp:Label>  
                <asp:TextBox ID="txtclave" runat="server"></asp:TextBox>
                
            </div>
            <div>
                <asp:Label ID="lblnombre" runat="server" Text="nombre"></asp:Label>
                <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            </div>    
        <div>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click"  />
         
         <asp:Label ID="lblresultado" runat="server" Text=""></asp:Label>
        </div>
            <a href="index.aspx">Regresar a la lista</a>
    </div>
</asp:Content>
