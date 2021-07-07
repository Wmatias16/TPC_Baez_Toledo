<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Canchas.aspx.cs" Inherits="TPC_Baez_Toledo.Canchas" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="margin-top: 25px;">
        <div class="row">
            <div class="col-8">
                <div class="input-group flex-nowrap">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="addon-wrapping">Filtrar</span>
                    </div>
                    <asp:TextBox ID="TextBoxFiltrar" runat="server" placeholder="buscar"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <%foreach (Dominio.Cancha item in canchas)
                {%>

            <div class="card mb-3" style="max-width: 1500px;">
                <div class="row no-gutters">
                    <div class="col-md-4">
                        <img src="<% = item.UrlImagen %>" alt="..." style="width: 100%">
                    </div>
                    <div class="col-md-8">
                        <div class="card-body">
                            <h5 class="card-title"><% = item.Nombre %></h5>
                            <p class="card-text"><% = item.Descripcion %></p>
                            <p class="card-text"><small class="text-muted">$<%= item.Precio %> </small></p>
                             
                            <a href="Alquilar.aspx?id=<% = item.Id %>" class="btn btn-primary btn-lg btn-block">Alquilar</a>
                        </div>
                    </div>
                </div>
            </div>

            <%} %>
        </div>
    </div>




</asp:Content>
