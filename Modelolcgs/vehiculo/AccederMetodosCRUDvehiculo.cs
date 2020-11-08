using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelolcgs.Vehiculo
{
    public class AccederMetodosCRUDvehiculo
    {
        //crear operacion insert
        public int insertvehiculo(int id, string marca, string modelo, string placa, int año, int id_tv )
        {
            SqlCommand _comando = MetodosCRUDvehiculo.CrearComandoTipoProceAlmacInser_veh();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@placa", placa);
            _comando.Parameters.AddWithValue("@año", año);
            _comando.Parameters.AddWithValue("@id_tv", id_tv);

            return MetodosCRUDvehiculo.EjecutarComandoProcAlmacInsert_veh(_comando);
        }

        //Operacion Select
        public static DataTable listVehiculo()

        {
            SqlCommand _comando = MetodosCRUDvehiculo.CrearComandoSelect_veh();
            _comando.CommandText = "select * from tipoVehiculo";

            return MetodosCRUDvehiculo.EjecutarComandoSelect_veh(_comando);

        }

        //operacion Update
        public int UpdateVehiculo(int id, string marca, string modelo, string placa, int año, int id_tv)
        {
            SqlCommand _comando = MetodosCRUDvehiculo.CrearComandoTipoProceAlmacUpdate_veh();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@placa", placa);
            _comando.Parameters.AddWithValue("@año", año);
            _comando.Parameters.AddWithValue("@id_tv", id_tv);

            return MetodosCRUDvehiculo.EjecutarComandoProcAlmacUpdate_veh(_comando);
        }

        //operacion Delete
        public int DeleteVehiculo(int id)
        {
            SqlCommand _comando = MetodosCRUDvehiculo.CrearComandoTipoProceAlmacDelete_veh();
            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDvehiculo.EjecutarComandoProcAlmacDelete_veh(_comando);
        }

    }
}
