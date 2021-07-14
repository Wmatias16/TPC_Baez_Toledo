<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alquilar.aspx.cs" Inherits="TPC_Baez_Toledo.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="card mb-3" style="width: 100%;">
        <div class="row no-gutters">
            <div class="col-md-4">
                <img src="<%=cancha.UrlImagen %>" alt="..." style="width: 100%; height: 100%; object-fit: cover">
            </div>
            <div class="col-md-8">
                <div class="card-body">
                    <h5 class="card-title"><%=cancha.Nombre %></h5>
                    <h5 class="card-title"><%=cancha.Precio %></h5>
                    <p class="card-text"><%=cancha.Descripcion %></p>
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <label class="input-group-text" for="inputGroupSelect01">Dia disponibles</label>
                        </div>
                        <asp:DropDownList CssClass="custom-select" runat="server" ID="listDias"
                            AutoPostBack="true">                           
                            
                        </asp:DropDownList>
                    </div>
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <label class="input-group-text" for="inputGroupSelect01">Horarios disponibles</label>
                        </div>
                        <asp:DropDownList CssClass="custom-select" runat="server" ID="listHorarios"
                            AutoPostBack="false">                           
                            
                        </asp:DropDownList>
                    </div>
                         <asp:Button ID="btnAlquilar" CssClass="btn btn-success btn-lg btn-block" runat="server" OnClick="btnAlquilar_Click" Text="Alquilar cancha"/>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
