using Modelolcgs.TipoV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.TipoVehiculo
{
   public class LogicaControladorTipoVehiculo
    {
        //Negociar Insert
        public int NegociarInsertTipoVehiculo(int id, string name)
        {
            AccesoMetodosCRUDtipoVehiculo negociaraccesoTV = new AccesoMetodosCRUDtipoVehiculo();
            return negociaraccesoTV.InsertTipoVehiculo(id, name);
        }
    
        //Negociar Select
        public static DataTable NegociarSelectTipoVehiculo()
        {
            return AccesoMetodosCRUDtipoVehiculo.listTipoVehiculo();
        }

        //Negociar Update
        public int NegociarUpdateTipoVehiculo(int id, string name)
        {
            AccesoMetodosCRUDtipoVehiculo negociaraccesoTV = new AccesoMetodosCRUDtipoVehiculo();
            return negociaraccesoTV.UpdateTipoVehiculo(id, name);
        }

        //Negociar Delete
        public int NegociarDeleteTipoVehiculo(int id)
        {
            AccesoMetodosCRUDtipoVehiculo negociaraccesoTV = new AccesoMetodosCRUDtipoVehiculo();
            return negociaraccesoTV.DeleteTipoVehiculo(id);
        }

    }


}
