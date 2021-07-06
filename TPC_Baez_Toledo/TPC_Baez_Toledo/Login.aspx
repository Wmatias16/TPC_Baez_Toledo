<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPC_Baez_Toledo.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <%if (error == true) { %>
            <h1>EXISTE</h1>        
        <% } %>

    <div class="container" style="margin-top: 150px;">
        <div class="row">
            <div class="col-sm-7" style="align-self: center;">
                <img src="./Img/1.svg" style="width:100%" />
            </div>
            <div class="col-sm-5">
                <h1 class="text-center">Iniciar sesion</h1>

                <div class="mb-3">
                    <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
                    <div id="emailHelp" class="form-text">Porfavor ingrese su email si esta registrado</div>
                </div>
                <div class="mb-3">
                    <label for="exampleInputPassword1" class="form-label">Contraseña</label>
                    <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <asp:Button ID="Button1" runat="server" Text="Iniciar sesion" OnClick="Validar" />
            </div>
        </div>
    </div>

</asp:Content>
