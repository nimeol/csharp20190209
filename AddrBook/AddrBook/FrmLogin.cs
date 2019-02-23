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

namespace AddrBook
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private OleDbConnection LocalConn;

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataReader myReader;
            string sql = null;
            try
            {
                LocalConn = Common_DB.DbConnection();
                LocalConn.Open();
                if(txtID.Text == "" || txtPWD.Text == "")
                {
                    MessageBox.Show("입력하세요");
                    return;
                }
                sql = "select pwd from member ";
                sql += " where id = " + "'" + txtID.Text + "'";

                myReader = Common_DB.DataSelect(sql, LocalConn);

                if(myReader.Read())
                {
                    if(txtPWD.Text != myReader["pwd"].ToString())
                    {
                        MessageBox.Show("password 오류");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("id확인");
                    return;
                }
                FrmMDImain m = new FrmMDImain();
                m.Show();
                this.Hide();
                Log.WriteLine("FrmLogin", "[로그인 :" + txtID.Text + "]");
            }
            catch(Exception e1)
            {
                Log.WriteLine("FrmLogin", e1.ToString());
                Log.WriteLine("FrmLogin", sql);
                MessageBox.Show("FrmLogin", "로그인 오류" + sql);
            }
        }
        private void txtPWD_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
