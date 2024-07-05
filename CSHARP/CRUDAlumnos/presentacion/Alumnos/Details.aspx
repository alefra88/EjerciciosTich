<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="presentacion.Alumnos.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h2>Datos del Alumno</h2>
    <hr />
    <dl>
        <dt>ID</dt>
        <dd>
            <asp:Label ID="lblId" runat="server" Text=""></asp:Label></dd>

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

        <asp:Button ID="btnCalcISR" runat="server" Text="CalcularISR" OnClick="btnCalcISR_Click" />
    </div>

    <div>
        <input id="btnCalcIMSS" type="button" text="CalcularIMSS" value="CalcularIMSS" onclick="fCalcularIMSS()" />

    </div>

    <div>
        <asp:Label ID="lblMensajeISRIMSS" runat="server" Text=""></asp:Label>
    </div>

    <div>
        <a href="index.aspx">Regresar a Lista</a>
    </div>
    <asp:Panel ID="Panel1" runat="server" Visible="false">
        <hr />
        <dl>
            <dt>ID</dt>
            <dd>
                <asp:Label ID="lblIDTablaISR" runat="server" Text=""></asp:Label></dd>
            <dt>Limite Inferior</dt>
            <dd>
                <asp:Label ID="lblLimInf" runat="server" Text="Limite Inferior"></asp:Label></dd>

            <dt>Limite Superior</dt>
            <dd>
                <asp:Label ID="lblLimSup" runat="server" Text="Limite Superior"></asp:Label></dd>
            <dt>Cuota Fija</dt>
            <dd>
                <asp:Label ID="lblCuotaFija" runat="server" Text="Cuota Fija"></asp:Label></dd>
            <dt>Excedente</dt>
            <dd>
                <asp:Label ID="lblExedLimInf" runat="server" Text="Excedente"></asp:Label></dd>
            <dt>Subsidio</dt>
            <dd>
                <asp:Label ID="lblSubsidio" runat="server" Text="Subsidio"></asp:Label></dd>
            <dt>ISR</dt>
            <dd>
                <asp:Label ID="lblISR" runat="server" Text="ISR"></asp:Label></dd>
        </dl>
    </asp:Panel>
    <hr />
    <asp:Panel ID="Panel2" runat="server" Visible="false">
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
            <dd>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label></dd>
        </dl>
    </asp:Panel>
    <!-- modal isr -->

    <div  id="ModalISR" class="modal" tabindex="-1" role="dialog">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">Tabla Calculo ISR</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <dl>
                        <dt>LimiteInferior</dt>
                        <dd>
                            <asp:Label ID="lblModalLimInf" runat="server" Text="LimInf"></asp:Label></dd>
                        <dt>
                            <asp:Label ID="lblModalLimSup" runat="server" Text="LimSup"></asp:Label></dt>
                        <dt>Cuota Fija</dt>
                        <dd>
                            <asp:Label ID="lblModalCuotaFija" runat="server" Text="Cuota Fija"></asp:Label></dd>
                        <dt>Excedente</dt>
                        <dd>
                            <asp:Label ID="lblModalExcedente" runat="server" Text="Excedente"></asp:Label></dd>
                        <dt>Subsidio</dt>
                        <dd>
                            <asp:Label ID="lblModalSubsidio" runat="server" Text="Subsidio"></asp:Label></dd>
                        <dt>ISR</dt>
                        <dd>
                            <asp:Label ID="lblModalISR" runat="server" Text="ISR"></asp:Label></dd>
                    </dl>

                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar ventana</button>

                </div>
            </div>
        </div>
    </div>
    <!--modal IMSS-->
    <!-- Button trigger modal -->
  
    <div id="modalIMSS" class="modal" tabindex="-1" role="dialog">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">Tabla Calculo ISR</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <dl>
                        <dt>Enfermedad y maternidad</dt>
                        <dd>
                            <asp:Label ID="lblModalEnfermedadMaternidad" runat="server" Text="EnfermedadMaternidad"></asp:Label></dd>

                        <dt>Invalidez y vida</dt>
                        <dd>
                            <asp:Label ID="lblModalInvalidezYVida" runat="server" Text="LimSup"></asp:Label></dd>

                        <dt>Retiro</dt>
                        <dd>
                            <asp:Label ID="lblModalRetiro" runat="server" Text="Retiro"></asp:Label></dd>

                        <dt>Cesantia</dt>
                        <dd>
                            <asp:Label ID="lblModalCesantia" runat="server" Text="Cesantia"></asp:Label></dd>
                        <dt>Infonavit</dt>
                        <dd>
                            <asp:Label ID="lblModalInfonavit" runat="server" Text="Infonavit"></asp:Label></dd>
                    </dl>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar ventana</button>

                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        
        function fCalcularIMSS() {
            var urlws = 'http://localhost:64905/WebService1.asmx/CalcularIMSS';
            var id = $("#<%=lblId.ClientID%>").text();
            var imss = { id: id };
            var parametros = JSON.stringify(imss);

            $.ajax({
                type: 'POST',
                url: urlws,
                data: parametros,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: RecibeObjeto,
                error: errorGenerico
            });
        }

         
            function RecibeObjeto(resultado, estatus, jqXHR) {
                try {
                    imss = resultado.d;
                    if (imss != null) {
                        $("#<%=lblModalEnfermedadMaternidad.ClientID%>").text(imss.EnfermedadMaternidad);
                        $("#<%=lblModalInvalidezYVida.ClientID%>").text(imss.InvalidezVida);
                        $("#<%=lblModalRetiro.ClientID%>").text(imss.Retiro);
                        $("#<%=lblModalCesantia.ClientID%>").text(imss.Cesantia);
                        $("#<%=lblModalInfonavit.ClientID%>").text(imss.Cesantia);
                        $('#modalIMSS').modal('show');
                    }
                    else {
                        alert('La respuesta recibida es incorrecta ' + resultado.d);
                    }

                }
                catch (ex) {
                    alert('Error al recibir los datos');
                }
            }
            //recibe error
            function errorGenerico(jqXHR, estatus, error) {
                var msg = '';
                if (jqXHR.status === 0) {
                    msg = 'No está conectado, favor de verificar su conexión.';
                }
                else if (jqXHR.status === 404) {
                    msg = 'Página no encontrada [404]';
                }
                else if (jqXHR.status === 500) {
                    msg = 'Error no hay conexión al servidor [500]';
                }
                else if (jqXHR.status === 'parseerror') {
                    msg = 'El parseo del JSON es erróneo.';
                }
                else if (jqXHR.status === 'timeout') {
                    $('body').addClass('loaded');
                }
                else if (jqXHR.status === 'abort') {
                    msg = 'La petición Ajax fue abortada.';
                }
                else {
                    msg = 'Error no conocido. ';
                    console.log(exception);
                }
                alert(msg);
            }
    </script>
</asp:Content>

