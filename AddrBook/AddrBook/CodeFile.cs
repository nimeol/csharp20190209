using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AddrBook
{
    public class Common_DB
    {
        public static OleDbConnection DbConnection()
        {
            OleDbConnection Conn;
            string ConStr = "Provider=OraOLEDB.Oracle;data source=topcredu;User ID=scott;Password=tiger";

            Conn = new OleDbConnection(ConStr);
            return Conn;
        }
        public static OleDbDataReader DataSelect(string sql, OleDbConnection Conn)
        {
            try
            {
                OleDbCommand myCommand = new OleDbCommand(sql, Conn);
                return myCommand.ExecuteReader();
            }
            catch(Exception ex)
            {
                Log.WriteLine("codefile", ex.Message);
                MessageBox.Show(sql + "\n" + ex.Message, "DataSelect");
                return null;
            }
            finally{}    
        }
        public static bool DataManupulation(string sql, OleDbConnection Conn)
        {
            try
            {
                OleDbCommand myCommand = new OleDbCommand(sql, Conn);
                myCommand.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                Log.WriteLine("codefile", ex.Message);
                MessageBox.Show(sql + "\n" + ex.Message, "dataManupulation");
                return false;
            }
            finally
            {

            }
        }

    }
    /*
    class CodeFile
    {
    }*/
}
