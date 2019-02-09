using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190209_p16
{
    class Emp
    {
        public string name;
        string Name { get; set; }
        void GotoOffice()
        {
            Console.WriteLine("출근");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            Console.WriteLine(e.name);
            e.name = "홍";
            Console.WriteLine(e.name);

        }
    }
}
