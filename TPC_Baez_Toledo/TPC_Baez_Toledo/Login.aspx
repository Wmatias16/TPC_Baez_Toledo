<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPC_Baez_Toledo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">

    <title></title>
</head>
<body>

    <nav class="navbar navbar-dark sticky-top bg-dark flex-md-nowrap p-0 shadow">
        <a class="navbar-brand col-md-3 col-lg-2 mr-0 px-3" href="#">Gestion de alquileres</a>
        <button class="navbar-toggler position-absolute d-md-none collapsed" type="button" data-toggle="collapse" data-target="#sidebarMenu" aria-controls="sidebarMenu" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <ul class="navbar-nav px-3">
            <li class="nav-item text-nowrap">
                <a class="nav-link" href="Register.aspx">Registrarse</a>
            </li>
        </ul>
    </nav>
      <%if (Session["Error"] != null)
        { %>
            <div class="alert alert-danger" role="alert">
                 Posible error: <%=error %>
            </div>
    <%} %>

    <form id="form1" runat="server">
        <div class="container" style="margin-top: 150px;">
            <div class="row">
                <div class="col-sm-7" style="align-self: center;">
                    <img src="./Img/1.svg" style="width: 100%" />
                </div>
                <div class="col-sm-5">
                    <h1 class="text-center">Iniciar sesion</h1>

                    <div class="mb-3">
                        <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" TextMode="Email"></asp:TextBox>
                        <div id="emailHelp" class="form-text">Porfavor ingrese su email si esta registrado</div>
                    </div>
                    <div class="mb-3">
                        <label for="exampleInputPassword1" class="form-label">Contraseña</label>
                        <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                    </div>
                    <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Iniciar sesion" OnClick="Validar" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
