<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="presentacion.Alumnos.Details" %>

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
    <div>
        <asp:Button ID="btnCalcISR" runat="server" Text="Calcular ISR" OnClick="btnCalcISR_Click" />
    </div>
    <div>
        <asp:Button ID="btnCalcIMSS" runat="server" Text="Calcular IMSS" OnClick="btnCalcIMSS_Click" />
    </div>
    <div>
        <asp:Label ID="lblMensajeISRIMSS" runat="server" Text=""></asp:Label>
    </div>
        <div>
            <a href="index.aspx">Regresar a Lista</a>
        </div>
    <asp:Panel ID="Panel1" runat="server">
        <hr />
        <dl>
            <dt>ID</dt>
            <dd>
                <asp:Label ID="lblIDTablaISR" runat="server" Text=""></asp:Label></dd>
            <dt>Limite Inferior</dt>
            <dd>
                <asp:Label ID="lblLimInf" runat="server" Text="Limite Inferior"></asp:Label></dd>
            
            <dt>Limite Superior</dt><dd>
                <asp:Label ID="lblLimSup" runat="server" Text="Limite Superior"></asp:Label></dd>
           <dt>Cuota Fija</dt> <dd>
                <asp:Label ID="lblCuotaFija" runat="server" Text="Cuota Fija"></asp:Label></dd>
           <dt>Excedente</dt> <dd>
                <asp:Label ID="lblExedLimInf" runat="server" Text="Excedente"></asp:Label></dd>
           <dt>Subsidio</dt> <dd>
                <asp:Label ID="lblSubsidio" runat="server" Text="Subsidio"></asp:Label></dd>
            <dt>ISR</dt> <dd>
                <asp:Label ID="lblISR" runat="server" Text="ISR"></asp:Label></dd>
        </dl>
    </asp:Panel>
    <hr />
    <asp:Panel ID="Panel2" runat="server">
       <dl>
            <dt>EnfermedadMaternidad</dt>
        <dd>
            <asp:Label ID="lblEnfermedadMat" runat="server" Text=""></asp:Label></dd>
           <dt>Invalidez y vida</dt>
        <dd>
            <asp:Label ID="lblInvalidezVida" runat="server" Text=""></asp:Label></dd>
            <dt>Retiro</dt>
        <dd>
            <asp:Label ID="lblRetiro" runat="server" Text=""></asp:Label></dd>
            <dt>Cesantia</dt>
        <dd>
            <asp:Label ID="lblCesantia" runat="server" Text=""></asp:Label></dd>
            <dt>Infonavit</dt>
        <dd>
            <asp:Label ID="lblInfonavit" runat="server" Text=""></asp:Label></dd>
       </dl>
       
    </asp:Panel>

</asp:Content>

