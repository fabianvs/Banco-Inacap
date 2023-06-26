<%@ Page Title="" Language="C#" MasterPageFile="~/SitioEjecutivo.Master" AutoEventWireup="true" CodeBehind="Crear_Clientes.aspx.cs" Inherits="BancoWeb.Crear_Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="card mt-3 shadow-lg col-6 offset-3">
        <div class="card-header text-white" style="background: #3A4F50">
            <h3 class="text-center">Crear Cliente</h3>
        </div>
        <form runat="server">
            <div class="card-body row">
                <div class="mb-3 col-6">
                    <asp:Label ID="rutcLbl" runat="server" Text="Rut Cliente: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="rutcTxt" runat="server" CssClass="form-control"></asp:TextBox>
                    <div id="rutc" class="form-text">Ingresa el rut del cliente sin puntos</div>
                </div>
                <div class="mb-3 col-6">
                    <asp:Label ID="nombrecLbl" runat="server" Text="Nombre Cliente: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="nombrecTxt" runat="server" CssClass="form-control"></asp:TextBox>
                    <div id="nombrec" class="form-text">Ingresa el nombre del cliente</div>
                </div>
                <div class="mb-3 col-6">
                    <asp:Label ID="paternocLbl" runat="server" Text="Apellido Paterno: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="paternocTxt" runat="server" CssClass="form-control"></asp:TextBox>
                    <div id="paternoc" class="form-text">Ingresa el apellido paterno del cliente</div>
                </div>
                <div class="mb-3 col-6">
                    <asp:Label ID="maternocLbl" runat="server" Text="Apellido Materno: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="maternocTxt" runat="server" CssClass="form-control"></asp:TextBox>
                    <div id="maternoc" class="form-text">Ingresa apellido materno del cliente</div>
                </div>
                <div class="mb-3 col-6">
                    <asp:Label ID="passcLbl" runat="server" Text="Clave: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="passcTxt" runat="server" CssClass="form-control"></asp:TextBox>
                    <div id="passc" class="form-text">Escribe la clave temporal (Primeros seís dígitos del Rut del cliente)</div>
                </div>
                <div class="mb-3 col-6">
                    <asp:Label ID="ncuentaLbl" runat="server" Text="Número de cuenta" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="ncuentaTxt" runat="server" CssClass="form-control"></asp:TextBox>
                    <div id="ncuenta" class="form-text">Ingrese un número de cuenta para el cliente:</div>
                </div>
                 <div class="mb-3 col-6">
                    <asp:Label ID="tipoLbl" runat="server" Text="Tipo de cuenta:" CssClass="form-label"></asp:Label>
                    <asp:RadioButtonList ID="tipoTxt" runat="server" CssClass="form-check">
                    <asp:ListItem Value="e1" Text="Crédito" Selected="True"></asp:ListItem>
                    <asp:ListItem Value="e2" Text="Débito"></asp:ListItem></asp:RadioButtonList>

                 </div>
                <div class="col-12 text-center">
                    <asp:Button id="Button1" runat="server" Text="Crear Cliente" CssClass="btn btn-dark" OnClick="Button1_Click"/>
                </div>
            
            </div>
         </form>
    </div>
</asp:Content>
