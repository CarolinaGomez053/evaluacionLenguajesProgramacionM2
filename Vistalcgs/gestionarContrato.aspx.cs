using Controlador.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistalcgs
{
    public partial class gestionarContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            int id_conductor = Int32.Parse(txtIdConductor.Text);
            int id_vehiculo = Int32.Parse(txtIdVehiculo.Text);

           logicaControladorContrato negocioaddContrato = new logicaControladorContrato();
            int resultadoAddContrato = negocioaddContrato.NegociarInsertContrato(id, id_conductor, id_vehiculo);

            if (resultadoAddContrato > 0)
                lblMensaje.Text = "Registro oK";
            else
                lblMensaje.Text = "No se pudo registrar";

            negocioaddContrato = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
           GridView.DataSource=logicaControladorContrato.NegociarSelectContrato();

            GridView.DataBind();

            txtId.Text = txtIdConductor.Text = txtIdVehiculo.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            int id_conductor = Int32.Parse(txtIdConductor.Text);
            int id_vehiculo = Int32.Parse(txtIdVehiculo.Text);

            logicaControladorContrato negocioUpdateContrato = new logicaControladorContrato();
            int resultadoUpdateContrato = negocioUpdateContrato.NegociarUpdateContrato(id, id_conductor, id_vehiculo);

            if (resultadoUpdateContrato > 0)
                lblMensaje.Text = "Actualizacion oK";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateContrato = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);

            logicaControladorContrato negocioDeleteContrato = new logicaControladorContrato();
            int resultadoDeleteContrato = negocioDeleteContrato.NegociarDeleteContrato(id);

            if (resultadoDeleteContrato > 0)
                lblMensaje.Text = "Eliminar oK";
            else
                lblMensaje.Text = "No se pudo Eliminar";

            negocioDeleteContrato = null;

        }
    }
}