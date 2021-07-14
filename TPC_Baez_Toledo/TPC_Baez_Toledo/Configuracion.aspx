<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Configuracion.aspx.cs" Inherits="TPC_Baez_Toledo.Configuracion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="accordion" id="accordionExample">
  <div class="card">
    <div class="card-header" id="headingOne">
      <h2 class="mb-0">
        <button class="btn btn-link btn-block text-left" type="button" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
          Cambiar email
        </button>
      </h2>
    </div>

    <div id="collapseOne" class="collapse show" aria-labelledby="headingOne" data-parent="#accordionExample">
      <div class="card-body">
          <div class="input-group mb-3">
            <div class="input-group-prepend">
            <span class="input-group-text" id="basic-addon1">Email</span>
            </div>
                <asp:TextBox ID="txtEmail" CssClass="form-control" TextMode="Email" runat="server"></asp:TextBox>
           </div>
      </div>
        <asp:Button ID="btnEmail" CssClass="btn btn-primary btn-lg btn-block" runat="server" OnClick="btnEmail_Click" Text="Cambiar email"/>
    </div>
  </div>
  <div class="card">
    <div class="card-header" id="headingTwo">
      <h2 class="mb-0">
        <button class="btn btn-link btn-block text-left collapsed" type="button" data-toggle="collapse" data-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
          Cambiar contraseña
        </button>
      </h2>
    </div>
    <div id="collapseTwo" class="collapse" aria-labelledby="headingTwo" data-parent="#accordionExample">
      <div class="card-body">
          <div class="input-group mb-3">
            <div class="input-group-prepend">
            <span class="input-group-text" id="basic-addon1">Contraseña actual</span>
            </div>
                <asp:TextBox ID="txtContraActual" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
           </div>
          <div class="input-group mb-3">
            <div class="input-group-prepend">
            <span class="input-group-text" id="basic-addon1">Nueva contraseña</span>
            </div>
                <asp:TextBox ID="txtContraNueva" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
           </div>
          <div class="input-group mb-3">
            <div class="input-group-prepend">
            <span class="input-group-text" id="basic-addon1">Confirmar contraseña</span>
            </div>
                <asp:TextBox ID="txtContraConfirm" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
           </div>
           <asp:Button ID="btnContraseña" CssClass="btn btn-primary btn-lg btn-block" runat="server" OnClick="btnContraseña_Click" Text="Cambiar contraseña"/>
      </div>
    </div>
  </div>
  <div class="card">
    <div class="card-header" id="headingThree">
      <h2 class="mb-0">
        <button class="btn btn-link btn-block text-left collapsed" type="button" data-toggle="collapse" data-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
          Cambiar datos personales
        </button>
      </h2>
    </div>
    <div id="collapseThree" class="collapse" aria-labelledby="headingThree" data-parent="#accordionExample">
      <div class="card-body">
          <div class="input-group mb-3">
            <div class="input-group-prepend">
            <span class="input-group-text" id="basic-addon1">Nombre</span>
            </div>
                <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
           </div>
          <div class="input-group mb-3">
            <div class="input-group-prepend">
            <span class="input-group-text" id="basic-addon1">Apellido</span>
            </div>
                <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server"></asp:TextBox>
           </div>
          <div class="input-group mb-3">
            <div class="input-group-prepend">
            <span class="input-group-text" id="basic-addon1">Telefono</span>
            </div>
                <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>
           </div>
           <asp:Button ID="btnDatos" CssClass="btn btn-primary btn-lg btn-block" runat="server" OnClick="btnDatos_Click" Text="Cambiar datos personales"/>
      </div>
    </div>
  </div>
</div>
</asp:Content>
