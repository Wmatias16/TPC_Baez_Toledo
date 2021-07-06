<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Canchas.aspx.cs" Inherits="TPC_Baez_Toledo.Canchas" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="margin-top: 25px;">
        <div class="row">
            <div class="col-8">
                <div class="input-group flex-nowrap">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="addon-wrapping">Filtrar</span>
                    </div>
                     <asp:TextBox ID="TextBoxFiltrar" runat="server"  placeholder="buscar" ></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <%foreach (Dominio.Cancha item in canchas)
                {%>
            <div class="col">
                <div class="card" style="width: 18rem;">
                    <a href="Detalle.aspx?id=<% = item.Id %>">
                        <img src="<% = item.UrlImagen %>" class="card-img-top" style="width: 100%" alt="...">
                    </a>

                    <div class="card-body">
                        <h5 class="card-title text-center"><% = item.Nombre %></h5>
                        <p class="card-text text-center" style="font-size: 24px"><% = item.Precio %>$</p>

                        <a href="Detalle.aspx?id=<% = item.Id %>" class="btn btn-primary btn-lg btn-block">Alquilar</a>
                        <button type="button" class="btn btn-success" data-toggle="modal" data-target="#exampleModal">
                            ALQUILAR
                        </button>
                    </div>
                </div>
            </div>
            <%} %>
        </div>
    </div>


     <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">Alquiler</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
            



          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-danger" data-dismiss="modal">Salir</button>
            <button type="button" class="btn btn-success">Alquilar</button>
          </div>
        </div>
      </div>
    </div>


</asp:Content>
