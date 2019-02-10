using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력 숫자:");
            string r = Console.ReadLine();
            int j = int.Parse(r);
            int sum = 0;

            for (int i = 1;i<=j;i++ )
            {
                if(j%2==0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"{j}가지의 짝수합은 {sum}");
        }
    }

    /*
    namespace EnumTest
    {
        class Program
        {
            static void Main(string[] args)
            {
                int? i = 8 >> 5;
                Console.WriteLine(i);

                int? j = i > 0 ? i : null;
                if (!j.HasValue) Console.WriteLine("j is null");
                else Console.WriteLine(j);

                var a = j ?? int.MinValue;
                Console.WriteLine(a.ToString());

            }
        }
    }
    */
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("출력을 원하는 구구단 단수:");
            string r = Console.ReadLine();
            int j = int.Parse(r);
            int sum = 0;
            Console.WriteLine($"{j}단입니다");

            for (int k = 1;k<=j;k++ )
            {

                for (int i = 1; i <= 9; i++)
                {
                    sum = k * i;
                    Console.WriteLine($"{k} * {i} = {sum}");
                }
            }

        }
    }
    */
}
