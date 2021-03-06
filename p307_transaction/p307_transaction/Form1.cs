﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p307_transaction
{
    public partial class Form1 : Form
    {
        OleDbDataAdapter adapter = null;
        DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new DataSet("emp");
            string conStr = "Provider=ORAOLEDB.ORACLE;data source=topcredu;User ID = scott; Password = tiger";

            using (OleDbConnection connection = new OleDbConnection(conStr))
            {
                OleDbCommand command = new OleDbCommand();
                OleDbTransaction tr = null;//transaction 또한 객체
                try
                {
                    connection.Open();
                    tr = connection.BeginTransaction();//트랜젝션 생성
                    command.Connection = connection;
                    command.Transaction = tr;

                    command.CommandText = "insert into emp(empno, ename)" +
                        "values(0002,'1000 dh')";
                    int i = command.ExecuteNonQuery();
                    Console.WriteLine(i + "건 inserted!");
                    /*
                    command.CommandText = "insert into emp(empno, ename)" +
                        "values(0001,'1000 dh')";
                    i = command.ExecuteNonQuery();
                    */
                    tr.Commit();

                    adapter = new OleDbDataAdapter("select * from emp", connection);
                    adapter.Fill(ds, "emp");
                }
                catch(Exception ex)
                {
                    tr?.Rollback();
                    MessageBox.Show(ex.Message, "emp Table Loading Error");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
