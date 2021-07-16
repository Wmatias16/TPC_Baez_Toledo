<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Page-admin.aspx.cs" Inherits="TPC_Baez_Toledo.Page_admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div id="content" class="container-fluid p-5">
        <section class="py-3">
            <!-- Highlights -->
            <div class="row">
                <div class="col-xl-3 col-lg-6">
                    <div class="card mb-5 shadow-sm border-0 shadow-hover">
                        <div class="card-body d-flex">
                            <div>
                                <div class="circle rounded-circle bg-primary align-self-center d-flex mr-3">
                                    <i class="icon ion-md-trending-up text-primary align-self-center mx-auto lead"></i>
                                </div>
                            </div>
                            <div class="align-self-center">
                                <h5 class="mb-0">$56,150</h5>
                                <small class="text-muted">Ganancias totales</small>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xl-3 col-lg-6">
                    <div class="card mb-5 shadow-sm border-0 shadow-hover">
                        <div class="card-body d-flex">
                            <div>
                                <div class="circle rounded-circle bg-primary align-self-center d-flex mr-3">
                                    <i class="icon ion-md-stats text-primary align-self-center mx-auto lead"></i>
                                </div>
                            </div>
                            <div class="align-self-center">
                                <h5 class="mb-0">$8,450</h5>
                                <small class="text-muted">Ganancias en el dia</small>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xl-3 col-lg-6">
                    <div class="card mb-5 shadow-sm border-0 shadow-hover">
                        <div class="card-body d-flex">
                            <div>
                                <div class="circle rounded-circle bg-primary align-self-center d-flex mr-3">
                                    <i class="icon ion-md-people text-primary align-self-center mx-auto lead"></i>
                                </div>
                            </div>
                            <div class="align-self-center">
                                <h5 class="mb-0">$22,150</h5>
                                <small class="text-muted">Ganancias en el mes</small>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xl-3 col-lg-6">
                    <div class="card mb-5 shadow-sm border-0 shadow-hover">
                        <div class="card-body d-flex">
                            <div>
                                <div class="circle rounded-circle bg-primary align-self-center d-flex mr-3">
                                    <i class="icon ion-md-cash text-primary align-self-center mx-auto lead"></i>
                                </div>
                            </div>
                            <div class="align-self-center">
                                <h5 class="mb-0">23</h5>
                                <small class="text-muted">Pendienres de aprobacion</small>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Fin highlights -->
             <nav>
                    <div class="nav nav-tabs nav justify-content-center" id="nav-tab" role="tablist">
                        <a class="nav-link active" id="nav-home-tab" data-toggle="tab" href="#nav-home" role="tab" aria-controls="nav-home" aria-selected="true" style="width:50%;text-align:center;">Proximos turnos</a>
                        <a class="nav-link" id="nav-profile-tab" data-toggle="tab" href="#nav-profile" role="tab" aria-controls="nav-profile" aria-selected="false"style="width:50%;text-align:center;" >Pendientes de aprobacion</a>
                    </div>
                </nav>
            <div class="container-fluid">
               
                <div class="tab-content" id="nav-tabContent">
                    <div class="tab-pane fade show active" id="nav-home" role="tabpanel" aria-labelledby="nav-home-tab">
                        <caption style="margin-top: 25px;">
                            <h3>Proximos turnos</h3>
                        </caption>
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

                                <%foreach (Dominio.Usuario item in clientes)
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
                    <div class="tab-pane fade" id="nav-profile" role="tabpanel" aria-labelledby="nav-profile-tab">

                        <h1>Hola mundo</h1>
                    </div>

                </div>





            </div>
    </div>



</asp:Content>
