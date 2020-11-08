using Controlador.TipoVehiculo;
using Controlador.Vehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistalcgs
{
    public partial class gestionarVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id=Int32.Parse(txtId.Text);
            string marca= txtMarca.Text; 
            string modelo= txtModelo.Text; 
            string placa= txtPlaca.Text;
            int año=Int32.Parse(txtAño.Text);
            int id_tv=Int32.Parse(txtid_tv.Text);

            LogicaControladorVehiculo negocioAddVehiculo = new LogicaControladorVehiculo();

            int resultadoAddVehiculo = negocioAddVehiculo.NegociarInsertVehiculo(id, marca, modelo, placa, año, id_tv);

            if (resultadoAddVehiculo > 0)
                lblMensaje.Text = "Registro Exitoso";
            else
                lblMensaje.Text = "no se pudo hacer el registro";


            negocioAddVehiculo = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = LogicaControladorVehiculo.NegociarSelectVehiculo();

            GridView.DataBind();

            txtId.Text = txtMarca.Text= txtModelo.Text= = txtPlaca.Text= txtAño.Text = txtid_tv.Text= "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string placa = txtPlaca.Text;
            int año = Int32.Parse(txtAño.Text);
            int id_tv = Int32.Parse(txtid_tv.Text);

            LogicaControladorVehiculo negocioUpdateVehiculo = new LogicaControladorVehiculo();
            int resultadoUpdateVehiculo = negocioUpdateVehiculo.NegociarUpdateVehiculo(id, marca, modelo, placa, año, id_tv);

            if (resultadoUpdateVehiculo > 0)
                lblMensaje.Text = "Actualizacion oK";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateVehiculo = null;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);

            LogicaControladorVehiculo negocioDeleteVehiculo = new LogicaControladorVehiculo();
            int resultadoDeleteVehiculo = negocioDeleteVehiculo.NegociarDeleteVehiculo(id);

            if (resultadoDeleteVehiculo > 0)
                lblMensaje.Text = "Eliminar oK";
            else
                lblMensaje.Text = "No se pudo Eliminar";

            negocioDeleteVehiculo = null;
        }
    }
}