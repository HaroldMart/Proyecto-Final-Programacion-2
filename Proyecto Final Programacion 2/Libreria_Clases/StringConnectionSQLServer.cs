using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Librerias_Clases
{
    public class Conexion
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection cn = new SqlConnection("Server = DESKTOP-NI2ORBL; Database = SellPoint; Trusted_Connection = True");
            cn.Open();
            return cn;

        }
    }
}
