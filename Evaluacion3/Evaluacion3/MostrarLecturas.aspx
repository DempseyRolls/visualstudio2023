<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarLecturas.aspx.cs" Inherits="Evaluacion3.MostrarLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

    <div class="row">
        <div class="col-lg-6 mx-auto" >
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Lecturas</h3>
                </div>
                <div class="card-body">
                    <asp:GridView CssClass="table table-hover table-borderer" runat="server" AutoGenerateColumns="false" ID="grillaLectura">

                        <Columns>
                            <asp:BoundField DataField="MedidorLectura.NumeroSerie" HeaderText="Numero de serie" />
                            <asp:BoundField DataField="MedidorLectura.TipoTxt" HeaderText="Tipo Medidor" />
                            <asp:BoundField DataField="FechaLectura" HeaderText="Fecha" />
                            <asp:BoundField DataField="HoraLectura" HeaderText="Hora" />
                            <asp:BoundField DataField="ValorConsumo" HeaderText="Valor de Consumo" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
