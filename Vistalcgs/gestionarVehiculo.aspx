<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gestionarVehiculo.aspx.cs" Inherits="Vistalcgs.gestionarVehiculo" %>

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
        <h1>Gestión Vehiculos</h1>
        <br />
        <form id="form1" runat="server">
            <div class="form-group">
               <label for="txtId">Id</label>
                <asp:TextBox ID="txtId" runat="server" Class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
               <label for="txtMarca">Marca</label>
                <asp:TextBox ID="txtMarca" runat="server" Class="form-control"></asp:TextBox>
            </div>

               <div class="form-group">
               <label for="txtModelo">Modelo</label>
                <asp:TextBox ID="txtModelo" runat="server" Class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
               <label for="txtPlaca">Placa</label>
                <asp:TextBox ID="txtPlaca" runat="server" Class="form-control"></asp:TextBox>
            </div>

               <div class="form-group">
               <label for="txtAño">Año</label>
                <asp:TextBox ID="txtAño" runat="server" Class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
               <label for="txtid_tv">id_tv</label>
                <asp:TextBox ID="txtid_tv" runat="server" Class="form-control"></asp:TextBox>
            </div>

            <div class="form-row">
                <div class="col-8">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn-primary" OnClick="btnAdd_Click" />
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
                                <asp:BoundField DataField="marca" HeaderText="marca" />
                                <asp:BoundField DataField="modelo" HeaderText="modelo" />
                                <asp:BoundField DataField="placa" HeaderText="placa" />
                                <asp:BoundField DataField="año" HeaderText="año" />
                                <asp:BoundField DataField="id_tv" HeaderText="id_tv" />
                               
                            </Columns>
                        </asp:GridView>
                    </th>
                </tr>

            </table>
    </form>
    </div>

     <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
  
</body>
</html>
