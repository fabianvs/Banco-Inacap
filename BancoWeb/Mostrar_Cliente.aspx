<%@ Page Title="" Language="C#" MasterPageFile="~/SitioEjecutivo.Master" AutoEventWireup="true" CodeBehind="Mostrar_Cliente.aspx.cs" Inherits="BancoWeb.Mostrar_Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <form runat="server">
        <asp:GridView OnRowCommand="grillaClientes_RowCommand" ID="grillaClientes" runat="server" CssClass="table table-hover" 
            AutoGenerateColumns="false" EmptyDataText="No hay Clientes" ShowHeaderWhenEmpty="true">
            <Columns>
                <asp:BoundField HeaderText="Run Cliente" DataField="Run1" />
                <asp:BoundField HeaderText="Nombre Cliente" DataField="Nombre1" />
                <asp:BoundField HeaderText="Apellido Paterno" DataField="Paterno1" />
                <asp:BoundField HeaderText="Apellido Materno" DataField="Materno1" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button CommandName="eliminar" CommandArgument='<%# Eval("Run1") %>' 
                                runat="server" CssClass="btn btn-danger" Text="Eliminar"
                            />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
     </form>
</asp:Content>
