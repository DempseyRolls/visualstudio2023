<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="Evaluacion3.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

    <div class="row">
        <div class="col-lg-6 mx-auto" >
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                    <asp:GridView CssClass="table table-hover table-borderer" runat="server"
                        OnRowCommand="grillaMedidor_RowCommand"
                        AutoGenerateColumns="false" ID="grillaMedidor">

                        <Columns>
                            <asp:BoundField DataField="NumeroSerie" HeaderText="Numero de serie" />
                            <asp:BoundField DataField="TipoTxt" HeaderText="Tipo de Medidor" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
