using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    namespace WindowsFormsApp1
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                MessageBox.Show("hello");
            }
        }
        class EventPublisher
        {
            //public delegate void MyEventHandler();
            public event EventHandler MyEvent;
        public void Do()
        {
            //if (MyEvent != null) { MyEvent(); //이벤트 발생 } 아래문장과 같은 의미
            //MyEvent?.Invoke();
            if (MyEvent != null)
            {
                MyEvent(null, null);
            }
        }


        }
        class Subscriber
        {
            static void Main(string[] args)
            {
                EventPublisher p = new EventPublisher();
                p.MyEvent += new EventHandler(doAction);
                p.Do();
            }
            static void doAction(object sender, EventArgs e)
            {
                Console.WriteLine("MyEvent 이벤트 발생");
            }
        }

    }
