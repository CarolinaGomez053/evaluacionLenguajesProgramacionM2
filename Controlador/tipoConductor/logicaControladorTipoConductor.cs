using Modelolcgs.tipoConductor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.tipoConductor
{
    public class logicaControladorTipoConductor
    {

        //Negociar Insert
        public int NegociarInsertTipoConductor(int id, string tipo_persona)
        {
          accederMetodosCRUDtipoConductor negociaraccesoTC = new accederMetodosCRUDtipoConductor();
            return negociaraccesoTC.insertTipoConductor(id, tipo_persona);
        }

        //Negociar Select
        public static DataTable NegociarSelectTipoConductor()
        {
            return accederMetodosCRUDtipoConductor.listTipoConductor();
        }

        //Negociar Update
        public int NegociarUpdateTipoConductor(int id, string tipo_persona)
        {
            accederMetodosCRUDtipoConductor negociaraccesoTV = new accederMetodosCRUDtipoConductor();
            return negociaraccesoTV.UpdateTipoConductor(id, tipo_persona);
        }

        //Negociar Delete
        public int NegociarDeleteTipoConductor(int id)
        {
            accederMetodosCRUDtipoConductor negociaraccesoTC = new accederMetodosCRUDtipoConductor();
            return negociaraccesoTC.DeleteTipoConductor(id);
        }

    }
}
