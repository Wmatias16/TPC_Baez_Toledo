<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GestionCanchas.aspx.cs" Inherits="TPC_Baez_Toledo.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <a href="AgregarCancha.aspx"  style="float:left">agregar</a>
    <div class="container" style="margin-top: 25px;">
        <caption>Lista de Canchas</caption>
        <table class="table caption-top">
        <thead>
            <tr>
                <th scope="col">Id</th>
                <th scope="col">Nombre</th>
                <th scope="col">Precio</th>
                <th scope="col">TipoCancha</th>
                <th scope="col">Descripcion</th>
            </tr>
        </thead>

        <tbody>
            <asp:Repeater ID="Repetidor" runat="server">
                 <ItemTemplate>
                <tr>
                    <th scope="row"><%#Eval("Id")%></th>
                    <td>
                        <asp:TextBox ID="TxtNombre" runat="server" Text='<%#Eval("Nombre")%>'  ></asp:TextBox>
                    </td>
                    <td><asp:TextBox ID="TxtPrecio" runat="server" Text='<%#Eval("Precio")%>'  ></asp:TextBox></td>
                    <td><%#Eval("TipoCancha.Nombre") %></td> 
                    <td><asp:TextBox ID="TxtDescripcion" runat="server" Text='<%#Eval("Descripcion")%>'  ></asp:TextBox></td>                  
                    <td>
                        <a href="AgregarCancha.aspx?id=<%#Eval("Id")%>"  style="float:left">Editar</a>
                    </td>
                    <td>
                      <asp:Button ID="Eliminar" OnClick="BtnEliminar" CommandArgument='<%#Eval("Id")%>' runat="server" Text="Eliminar" />       
                    </td>
                </tr>
                  </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>

    </div>

</asp:Content>
