using Modelolcgs.ruta;
using Modelolcgs.TipoV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.ruta
{
    public class logicaControladorRuta
    {

        //Negociar Insert
        public int NegociarInsertRuta(int id, string estacion, int id_vehiculo)
        {
            accederMetodosCRUDruta negociaraccesoRuta = new accederMetodosCRUDruta();
            return negociaraccesoRuta.insertRuta(id, estacion, id_vehiculo);
        }

        //Negociar Select
        public static DataTable NegociarSelectRuta()
        {
            return accederMetodosCRUDruta.listaRuta ();
        }

        //Negociar Update
        public int NegociarUpdateRuta(int id, string estacion, int id_vehiculo)
        {
            accederMetodosCRUDruta negociaraccesoRuta = new accederMetodosCRUDruta();
            return negociaraccesoRuta.UpdateRuta (id, estacion, id_vehiculo);
        }

        //Negociar Delete
        public int NegociarDeleteRuta(int id)
        {
            accederMetodosCRUDruta negociarnegociaraccesoRuta = new accederMetodosCRUDruta();
            return negociarnegociaraccesoRuta.DeleteRuta(id);
        }

    }
}
