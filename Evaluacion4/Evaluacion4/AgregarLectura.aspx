<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarLectura.aspx.cs" Inherits="Evaluacion4.AgregarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Ingresar Lectura</h3>
                </div>
                <div class="card-body">
                    
                    <div class="form-group">
                        <label for="consumoTxt">Consumo</label>
                        <asp:TextBox ID="consumoTXT"  CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    
                    <div class="form-group">
                        <label for="medidorDDL">Medidor</label>
                        <asp:DropDownList ID="medidorDDL" runat="server"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="usuarioDDL">Usuario</label>
                        <asp:DropDownList ID="usuarioDDL" runat="server"></asp:DropDownList>
                    </div>
                    <asp:Button runat="server" CssClass="btn btn-primary" ID="ingresaBtn" Text="Ingresar" OnClick="ingresaBtn_Click" />

                </div>
            </div>

        </div>
    </div>
    
</asp:Content>
