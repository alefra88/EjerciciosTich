<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit2.aspx.cs" Inherits="ADOWebForms.forms.Edit2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div>
        
            <div>
                <asp:Label ID="lblid" runat="server" Text="Actualizar Estatus"></asp:Label>
            </div>
         <div>
             <asp:Label ID="lbl" runat="server" Text="ID"></asp:Label>  
                <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
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
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnActualizar_Click"  />
         
         <asp:Label ID="lblresultado" runat="server" Text=""></asp:Label>
        </div>
            <a href="index.aspx">Regresar a la lista</a>
    </div>
</asp:Content>
