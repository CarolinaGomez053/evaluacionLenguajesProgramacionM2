using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelolcgs.TipoV
{
    public class AccesoMetodosCRUDtipoVehiculo
    {
        //operacion Insert
        public int InsertTipoVehiculo(int id, string nombre )
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoTipoProceAlmacInser_tv();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacInsert_tv(_comando);
        }

        //Operacion Select
        public static DataTable listTipoVehiculo()

        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoSelect_tv();
            _comando.CommandText = "select * from tipoVehiculo";

            return MetodosCRUDtipoVehiculo.EjecutarComandoSelect_tv(_comando);

        }

        //operacion Update
        public int UpdateTipoVehiculo(int id, string nombre)
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoTipoProceAlmacUpdate_tv ();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacUpdate_tv(_comando);
        }

        //operacion Delete
        public int DeleteTipoVehiculo(int id)
        {
            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoTipoProceAlmacDelete_tv();
            _comando.Parameters.AddWithValue("@id", id);
         
            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacDelete_tv(_comando);
        }
    }
}

