using Modelolcgs.Vehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Vehiculo
{
    public class LogicaControladorVehiculo
    {

        //Negociar Insert
        public int NegociarInsertVehiculo(int id, string marca, string modelo, string placa, int año, int id_tv)
        {
            AccederMetodosCRUDvehiculo negociaraccesoVehiculo = new AccederMetodosCRUDvehiculo();
            return negociaraccesoVehiculo.insertvehiculo(id, marca, modelo, placa, año, id_tv);
        }

        //Negociar Select
        public static DataTable NegociarSelectVehiculo()
        {
            return AccederMetodosCRUDvehiculo.listVehiculo();
        }

        //Negociar Update
        public int NegociarUpdateVehiculo(int id, string marca, string modelo, string placa, int año, int id_tv)
        {
            AccederMetodosCRUDvehiculo negociaraccesoVehiculo = new AccederMetodosCRUDvehiculo();
            return negociaraccesoVehiculo.UpdateVehiculo(id, marca, modelo, placa, año, id_tv);
        }

        //Negociar Delete
        public int NegociarDeleteVehiculo(int id)
        {
            AccederMetodosCRUDvehiculo negociaraccesoVehiculo = new AccederMetodosCRUDvehiculo();
            return negociaraccesoVehiculo.DeleteVehiculo(id);
        }

    }
}
