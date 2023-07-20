<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarMedidor.aspx.cs" Inherits="Evaluacion4.MostrarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <asp:DropDownList ID="tipoDDL" runat="server" AutoPostBack="true" OnSelectedIndexChanged="tipoDDL_SelectedIndexChanged">
                <asp:ListItem Text="Rural" Selected="True" Value="Rural"></asp:ListItem>
                <asp:ListItem Text="Urbano" Value="Urbano"></asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="row mt-5">
        <asp:GridView ID="grillaMedidor" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true"
            CssClass="table table-hover table-bordered"
            EmptyDataText="No hay Registros" runat="server">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="Id" />
                <asp:BoundField HeaderText="Tipo" DataField="Tipo" />


            </Columns>

        </asp:GridView>
    </div>
</asp:Content>
