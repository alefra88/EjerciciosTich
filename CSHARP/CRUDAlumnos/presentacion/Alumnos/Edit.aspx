<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="presentacion.Alumnos.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container">
        <h2>Datos del Alumno</h2>

        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="txtBxNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="No puede quedar vacio" ControlToValidate="txtBxNombre"></asp:RequiredFieldValidator>
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
                    <asp:RequiredFieldValidator ID="rfvPApellido" runat="server" ErrorMessage="No puede quedar vacio" ControlToValidate="txtBxPA"></asp:RequiredFieldValidator>
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
                    <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ErrorMessage="No puede quedar vacio" ControlToValidate="txtBxCorreo"></asp:RequiredFieldValidator>

                </div>
            </div>

            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="IDtxtbxTel" runat="server" Text="Teléfono"></asp:Label>
                    <asp:TextBox ID="txtBxTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="Label6" runat="server" Text="Fecha de Nacimiento"></asp:Label>
                    <asp:TextBox ID="txtBxFecNac" runat="server" CssClass="form-control"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rfvFecNac" runat="server" ErrorMessage="No puede quedar vacio" ControlToValidate="txtBxFecNac"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="rvFecNav" runat="server" ErrorMessage="La fecha debe estar entre 01-01-1990 y 31-12-2000" ControlToValidate="txtBxFecNac" MaximumValue="31-12-2010" MinimumValue="01-01-1990"></asp:RangeValidator>

                </div>

                <div class="form-group">
                    <asp:Label ID="Label7" runat="server" Text="CURP"></asp:Label>
                    <asp:TextBox ID="txtBxCurp" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCurp" runat="server" ErrorMessage="No puede quedar vacio" ControlToValidate="txtBxCurp"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revCurp" runat="server"
                ControlToValidate="txtBxCurp"
                ValidationExpression="/^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$/"
                ErrorMessage="Ingresa el Formato CURPCorrecto"
                Display="Dynamic">
            </asp:RegularExpressionValidator>
                </div>

                <div class="form-group">
                    <asp:Label ID="Label5" runat="server" Text="Sueldo"></asp:Label>
                    <asp:TextBox ID="txtBxSueldo" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RangeValidator ID="rvSueldo" runat="server" ErrorMessage="El sueldo debe estar entre los 10000 y los 40000" ControlToValidate="txtBxSueldo" MaximumValue="40000" MinimumValue="10000"></asp:RangeValidator>

                </div>

                <div class="form-group">
                    <asp:Label ID="Label8" runat="server" Text="ID Estado"></asp:Label>
                    <asp:TextBox ID="txtBxIdEdo" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="Label9" runat="server" Text="ID Estatus"></asp:Label>
                    <asp:TextBox ID="txtBxIdEstatus" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnEdit" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnEdit_Click" />
                <a href="index.aspx" class="btn btn-secondary">Regresar a Lista</a>
            </div>
        </div>
    </div>


</asp:Content>
