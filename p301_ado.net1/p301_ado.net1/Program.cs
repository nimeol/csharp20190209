using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace p301_ado.net1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Data source = topcredu;user id = scott; password = tiger";
            string str = @"Data Source=(DESCRIPTION =
 (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
 (CONNECT_DATA =
 (SERVER = DEDICATED)
(SERVICE_NAME = topcredu)
 )
 ) ;User Id=scott;Password=tiger";
            OracleConnection Conn = new OracleConnection(str);
            OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;
            try
            {
                Conn.Open();
                Comm.CommandText = "SELECT * FROM EMP";
                OracleDataReader reader = Comm.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine(reader.GetString(reader.GetOrdinal("ENAME")));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
