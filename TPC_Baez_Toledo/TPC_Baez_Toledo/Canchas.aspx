<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Canchas.aspx.cs" Inherits="TPC_Baez_Toledo.Canchas" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="margin-top: 25px;">
        <div class="row">
            <%foreach (Dominio.Cancha item in canchas)
                {%>

            <div class="card mb-3 rounded border border-light" style="width: 100%;">
                <div class="row no-gutters">
                    <div class="col-md-4">
                        <img src="<% = item.UrlImagen %>" alt="..." style="width: 100%;height:100%;object-fit:none;">
                    </div>
                    <div class="col-md-8">
                        <div class="card-body">
                            <h5 class="card-title"><% = item.Nombre %></h5>
                            <h5 class="card-title"><% = item.Precio %>$</h5>
                            <p class="card-text"><% = item.Descripcion %></p>
                             
                            <a href="Alquilar.aspx?id=<% = item.Id %>" class="btn btn-primary btn-lg btn-block">Alquilar</a>
                        </div>
                    </div>
                </div>
            </div>

            <%} %>
        </div>
    </div>




</asp:Content>
