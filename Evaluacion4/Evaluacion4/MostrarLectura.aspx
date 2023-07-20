<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarLectura.aspx.cs" Inherits="Evaluacion4.MostrarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        
    </div>
    <div class="row mt-5">
        <asp:GridView ID="grillaLectura" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true"
            CssClass="table table-hover table-bordered"
            EmptyDataText="No hay Registros" runat="server">
            <Columns>
                <asp:BoundField HeaderText="Consumo" DataField="Consumo" />
                <asp:BoundField HeaderText="IdMedidor" DataField="IdMedidor" />
                <asp:BoundField HeaderText="IdUsuario" DataField="IdUsuario" />
                


            </Columns>

        </asp:GridView>
    </div>
</asp:Content>
