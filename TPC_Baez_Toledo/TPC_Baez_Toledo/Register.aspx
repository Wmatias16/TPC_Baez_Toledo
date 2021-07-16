<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TPC_Baez_Toledo.Register" %>

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
                <a class="nav-link" href="Login.aspx">Iniciar sesion</a>
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
                    <img src="./Img/2.svg" style="width: 100%" />
                </div>
                <div class="col-sm-5">
                    <h1 class="text-center">Registrarme</h1>
                    <div class="form-row">
                        <div class="form-group col-md-6">
                            <label for="inputEmail4">Email</label>
                            <asp:TextBox ID="txtEmail" CssClass="form-control" TextMode="Email" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                            ControlToValidate="txtEmail"
                            ErrorMessage="Email es requerido"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="inputPassword4">Contraseña</label>
                            <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                            ControlToValidate="txtPassword"
                            ErrorMessage="Contraseña es requerido"
                            ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="inputAddress">Confirmar Contraseña</label>
                        <asp:TextBox ID="TxtConfirmarContra" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ControlToValidate="TxtConfirmarContra"
                            ErrorMessage="Confirmar contraseña es requerido"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="inputAddress">Nombre</label>
                        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ControlToValidate="txtNombre"
                            ErrorMessage="Nombre es requerido"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="inputAddress2">Apellido</label>
                        <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                            ControlToValidate="txtApellido"
                            ErrorMessage="Apellido es requerido"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="inputAddress2">Telefono</label>
                        <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                            ControlToValidate="txtTelefono"
                            ErrorMessage="El numero de telefono es requerido"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </div>
                    <asp:Button ID="Registrar" OnClick="btnRegistrar_Click" class="btn btn-primary" runat="server" Text="Registrarme" />

                </div>
            </div>
        </div>
    </form>
</body>
</html>
