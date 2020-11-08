<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gestionarContrato.aspx.cs" Inherits="Vistalcgs.gestionarContrato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <title>Concesionario</title>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <a class="navbar-brand" href="#">concesionario</a>
    </nav>

    <nav class="navbar navbar-expand-lg navbar-ligth bg-ligth">
       <div class="collapse navbar-collapse " id="navbarNav">
              <ul class="navbar-nav">
                <li class="nav-item active">
                    <a class="nav-link" href="gestionarTipoVehiculo.aspx">Tipo Vehiculos</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestionarVehiculo.aspx">Vehiculos</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestionarTipoConductor.aspx">Tipo Conductor</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestionarConductor.aspx">Conductor</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestionarContrato.aspx">Contrato</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestionarRuta.aspx">Ruta</a>
                </li>
            </ul>
       </div>
    </nav>

    <div class="container">
        <br />
        <h1>Gestión Contrato</h1>
        <br />
        <form id="form1" runat="server">

            <div class="form-group">
               <label for="txtId">Id</label>
                <asp:TextBox ID="txtId" runat="server" Class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
               <label for="txtIdConductor">Id conductor</label>
                <asp:TextBox ID="txtIdConductor" runat="server" Class="form-control"></asp:TextBox>
            </div>

             <div class="form-group">
               <label for="txtIdVehiculo">Id vehiculo</label>
                <asp:TextBox ID="txtIdVehiculo" runat="server" Class="form-control"></asp:TextBox>
            </div>

            <div class="form-row">

                <div class="col-8">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-primary" OnClick="btnAdd_Click"/>
                </div>

                <div class="col-4 text-rigth">
                    <asp:Button ID="btnList" runat="server" Text="List" class="btn btn-primary" OnClick="btnList_Click" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-primary" OnClick="btnUpdate_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-primary" OnClick="btnDelete_Click" />
                </div>

             </div>

                <div class="form-row">
                    <asp:Label ID="lblMensaje" runat="server" ForeColor="Blue" EnableViewState="false"></asp:Label>

                </div>           

            <br />

            <table class="table">
                <tr>
                    <th>
                        <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField DataField="id" HeaderText="Id" />
                                <asp:BoundField DataField="id_conductor" HeaderText="id_conductor" />
                                <asp:BoundField DataField="id_vehiculo" HeaderText="id_vehiculo" />
                            </Columns>
                        </asp:GridView>
                    </th>
                </tr>

            </table>

    </form>
    </div>

    
</body>
</html>
