using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelolcgs.ruta
{
    public class accederMetodosCRUDruta
    {
            public int insertRuta(int id, string estacion, int id_vehiculo)
            {
            SqlCommand _comando = MetodosCRUDruta.CrearComandoTipoProceAlmacInser_ruta();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estacion", estacion);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDruta.EjecutarComandoProcAlmacInsert_ruta(_comando);
            }

        //Operacion Select
        public static DataTable listaRuta()

        {
            SqlCommand _comando = MetodosCRUDruta.CrearComandoSelect_ruta();
            _comando.CommandText = "select * from ruta";

            return MetodosCRUDruta.EjecutarComandoSelect_ruta(_comando);

        }

        //operacion Update
        public int UpdateRuta(int id, string estacion, int id_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDruta.CrearComandoTipoProceAlmacUpdate_ruta();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estacion", estacion);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDruta.EjecutarComandoProcAlmacUpdate_ruta(_comando);
        }

        //operacion Delete
        public int DeleteRuta(int id)
        {
            SqlCommand _comando = MetodosCRUDruta.CrearComandoTipoProceAlmacDelete_ruta();
            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDruta.EjecutarComandoProcAlmacDelete_ruta(_comando);
        }


    }

}
