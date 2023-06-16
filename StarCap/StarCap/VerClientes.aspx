﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerClientes.aspx.cs" Inherits="StarCap.VerClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

    <div class="row">
        <div class="col-lg-6 mx-auto" >
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver clientes</h3>
                </div>
                <div class="card-body">
                    <asp:GridView CssClass="table table-hover table-borderer" runat="server"
                        AutoGenerateColumns="false" ID="grillaCliente" >
                       <Columns>
                           <asp:BoundField   DataField="Rut" HeaderText="Rut del cliente" />
                           <asp:BoundField   DataField="Nombre" HeaderText="Nombre del cliente" />
                           <asp:BoundField DataField="NivelTxt" HeaderText="Nivel Cliente" />
                           <asp:BoundField DataField="BebidaFavorita.Nombre" HeaderText="Favorita" />
                       </Columns>


                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>