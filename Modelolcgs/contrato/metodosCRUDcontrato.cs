using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelolcgs.contrato
{
    public class metodosCRUDcontrato
    {
        //crear tipo comando INSERT
        public static SqlCommand CrearComandoTipoProceAlmacInser_contrato()
        {
            //crear tipo de comando
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("addcontrato", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
            //ejecutar tipo de comando



        }

        //ejecutar tipo comando INSERT
        public static int EjecutarComandoProcAlmacInsert_contrato(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();

            }

            catch { throw; }

            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        //crear tipo comando SELECT
        public static SqlCommand CrearComandoSelect_contrato()
        {
            //usar la conexion
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;

            //crear la instruccion

            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;

            return _comando;
        }

        //ejecutar tipo comando SELECT
        public static DataTable EjecutarComandoSelect_contrato(SqlCommand comando)
        {

            DataTable _table = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                adapter.Fill(_table);
            }

            catch (Exception Ex) { throw Ex; }

            finally { comando.Connection.Close(); }

            return _table;

        }

        //Crear tipo comando UPDATE
        public static SqlCommand CrearComandoTipoProceAlmacUpdate_contrato()
        {
            //crear tipo de comando
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("updateTipoVehiculo", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }

        //ejecutar tipo comando UPDATE
        public static int EjecutarComandoProcAlmacUpdate_contrato(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();

            }

            catch { throw; }

            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        //Crear tipo comando UPDATE
        public static SqlCommand CrearComandoTipoProceAlmacDelete_contrato()
        {
            //crear tipo de comando
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("DeleteTipoVehiculo", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }

        //ejecutar tipo comando UPDATE
        public static int EjecutarComandoProcAlmacDelete_contrato(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();

            }

            catch { throw; }

            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
    }
}
