<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="api_img_generator.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--<div class="container" id="capture">
        <div class="jumbotron">
            <h1 class="display-4">Ingrese numero de factura</h1>
            <p class="lead">El numero de factura se encuentra en el lado izquierdo superior</p>
            <hr class="my-4">
            <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox><br />
            <a class="btn btn-primary btn-lg" href="#" role="button">Buscar</a>
        </div>
    </div>-->
    <br />
    <br />
    <div class="container">
        <br />
        <asp:Label runat="server" ID="lblResponse"></asp:Label>
      <span id="canva">
            <table class="table table-sm table-responsive-sm" id="table">
                <tr class="no-borders" >
                   <td colspan="3" rowspan="3"  class="no-borders">
                        <img src="img/logo.jpg" class="img-fluid" width="200" height="250" />
                       
                   </td>
                   
                </tr>
                <tr>
                    <td style="text-align:right" class="border-top border-right no-borders">
                         <asp:Label runat="server" ID="lblPagina"></asp:Label>
                    </td>
                  
                </tr>
                <tr>
                     <td style="text-align:right" class="border-right no-borders1">
                        Fecha de emision: 
                        <asp:Label runat="server" ID="lblFechaDocumento"></asp:Label>
                    </td>
                </tr>
                <tr class="border-top" >
                    <td colspan="3" class="border-right no-borders border-top">
                        <strong>TARJETAZO, S.A</strong>
                        <br />
                        <asp:Label runat="server" ID="lblDireccionEmpresa"></asp:Label>
                        <br />
                        GUATEMALA, GUATEMALA
                    </td>
                    <td colspan="2" class="border-right border-top"><strong>
                        <asp:Label runat="server" ID="lblTipoDocumento"></asp:Label></strong><br />
                        <asp:Label runat="server" ID="lblResolucion"></asp:Label>
                        <asp:Label runat="server" ID="lblSerieDocumento"></asp:Label><br />
                        <asp:Label runat="server" ID="lblNumeroDocumento"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" class="border-right">
                         <asp:Label runat="server" ID="lblNitEmpresa"></asp:Label>

                    </td>                  
                    <td colspan="2" class="bold-text">
                        <asp:Label runat="server" ID="lblSujetoPago"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td colspan="3" class="border-right">
                        <asp:Label runat="server" ID="lblPBX"></asp:Label></td>
                    <td colspan="2" class="yes-borders"></td>
                </tr>
                <tr class="btop">
                    <td colspan="3" class="btop">
                        <asp:Label runat="server" ID="lblNombreCliente"></asp:Label></td>
                    <td colspan="2" class="btop">
                        <asp:Label runat="server" ID="lblNitCliente"></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label runat="server" ID="lblDireccionCliente"></asp:Label></td>
                    <td colspan="2">
                        <asp:Label runat="server" ID="lblDPICliente"></asp:Label></td>
                </tr>
                <tr>
                    <td class="vienen" colspan="5">
                        <asp:Label runat="server" ID="lblCreditoCliente"></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label runat="server" ID="lblTelefonoCliente"></asp:Label>

                    </td>
                    <td colspan="3">
                        <asp:Label runat="server" ID="lblVendedor"></asp:Label></td>
                </tr>
                <!--<tr>
                   <td ><font color="#fff">Header 1</font></td>
                    <td><font color="#fff">Header 1</font></td>
                    <td><font color="#fff">Header 1</font></td>
                    <td><font color="#fff">Header 1</font></td>
                    <td><font color="#fff">Header 1</font></td>
                </tr>-->
            
        </table>
        <table runat="server" id="secondtables" class="table table-sm table-responsive-sm">
            <tr>
                <th scope="col">CANT</th>
                <th scope="col">ARTICULO</th>
                <th scope="col">DESCRIPCION</th>
                <th scope="col">PREC UNIT</th>
                <th scope="col">TOTAL</th>
            </tr>
        </table>
        <table class="table table-sm table-bottom table-responsive-sm">
                <tr>
                    <td colspan="3" class="no-borders">
                        <asp:Label runat="server" ID="lblTotalLetras"></asp:Label></td>
                    <td>TOTAL</td>
                    <td>
                        <asp:Label runat="server"  ID="lblGranTotal"></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="5">
                        <br>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">Observaciones</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label runat="server" ID="lblTituloFirmaElectronica"></asp:Label>
                        <asp:Label runat="server" ID="lblFirmaElectronica"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:Label runat="server" ID="lblTituloGFACE"></asp:Label>
                        <br>
                        <asp:Label runat="server" ID="lblEmpresaGFACE"></asp:Label>
                        <br>
                        <asp:Label runat="server" ID="lblNitGFACE"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:Label runat="server" ID="lblLeyendaFactura"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">Comentario:
                        
                        <br />*SUJETO A PAGOS TRIMESTRALES<br />*AGENTE DE RETENCION DE IVA
                    </td>
                </tr>
           
        </table>
      </span>
    </div>
</asp:Content>
