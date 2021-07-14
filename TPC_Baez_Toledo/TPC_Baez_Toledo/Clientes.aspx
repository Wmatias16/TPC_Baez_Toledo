<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="TPC_Baez_Toledo.Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   

    <div class="container-fluid" style="margin-top: 25px;">
        <caption style="margin-top: 25px;"><h3>Clientes</h3></caption>
        <table class="table caption-top">        
        <thead>
            <tr>
                <th scope="col">Legajo</th>
                <th scope="col">Nombre</th>
                <th scope="col">Apellido</th>
                <th scope="col">Email</th>
                <th scope="col">Telefono</th>
            </tr>
        </thead>
          
        <tbody>

            <%foreach(Dominio.Usuario item in clientes)
              {%>        
                <tr>
                    <th scope="row"><%=item.Legajo %></th>
                    <td><%=item.Nombre %></td>
                    <td><%=item.Apellidos %></td>
                    <td><%=item.Email %></td>
                    <td><%=item.Telefono %></td>
                </tr>
            <%} %>
        </tbody>
    </table>
    
    </div>

     

</asp:Content>
