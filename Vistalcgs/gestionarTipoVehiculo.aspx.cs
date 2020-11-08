using Controlador.TipoVehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistalcgs
{
    public partial class gestionarTipoVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
        }

        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);
            string typename = txtName.Text;

            LogicaControladorTipoVehiculo negocioAddTipoVehiculo = new LogicaControladorTipoVehiculo();
            int resultadoAddTipoVehiculo = negocioAddTipoVehiculo.NegociarInsertTipoVehiculo(cartypeid, typename);

            if (resultadoAddTipoVehiculo > 0)
                lblMensaje.Text = "Registro oK";
            else
                lblMensaje.Text = "No se pudo registrar";

            negocioAddTipoVehiculo = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = LogicaControladorTipoVehiculo.NegociarSelectTipoVehiculo();

            GridView.DataBind();

            txtId.Text = txtName.Text = "";


        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);
            string typename = txtName.Text;

            LogicaControladorTipoVehiculo negocioUpdateTipoVehiculo = new LogicaControladorTipoVehiculo();
            int resultadoUpdateTipoVehiculo = negocioUpdateTipoVehiculo.NegociarUpdateTipoVehiculo(cartypeid, typename);

            if (resultadoUpdateTipoVehiculo > 0)
                lblMensaje.Text = "Actualizacion oK";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateTipoVehiculo = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);
           
            LogicaControladorTipoVehiculo negocioDeleteTipoVehiculo = new LogicaControladorTipoVehiculo();
            int resultadoDeleteTipoVehiculo = negocioDeleteTipoVehiculo.NegociarDeleteTipoVehiculo(cartypeid);

            if (resultadoDeleteTipoVehiculo > 0)
                lblMensaje.Text = "Eliminar oK";
            else
                lblMensaje.Text = "No se pudo Eliminar";

            negocioDeleteTipoVehiculo = null;
        }
    }
}