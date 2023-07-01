<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarMedidor.aspx.cs" Inherits="Evaluacion3.IngresarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Ingresar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="numeroMedidorTxt">Numero Medidor</label>
                        <asp:TextBox ID="numeroMedidorTxt" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="tipoRbl">Tipo Medidor</label>
                        <asp:RadioButtonList ID="tipoRbl" runat="server">
                            <asp:ListItem Text="Rural" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Urbano" Value="2"></asp:ListItem>

                        </asp:RadioButtonList>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click" Text="Agregar" CssClass="btn btn-primary btn-lg" />
                        
                    </div>

                </div>
            </div>

        </div>
    </div>






</asp:Content>
