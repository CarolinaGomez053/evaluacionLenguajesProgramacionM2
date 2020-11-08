using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelolcgs
{
   public class Configuracion
    {
        static string cadenaConexion = @"Data Source=DESKTOP-LMIQO3D\SQLEXPRESS; Initial Catalog=concesionarioCS; Trusted_Connection=true"; 
   
        public static string CadenaConexion
        {

                get {return cadenaConexion;}


        }

    }
}
