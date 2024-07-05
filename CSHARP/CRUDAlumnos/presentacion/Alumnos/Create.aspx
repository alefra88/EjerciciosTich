<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="presentacion.Alumnos.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h2>Datos del Alumno</h2>

        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtBxNombre" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="No puede quedar en blanco" ControlToValidate="txtBxNombre" CssClass="text-danger"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revNombre" runat="server"
                ControlToValidate="txtBxNombre"
                ValidationExpression="^[a-zA-Z\s]+$"
                ErrorMessage="Solo se permiten letras y espacios"
                Display="Dynamic">
            </asp:RegularExpressionValidator>
        </div>

        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Primer Apellido"></asp:Label>
            <asp:TextBox ID="txtBxPA" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPApellido" runat="server" ErrorMessage="No puede quedar en blanco" ControlToValidate="txtBxPA" CssClass="text-danger"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revPApellido" runat="server"
                ControlToValidate="txtBxPA"
                ValidationExpression="^[a-zA-Z\s]+$"
                ErrorMessage="Solo se permiten letras y espacios"
                Display="Dynamic">
            </asp:RegularExpressionValidator>
        </div>

        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Segundo Apellido"></asp:Label>
            <asp:TextBox ID="txtBxSA" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revSApellido" runat="server"
                ControlToValidate="txtBxSA"
                ValidationExpression="^[a-zA-Z\s]+$"
                ErrorMessage="Solo se permiten letras y espacios"
                Display="Dynamic">
            </asp:RegularExpressionValidator>
        </div>

        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Correo"></asp:Label>
            <asp:TextBox ID="txtBxCorreo" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ErrorMessage="No puede quedar en blanco" ControlToValidate="txtBxCorreo" CssClass="text-danger"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Teléfono"></asp:Label>
            <asp:TextBox ID="txtBxTelefono" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="Fecha de Nacimiento"></asp:Label>
            <asp:TextBox ID="txtBxFecNac" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvFecNac" runat="server" ErrorMessage="No puede quedar en blanco" ControlToValidate="txtBxFecNac" CssClass="text-danger" TextMode="Date"></asp:RequiredFieldValidator>
             <asp:RangeValidator ID="rvFecNav" runat="server" ErrorMessage="La fecha debe estar entre 01-01-1990 y 31-12-2000" ControlToValidate="txtBxFecNac" MaximumValue="31-12-2010" MinimumValue="01-01-1990"></asp:RangeValidator>

        </div>

        <div class="form-group">
            <asp:Label ID="Label11" runat="server" Text="Sueldo"></asp:Label>
            <asp:TextBox ID="txtBxSueldo" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RangeValidator ID="rvSueldo" runat="server" ErrorMessage="El sueldo debe estar entre los 10000 y los 40000" ControlToValidate="txtBxSueldo" MaximumValue="50000" MinimumValue="10000"></asp:RangeValidator>

        </div>

        <div class="form-group">
            <asp:Label ID="Label7" runat="server" Text="CURP"></asp:Label>
            <asp:TextBox ID="txtBxCurp" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCurp" runat="server" ErrorMessage="No puede quedar en blanco" ControlToValidate="txtBxCurp" CssClass="text-danger"></asp:RequiredFieldValidator>
            <%--<asp:RegularExpressionValidator ID="revCurp" runat="server"
                ControlToValidate="txtBxCurp"
                ValidationExpression="/^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$/"
                ErrorMessage="Ingresa el Formato CURPCorrecto"
                Display="Dynamic">
            </asp:RegularExpressionValidator>--%>
            <asp:CustomValidator ID="cvScriptJavascript" runat="server" ErrorMessage="la fecha de nacimiento debe coincidir con la fecha curp" ControlToValidate="txtBxCurp" ClientValidationFunction="CurpMATCHFecNac" OnServerValidate="cvScriptJavascript_ServerValidate"></asp:CustomValidator>

        </div>

    

        <div class="form-group">
            <asp:Label ID="Label8" runat="server" Text="ID Estado"></asp:Label>
            <asp:TextBox ID="txtBxIdEdo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="Label9" runat="server" Text="ID Estatus"></asp:Label>
            <asp:TextBox ID="txtBxIdEstatus" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
    </div>
    <script type="text/javascript">
        function CurpMATCHFecNac(source, args) {
            var fecNac = $("#<%=txtBxFecNac.ClientID%>").val();
            var extracCurpFecha = $("#<%=txtBxCurp.ClientID%>").val();
            var extracCurpFecha = extracCurpFecha.substr(5, 6);
            var fecNacFormatCurp = fecNac.substr(2, 2) + fecNac.substr(5, 2) + fecNac.substr(8, 2).reverse();
            args.IsValid = extracCurpFecha == fecNacFormatCurp;
        }

    </script>
</asp:Content>
