<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarLectura.aspx.cs" Inherits="Evaluacion3.IngresarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Ingresar Lectura</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="MedidorDbl">Medidor</label>
                        <asp:DropDownList ID="MedidorDbl" runat="server">
                            <asp:ListItem Text="seleccione una opcion"></asp:ListItem>

                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="fechaTxt">Fecha</label>
                        <asp:Calendar ID="fechaTxt" CssClass="form-control" runat="server"></asp:Calendar>
                        
                    </div>
                    <div class="form-group">
                    <label for="horaTxt">Hora</label> 
                        <asp:TextBox ID="horaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <label for="minutosTxt">Minutos</label>
                        <asp:TextBox ID="minutosTxt" CssClass="form-control" runat="server"></asp:TextBox>

                    </div>
                    <div class="form-group">
                        <label for="valorConsumoTxt">Valor de consumo</label> 
                        <asp:TextBox ID="valorConsumoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click" Text="Agregar" CssClass="btn btn-primary btn-lg" />
                        
                    </div>

                </div>
            </div>

        </div>
    </div>

</asp:Content>
