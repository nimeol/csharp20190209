using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p271_message
{
    class OnjMessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            if(m.Msg == 0x201)
            {
                Console.WriteLine("마우스 클릭");
                return true;
            }
        }
        return false;
    }

    class Program : Form
    {
        static void Main(string[] args)
        {
            Application.AddMessageFilter(new OnjMessageFilter());
            Program p = new Program();
            p.Click += new EventHandler(p.Form_Click);
            Application.Run(p);
        }
        void Form_Click(object sender, EventArgs e)
        {
            Console.WriteLine("마우스 클릭 이벤트");
            Application.Exit();
        }
    }
}
