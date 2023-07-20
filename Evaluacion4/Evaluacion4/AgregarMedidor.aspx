<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarMedidor.aspx.cs" Inherits="Evaluacion4.AgregarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Ingresar Medidor</h3>
                </div>
                
                    <div class="form-group">
                        <label for="tipolbl">Tipo</label>
                        <asp:RadioButtonList ID="tipoRbl" runat="server" >
                            <asp:ListItem Text="Rural" Selected="True" Value="Rural"></asp:ListItem>
                            <asp:ListItem Text="Urbano" Value="Urbano"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    
                    <asp:Button runat="server" CssClass="btn btn-primary" ID="ingresaBtn" Text="Ingresar" OnClick="ingresaBtn_Click" />

                </div>
            

        </div>
    </div>
</asp:Content>
