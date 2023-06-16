<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HolaMundoASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<!-- se incorpora boostrap-->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- componente html-->
            <h1 class="text-success" runat="server" ID="mensajeH1">Hola mundo ASP.net </h1>
        </div>
        <div>
            <Label for="nombreTXT">Nombre</Label>
            <asp:TextBox runat="server" ID="nombreTXT" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <!-- componente asp.net
                se usa boostrap con CssClass y se introduce una clase de boostrap-->
            <asp:Button runat="server" ID="saludarBtn" OnClick="saludarBtn_Click" CssClass="btn btn-primary" Text="Saludame" />
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>
</body>
</html>
