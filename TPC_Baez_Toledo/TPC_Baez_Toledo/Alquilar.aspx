<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alquilar.aspx.cs" Inherits="TPC_Baez_Toledo.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="card mb-3">
        <img src="<%=cancha.UrlImagen %> " style="width:100%" class="card-img-top" alt="...">
        <div class="card-body">
            <h5 class="card-title"><%=cancha.Nombre %></h5>
            <p class="card-text"><%=cancha.Descripcion %></p>
            <p class="card-text"><small class="text-muted"><%= cancha.Precio %></small></p>

            <div class="dropdown">
                        <button class="btn btn-secondary dropdown-toggle " style="margin-top:10px" type="button" id="dropdownMenuButtonXdia" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            Dia
                        </button>
                        <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                           
                            <% foreach(int Dia in dias)
                                {%>                          
                                <a class="dropdown-item" href="#"><%=Dia %></a>
                            <%} %>
                            
                        </div>
                    </div>

             <div class="dropdown">
                        <button class="btn btn-secondary dropdown-toggle " style="margin-top:10px" type="button" id="dropdownMenuButtonXdia" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            hora
                        </button>
                        <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                            <a class="dropdown-item" href="#">13:00</a>
                        </div>
                    </div>

        </div>
    </div>
   

</asp:Content>
