using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Modelolcgs.TipoV
{
    public class MetodosCRUDtipoVehiculo
    {
        //crear tipo comando INSERT
        public static SqlCommand CrearComandoTipoProceAlmacInser_tv()
        {
            //crear tipo de comando
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("addTipoVehiculo", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
            //ejecutar tipo de comando
                    

        }

        //ejecutar tipo comando INSERT
        public static int EjecutarComandoProcAlmacInsert_tv(SqlCommand comando)
        { try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();

            }

            catch{ throw;}

            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        //crear tipo comando SELECT
        public static SqlCommand CrearComandoSelect_tv()
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
        public static DataTable EjecutarComandoSelect_tv(SqlCommand comando)
        {

            DataTable _table = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                adapter.Fill(_table);
              }

            catch (Exception Ex){ throw Ex; }

            finally {comando.Connection.Close();}

            return _table;

        }
        
        //Crear tipo comando UPDATE
        public static SqlCommand CrearComandoTipoProceAlmacUpdate_tv()
        {
            //crear tipo de comando
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("updateTipoVehiculo", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }

        //ejecutar tipo comando UPDATE
        public static int EjecutarComandoProcAlmacUpdate_tv(SqlCommand comando)
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
        public static SqlCommand CrearComandoTipoProceAlmacDelete_tv()
        {
            //crear tipo de comando
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("DeleteTipoVehiculo", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }

        //ejecutar tipo comando UPDATE
        public static int EjecutarComandoProcAlmacDelete_tv(SqlCommand comando)
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
