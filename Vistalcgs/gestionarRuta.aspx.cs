using Controlador.ruta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistalcgs
{
    public partial class gestionarRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string estacion = txtEstacion.Text;
            int id_vehiculo = Int32.Parse(txtIdVehiculo.Text);

            logicaControladorRuta negocioAddRuta = new logicaControladorRuta();

            int resultadoAddRuta = negocioAddRuta.NegociarInsertRuta(id,estacion,id_vehiculo);

            if (resultadoAddRuta > 0)
                lblMensaje.Text = "registro ok";
            else
                lblMensaje.Text = "No se pudo registrar";

            negocioAddRuta = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorRuta.NegociarSelectRuta();
            GridView.DataBind();
            txtId.Text = txtEstacion.Text = txtIdVehiculo.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string estacion = txtEstacion.Text;
            int id_vehiculo = Int32.Parse(txtIdVehiculo.Text);

            logicaControladorRuta negocioUpdateRuta = new logicaControladorRuta();
            int resultadoUpdateRuta = negocioUpdateRuta.NegociarUpdateRuta(id, estacion, id_vehiculo);

            if (resultadoUpdateRuta > 0)
                lblMensaje.Text = "Actualizacion oK";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateRuta = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);

            logicaControladorRuta negocioDeleteRuta = new logicaControladorRuta();
            int resultadoDeleteRuta = negocioDeleteRuta.NegociarDeleteRuta(id);

            if (resultadoDeleteRuta > 0)
                lblMensaje.Text = "Eliminar oK";
            else
                lblMensaje.Text = "No se pudo Eliminar";

            negocioDeleteRuta = null;
        }
    }
}