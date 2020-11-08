using Controlador.tipoConductor;
using Controlador.TipoVehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistalcgs
{
    public partial class gestionarTipoConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string tipo_persona = txtTipoPersona.Text;

            logicaControladorTipoConductor negocioAddTC = new logicaControladorTipoConductor();

            int resultadoAddTC = negocioAddTC.NegociarInsertTipoConductor(id, tipo_persona);

            if (resultadoAddTC > 0)
                lblMensaje.Text = "Registro exitoso";
            else
                lblMensaje.Text = "No se pudo registrar";

            negocioAddTC = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorTipoConductor.NegociarSelectTipoConductor();

            GridView.DataBind();

            txtId.Text = txtTipoPersona.Text= "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string tipo_persona = txtTipoPersona.Text;

            logicaControladorTipoConductor negocioUpdateTC = new logicaControladorTipoConductor();
            int resultadoUpdateTC = negocioUpdateTC.NegociarUpdateTipoConductor(id, tipo_persona);

            if (resultadoUpdateTC > 0)
                lblMensaje.Text = "Actualizacion oK";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateTC = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);

            logicaControladorTipoConductor negocioDeleteTC = new logicaControladorTipoConductor();
            int resultadoDeleteTC = negocioDeleteTC.NegociarDeleteTipoConductor(id);

            if (resultadoDeleteTC > 0)
                lblMensaje.Text = "Eliminar oK";
            else
                lblMensaje.Text = "No se pudo Eliminar";

            negocioDeleteTC = null;
        }
    }
}