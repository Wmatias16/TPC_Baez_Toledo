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
                                    <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-bank2 icon ion-md-trending-up text-primary align-self-center mx-auto lead" viewBox="0 0 16 16">
                                        <path d="M8.277.084a.5.5 0 0 0-.554 0l-7.5 5A.5.5 0 0 0 .5 6h1.875v7H1.5a.5.5 0 0 0 0 1h13a.5.5 0 1 0 0-1h-.875V6H15.5a.5.5 0 0 0 .277-.916l-7.5-5zM12.375 6v7h-1.25V6h1.25zm-2.5 0v7h-1.25V6h1.25zm-2.5 0v7h-1.25V6h1.25zm-2.5 0v7h-1.25V6h1.25zM8 4a1 1 0 1 1 0-2 1 1 0 0 1 0 2zM.5 15a.5.5 0 0 0 0 1h15a.5.5 0 1 0 0-1H.5z" />
                                    </svg>

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
                                    <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-currency-dollar icon ion-md-trending-up text-primary align-self-center mx-auto lead" viewBox="0 0 16 16">
                                        <path d="M4 10.781c.148 1.667 1.513 2.85 3.591 3.003V15h1.043v-1.216c2.27-.179 3.678-1.438 3.678-3.3 0-1.59-.947-2.51-2.956-3.028l-.722-.187V3.467c1.122.11 1.879.714 2.07 1.616h1.47c-.166-1.6-1.54-2.748-3.54-2.875V1H7.591v1.233c-1.939.23-3.27 1.472-3.27 3.156 0 1.454.966 2.483 2.661 2.917l.61.162v4.031c-1.149-.17-1.94-.8-2.131-1.718H4zm3.391-3.836c-1.043-.263-1.6-.825-1.6-1.616 0-.944.704-1.641 1.8-1.828v3.495l-.2-.05zm1.591 1.872c1.287.323 1.852.859 1.852 1.769 0 1.097-.826 1.828-2.2 1.939V8.73l.348.086z" />
                                    </svg>
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

                                    <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-piggy-bank-fill icon ion-md-people text-primary align-self-center mx-auto lead" viewBox="0 0 16 16">
                                        <path fill-rule="evenodd" d="M7.964 1.527c-2.977 0-5.571 1.704-6.32 4.125h-.55A1 1 0 0 0 .11 6.824l.254 1.46a1.5 1.5 0 0 0 1.478 1.243h.263c.3.513.688.978 1.145 1.382l-.729 2.477a.5.5 0 0 0 .48.641h2a.5.5 0 0 0 .471-.332l.482-1.351c.635.173 1.31.267 2.011.267.707 0 1.388-.095 2.028-.272l.543 1.372a.5.5 0 0 0 .465.316h2a.5.5 0 0 0 .478-.645l-.761-2.506C13.81 9.895 14.5 8.559 14.5 7.069c0-.145-.007-.29-.02-.431.261-.11.508-.266.705-.444.315.306.815.306.815-.417 0 .223-.5.223-.461-.026a.95.95 0 0 0 .09-.255.7.7 0 0 0-.202-.645.58.58 0 0 0-.707-.098.735.735 0 0 0-.375.562c-.024.243.082.48.32.654a2.112 2.112 0 0 1-.259.153c-.534-2.664-3.284-4.595-6.442-4.595zm7.173 3.876a.565.565 0 0 1-.098.21.704.704 0 0 1-.044-.025c-.146-.09-.157-.175-.152-.223a.236.236 0 0 1 .117-.173c.049-.027.08-.021.113.012a.202.202 0 0 1 .064.199zm-8.999-.65A6.613 6.613 0 0 1 7.964 4.5c.666 0 1.303.097 1.893.273a.5.5 0 1 0 .286-.958A7.601 7.601 0 0 0 7.964 3.5c-.734 0-1.441.103-2.102.292a.5.5 0 1 0 .276.962zM5 6.25a.75.75 0 1 1-1.5 0 .75.75 0 0 1 1.5 0z" />
                                    </svg>
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
                                    <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-exclamation-lg icon ion-md-cash text-primary align-self-center mx-auto lead" viewBox="0 0 16 16">
                                        <path d="M6.002 14a2 2 0 1 1 4 0 2 2 0 0 1-4 0zm.195-12.01a1.81 1.81 0 1 1 3.602 0l-.701 7.015a1.105 1.105 0 0 1-2.2 0l-.7-7.015z" />
                                    </svg>
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
                    <a class="nav-link active" id="nav-home-tab" data-toggle="tab" href="#nav-home" role="tab" aria-controls="nav-home" aria-selected="true" style="width: 50%; text-align: center;">Proximos turnos</a>
                    <a class="nav-link" id="nav-profile-tab" data-toggle="tab" href="#nav-profile" role="tab" aria-controls="nav-profile" aria-selected="false" style="width: 50%; text-align: center;">Pendientes de aprobacion</a>
                </div>
            </nav>
            <div class="container-fluid">

                <div class="tab-content" id="nav-tabContent">
                    <div class="tab-pane fade show active" id="nav-home" role="tabpanel" aria-labelledby="nav-home-tab">
                        <table class="table caption-top">
                            <thead>
                                <tr>
                                    <th scope="col">Legajo Usuario</th>
                                    <th scope="col">Nombre</th>
                                    <th scope="col">Apellido</th>
                                    <th scope="col">Nombre de la canc</th>
                                    <th scope="col">Precio</th>
                                    <th scope="col">Horas</th>
                                    <th scope="col">Hora Alquilada</th>
                                    <th scope="col">Fecha</th>
                                    <th scope="col">Estado</th>
                                </tr>
                            </thead>

                            <tbody>

                                <%foreach (Dominio.Alquiler item in AlquileresDiaHoy)
                                    {%>
                                <tr>
                                    <th scope="row"><%=item.Usuario.Legajo %></th>
                                    <td><%=item.Usuario.Nombre %></td>
                                    <td><%=item.Usuario.Apellidos %></td>
                                    <td><%=item.Cancha.Nombre %></td>
                                    <td><%=item.Costo %></td>
                                    <td><%=item.Horas %></td>
                                    <td><%=item.HoraAlquilada %></td>
                                    <td><%=item.Fecha.ToString("yyyy-MM-dd") %></td>
                                    <td><%=item.Estado.Nombre%></td>
                                </tr>
                                <%} %>
                            </tbody>
                        </table>
                    </div>
                    <div class="tab-pane fade" id="nav-profile" role="tabpanel" aria-labelledby="nav-profile-tab">
                        <table class="table caption-top">
                            <thead>
                                <tr>
                                    <th scope="col">Legajo Usuario</th>
                                    <th scope="col">Nombre</th>
                                    <th scope="col">Apellido</th>
                                    <th scope="col">Nombre de la canc</th>
                                    <th scope="col">Precio</th>
                                    <th scope="col">Horas</th>
                                    <th scope="col">Hora Alquilada</th>
                                    <th scope="col">Estado</th>
                                    <th scope="col">Accion</th>
                                </tr>
                            </thead>

                            <tbody>
                                <asp:Repeater ID="Repetidor" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <th scope="row"><%#Eval("Usuario.Legajo")%></th>
                                            <td><%#Eval("Usuario.Nombre")%></td>
                                            <td><%#Eval("Usuario.Apellidos")%>$</td>
                                            <td><%#Eval("Cancha.Nombre")%></td>
                                            <td><%#Eval("Costo")%></td>
                                            <td><%#Eval("Horas")%></td>
                                            <td><%#Eval("HoraAlquilada")%></td>
                                            <td><%#Eval("Estado.Nombre")%></td>
                                            <td>
                                                <asp:UpdatePanel runat="server">
                                                    <ContentTemplate>
                                                        <asp:LinkButton ID="btnConfirmarPago" OnClick="btnConfirmarPago_Click" CssClass="btn btn-outline-light" runat="server" OnClientClick="return confirm('Confirmar pago, ustede esta de acuerdo?');" CommandArgument='<%#Eval("Id")%>'> 
                                                             <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-check-circle-fill" viewBox="0 0 16 16" style="color:green">
                                                              <path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"/>
                                                            </svg>
                                                        </asp:LinkButton>
                                                        <asp:LinkButton ID="btnDetalle" OnClick="btnSubmit_Click" CssClass="btn btn-outline-light" CommandArgument='<%#Eval("Id")%>' runat="server">
                                                             <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-journal-text" viewBox="0 0 16 16" style="color:black;">
                                                              <path d="M5 10.5a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 0 1h-2a.5.5 0 0 1-.5-.5zm0-2a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5zm0-2a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5zm0-2a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5z"/>
                                                              <path d="M3 0h10a2 2 0 0 1 2 2v12a2 2 0 0 1-2 2H3a2 2 0 0 1-2-2v-1h1v1a1 1 0 0 0 1 1h10a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H3a1 1 0 0 0-1 1v1H1V2a2 2 0 0 1 2-2z"/>
                                                              <path d="M1 5v-.5a.5.5 0 0 1 1 0V5h.5a.5.5 0 0 1 0 1h-2a.5.5 0 0 1 0-1H1zm0 3v-.5a.5.5 0 0 1 1 0V8h.5a.5.5 0 0 1 0 1h-2a.5.5 0 0 1 0-1H1zm0 3v-.5a.5.5 0 0 1 1 0v.5h.5a.5.5 0 0 1 0 1h-2a.5.5 0 0 1 0-1H1z"/>
                                                            </svg>
                                                        </asp:LinkButton>
                                                        <asp:LinkButton ID="btnCancelarAlquiler" OnClick="btnCancelarAlquiler_Click" CommandArgument='<%#Eval("Id")%>' OnClientClick="return confirm('Esta seguro de cancelar el alquiler?');" CssClass="btn btn-outline-light" runat="server">
                                                             <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-trash" viewBox="0 0 16 16" style="color:red;">
                                                              <path d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"/>
                                                              <path fill-rule="evenodd" d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"/>
                                                            </svg>
                                                        </asp:LinkButton>

                                                    </ContentTemplate>

                                                    <Triggers>
                                                        <asp:AsyncPostBackTrigger ControlID="btnDetalle" EventName="Click" />

                                                    </Triggers>
                                                </asp:UpdatePanel>

                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>

                            </tbody>
                        </table>

                    </div>
                </div>
            </div>

            <!-- Bootstrap Modal Dialog -->
            <div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                <div class="modal-dialog">
                    <asp:UpdatePanel ID="upModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="modal-content">
                                <div class="modal-header">                                    
                                    <h3 class="modal-title">
                                        <asp:Label ID="lblModalTitle" runat="server" Text=""></asp:Label>
                                    </h3>
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                                </div>
                                <div class="modal-body">
                                    <label for="recipient-name" class="col-form-label">Email:</label>
                                    <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" disabled></asp:TextBox>

                                    <label for="recipient-name" class="col-form-label">Nombre:</label>
                                    <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" disabled></asp:TextBox>

                                    <label for="recipient-name" class="col-form-label">Apellido:</label>
                                    <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server" disabled></asp:TextBox>

                                    <label for="recipient-name" class="col-form-label">Numero:</label>
                                    <asp:TextBox ID="txtNumero" CssClass="form-control" runat="server" disabled></asp:TextBox>

                                    <label for="recipient-name" class="col-form-label">Total a pagar:</label>
                                    <asp:TextBox ID="txtPagar" CssClass="form-control" runat="server" disabled></asp:TextBox>

                                </div>
                                <div class="modal-footer">
                                    <button class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Cerrar</button>
                                </div>

                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
    </div>



</asp:Content>
