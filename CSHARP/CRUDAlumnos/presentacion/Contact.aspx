<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="presentacion.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Contacto</h3>
    <address>
        Dirección<br />
        Avenida siempre viva<br />
        <abbr title="Phone">P:</abbr>
        412456666
    </address>

    <address>
        <strong>Contacto:</strong>   <a href="mailto:Support@example.com">contacto@tich.com</a><br />
        <strong>Comercial:</strong> <a href="mailto:Marketing@example.com">comercial@tich.com</a>
    </address>
</asp:Content>
