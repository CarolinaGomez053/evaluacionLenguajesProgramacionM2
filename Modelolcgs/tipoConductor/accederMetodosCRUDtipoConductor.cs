using Modelolcgs.TipoV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelolcgs.tipoConductor
{
    public class accederMetodosCRUDtipoConductor
    {
        public int insertTipoConductor(int id, string tipo_persona)
        {
            SqlCommand _comando = metodosCRUDtipoConductor.CrearComandoTipoProceAlmacInser_tC();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@tipo_persona", tipo_persona);

            return metodosCRUDtipoConductor.EjecutarComandoProcAlmacInsert_tC(_comando);

        }

        //Operacion Select
        public static DataTable listTipoConductor()

        {
            SqlCommand _comando = metodosCRUDtipoConductor.CrearComandoSelect_tC();
            _comando.CommandText = "select * from tipo_conductor";

            return metodosCRUDtipoConductor.EjecutarComandoSelect_tC(_comando);

        }

        //operacion Update
        public int UpdateTipoConductor(int id, string tipo_persona)
        {
            SqlCommand _comando = metodosCRUDtipoConductor.CrearComandoTipoProceAlmacUpdate_tC();
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@tipo_persona", tipo_persona);

            return metodosCRUDtipoConductor.EjecutarComandoProcAlmacUpdate_tC(_comando);
        }

        //operacion Delete
        public int DeleteTipoConductor(int id)
        {
            SqlCommand _comando = metodosCRUDtipoConductor.CrearComandoTipoProceAlmacDelete_tC();
            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacDelete_tv(_comando);
        }

    }

}
