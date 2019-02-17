﻿using System;
using System.Windows.Forms;

class Programs : Form
{
    class Program : Form
    {
        static void Main(string[] args)
        {
            Program form = new Program();
            form.Click += new EventHandler(
                (sender, eventArgs) =>
                {
                    Console.WriteLine("폼클릭 이벤트..");
                    Application.Exit();
                });
            Console.WriteLine("윈도우 시작");
            Application.Run(form);
            Console.WriteLine("윈도우 종료");
        }
    }

    /*
    static void Main(string[] args)
    {
        Programs form = new Programs();
        form.Click += new EventHandler(form.Form_Click);
        Console.WriteLine("윈도우 시작");
        Application.Run(form);
        Console.WriteLine("윈도우 종료");
    }

    void Form_Click(object sender, EventArgs e)
    {
        Console.WriteLine("폼클릭");
        Application.Exit();// Application.Run 종료
    }*/
}
