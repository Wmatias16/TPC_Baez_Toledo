<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MisAlquileres.aspx.cs" Inherits="TPC_Baez_Toledo.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid" style="margin-top: 25px;">
        <caption style="margin-top: 25px;">
            <h3>Mis Alquileres</h3>
        </caption>
        <table class="table caption-top">
            <thead>
                <tr>
                    <th scope="col">Nombre</th>
                    <th scope="col">Horas</th>
                    <th scope="col">Hora Alquilada</th>
                    <th scope="col">Fecha</th>
                    <th scope="col">Precio</th>
                    <th scope="col">Estado</th>
                </tr>
            </thead>

            <tbody>

                <%foreach (Dominio.Alquiler item in alquileres)
                    {%>
                <tr>
                    <th scope="row"><%=item.Cancha.Nombre %></th>
                    <td><%=item.Horas %></td>
                    <td><%=item.HoraAlquilada %></td>
                    <td><%=item.Fecha %></td>
                    <td><%=item.Costo %></td>

                    <%if (item.Fecha >= DateTime.Today)
                       {%>
                       <td>Pendiente</td>
                     <%}
                      else{%>   
                       <td>Finalizado</td>
                         <% }%>
                           
                </tr>
                <%} %>
            </tbody>
        </table>

    </div>


</asp:Content>


