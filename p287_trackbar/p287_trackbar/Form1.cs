using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p287_trackbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trb1_Scroll(object sender, EventArgs e)
        {
            trb1.Maximum = 100;
            progressBar1.Maximum = 100;
            progressBar1.Value = trb1.Value;

        }

        private void binStart_Click(object sender, EventArgs e)
        {/*
            string a = null;
            a = txtLoopCount.Text;
            if (a is null)
            {
                Console.WriteLine("1");
            }*/

            Console.WriteLine("1");
            /*
            progressBar1.Maximum = int.Parse(txtLoopCount.Text);
            progressBar1.Step = int.Parse(txtLoopCount.Text) / 100;
            for (int i = 0; i <= int.Parse(txtLoopCount.Text); i++){
                progressBar1.Value = i;
            }*/

        }
    }
}
