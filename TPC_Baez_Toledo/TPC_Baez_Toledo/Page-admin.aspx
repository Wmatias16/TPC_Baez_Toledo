<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Page-admin.aspx.cs" Inherits="TPC_Baez_Toledo.Page_admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <nav class="navbar navbar-dark sticky-top bg-dark flex-md-nowrap p-0 shadow">
        <a class="navbar-brand col-md-3 col-lg-2 mr-0 px-3" href="#">Gestion de alquileres</a>
        <button class="navbar-toggler position-absolute d-md-none collapsed" type="button" data-toggle="collapse" data-target="#sidebarMenu" aria-controls="sidebarMenu" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <ul class="navbar-nav px-3">
            <li class="nav-item text-nowrap">
                <a class="nav-link" href="#">Cerrar sesion</a>
            </li>
        </ul>
    </nav>

    <div class="container-fluid">
        <div class="row">
            <nav id="sidebarMenu" class="col-md-3 col-lg-2 d-md-block bg-light sidebar collapse">
                <div class="sidebar-sticky pt-3">
                    <ul class="nav flex-column">
                        <li class="nav-item">
                            <a class="nav-link active" href="#">
                                <span data-feather="home"></span>
                                Inicio <span class="sr-only"></span>
                            </a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">
                                <span data-feather="file"></span>
                                Dashboard
                            </a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">
                                <span data-feather="file"></span>
                                Canchas
                            </a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">
                                <span data-feather="shopping-cart"></span>
                                Alquileres
                            </a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">
                                <span data-feather="users"></span>
                                Usuarios
                            </a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">
                                <span data-feather="bar-chart-2"></span>
                                Reportes
                            </a>
                        </li>
            </nav>

            <main role="main" class="col-md-9 ml-sm-auto col-lg-10 px-md-4">
                <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom">
                    <h1 class="h2">Dashboard</h1>
                    <div class="btn-toolbar mb-2 mb-md-0">
                        <div class="btn-group mr-2">
                            <button type="button" class="btn btn-sm btn-outline-secondary">Export</button>
                        </div>
                    </div>
                </div>

                <h2>Proximos turnos</h2>
                <div class="table-responsive">
                    <table class="table table-striped table-sm">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Cancha</th>
                                <th>Nombre usuario</th>
                                <th>Horas</th>
                                <th>Total</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>Futsal</td>
                                <td>Lucas Baez</td>
                                <td>1hr</td>
                                <td>2000$</td>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td>Cancha 1</td>
                                <td>Matias Toledo</td>
                                <td>2hr</td>
                                <td>4000$</td>
                            </tr>
                            <tr>
                                <td>3</td>
                                <td>Cancha 1</td>
                                <td>Matias Toledo</td>
                                <td>2hr</td>
                                <td>Pago</td>
                            </tr>
                            <tr>
                                <td>4</td>
                                <td>Cancha 1</td>
                                <td>Usuario Prueba</td>
                                <td>2hr</td>
                                <td>Pago</td>
                            </tr>
                            <tr>
                                <td>5</td>
                                <td>Cancha 2</td>
                                <td>Matias Toledo</td>
                                <td>1hr</td>
                                <td>2000$</td>
                            </tr>
                            <tr>
                                <td>6</td>
                                <td>Cancha 4</td>
                                <td>Usuario prueba</td>
                                <td>3hr</td>
                                <td>6000$</td>
                            </tr>
                            <tr>
                                <td>7</td>
                                <td>Cancha 1</td>
                                <td>Matias Toledo</td>
                                <td>2hr</td>
                                <td>4000$</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </main>
        </div>
    </div>


</asp:Content>
