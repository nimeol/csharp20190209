using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OracleTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conn = null;
        OleDbDataAdapter adapter = null;
        DataSet ds = null;


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            { ds = new DataSet("emp");
                string conStr = "Provider=OraOLEDB.Oracle;data source=topcredu;User ID = scott; Password=tiger";
                conn = new OleDbConnection(conStr);
                conn.Open();
                OleDbCommand command = new OleDbCommand("insert into emp(empno, ename) values((select max(empno)+1 from emp),'DH')", conn);
                command.ExecuteNonQuery();
                adapter = new OleDbDataAdapter("select * from emp", conn);
                adapter.Fill(ds);
                //adapter.Fill(ds,"A"); dataset에 a라는 table을 만듬
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
