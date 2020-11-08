using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelolcgs.contrato
{
   public class accederMetodosCRUDcontrato
    {
       public int insertContrato(int id, int id_conductor, int id_vehiculo)
        {
            SqlCommand _comando = metodosCRUDcontrato.CrearComandoTipoProceAlmacDelete_contrato();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@id_conductor", id_conductor);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return metodosCRUDcontrato.EjecutarComandoProcAlmacInsert_contrato(_comando);

        }

        //Operacion Select
        public static DataTable listContrato()

        {
            SqlCommand _comando = metodosCRUDcontrato.CrearComandoSelect_contrato();
            _comando.CommandText = "select * from contrato";

            return metodosCRUDcontrato.EjecutarComandoSelect_contrato(_comando);

        }

        //operacion Update
        public int UpdateContrato(int id, int id_conductor, int id_vehiculo)
        {
            SqlCommand _comando =metodosCRUDcontrato.CrearComandoTipoProceAlmacUpdate_contrato();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@id_conductor", id_conductor);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return metodosCRUDcontrato.EjecutarComandoProcAlmacUpdate_contrato(_comando);
        }

        //operacion Delete
        public int DeleteContrato(int id)
        {
            SqlCommand _comando = metodosCRUDcontrato.CrearComandoTipoProceAlmacDelete_contrato();
            _comando.Parameters.AddWithValue("@id", id);

            return metodosCRUDcontrato.EjecutarComandoProcAlmacDelete_contrato(_comando);
        }
    }
}
