<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarCancha.aspx.cs" Inherits="TPC_Baez_Toledo.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   
        <div class="container" style="margin-top: 150px;">

        <div class="row">
            <div class="col-sm-7" style="align-self: center;">
                <img src="./Img/Cancha.jpg" style="width: 100%" />
            </div>
            <div class="col-sm-5">
                <%if (Request.QueryString["id"] == null)
                    { %>
                    <h1 class="text-center">Agregar Cancha</h1>
                <%}
                  else
                  {%>
                      <h1 class="text-center">Editar Cancha</h1>  
                <% }%>
                
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="InputNombre">Nombre</label>
                        <asp:TextBox ID="TxtNombre" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>     
                </div>
                <div class="form-group">
                        <label for="InputPrecio">Precio</label>
                        <asp:TextBox ID="TxtPrecio" CssClass="form-control" runat="server" ></asp:TextBox>
                    </div>
                <div class="form-group">
                    <label for="InputTipoCamcha">Tipo de Cancha</label>
                    <asp:ListBox ID="ListTipoCancha" runat="server"></asp:ListBox>
                </div>
                <div class="form-group">
                    <label for="inputDescripcion">Descripcion</label>
                    <asp:TextBox ID="TxtDescripcion" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="inputUrlImagen">Url de la imagen</label>
                    <asp:TextBox ID="TxtUrlImagen" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

                <%if (Request.QueryString["id"] == null)
                    { %>
                    <asp:Button ID="Button1" OnClick="BtnAgregar" class="btn btn-primary" runat="server" Text="Agregar Cancha" />
                <%}
                  else
                  {%>
                      <asp:Button ID="Editar" OnClick="BtnEditar" class="btn btn-primary" runat="server" Text="Editar Cancha" />
                <% }%>
                
            </div>
        </div>
    </div>

</asp:Content>
