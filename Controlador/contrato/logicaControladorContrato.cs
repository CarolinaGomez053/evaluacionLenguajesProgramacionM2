using Modelolcgs.contrato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.contrato
{
   public class logicaControladorContrato
    {
        
        //Negociar Insert
        public int NegociarInsertContrato(int id, int id_conductor, int id_vehiculo)
        {
            accederMetodosCRUDcontrato negociaraccesoContrato = new accederMetodosCRUDcontrato();
            return negociaraccesoContrato.insertContrato(id, id_conductor, id_vehiculo);
        }
    
        //Negociar Select
        public static DataTable NegociarSelectContrato()
        {
            return accederMetodosCRUDcontrato.listContrato();
        }

        //Negociar Update
        public int NegociarUpdateContrato(int id, int id_conductor, int id_vehiculo)
        {
            accederMetodosCRUDcontrato negociaraccesoContrato = new accederMetodosCRUDcontrato();
            return negociaraccesoContrato.UpdateContrato(id, id_conductor, id_vehiculo);
        }

        //Negociar Delete
        public int NegociarDeleteContrato(int id)
        {
            accederMetodosCRUDcontrato negociaraccesoContrato = new accederMetodosCRUDcontrato();
            return negociaraccesoContrato.DeleteContrato(id);
        }

    }
}
