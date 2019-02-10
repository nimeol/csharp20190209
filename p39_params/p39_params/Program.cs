using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p39_params
{
    class Program
    {
        private static void OnjSum(string title, params int[] num)//가변길이 매개변수(배열)
        {
            int sum = 0;
            Console.WriteLine($"sum of {title}");
            foreach (int i in num) sum += i;
            Console.WriteLine($"Sum :: {sum}");
        }

        static void Main(string[] args)
        {
            int[] onjArray = new int[] { 1, 2,3,4 };
            OnjSum("하나", 1);
            OnjSum("둘", 1,2);
            OnjSum("셋", 1,2,3);
            OnjSum("배열", onjArray);
        }
    }
}
