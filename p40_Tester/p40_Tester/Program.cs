using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p40_Tester
{
    class Tester
    {
        private int m = 88, n = 99;
        /*
        Tester() 생성자(method)
        {
            this.m = 0;
            this.n = 0;
        }
        */
        Tester(int m = 0, int n = 0) //null일경우 0으로 대입
        {
            this.m = m;
            this.n = n;
        }
        static int Sum(int i = 0, int j = 0) //매개변수가 없으면 0 으로 대입
        {
            return i + j;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(j:7));
            Console.WriteLine(Sum());

            Tester t1 = new Tester();
            Console.WriteLine($"m={t1.m}, n={t1.n}");

            Tester t2 = new Tester(1, 2);
            Console.WriteLine($"m={t2.m}, n{t2.n}");
        }
    }/*
    namespace Test
    {
        class Tester
        {
            static void Main(string[] args)
            {
                Console.WriteLine(Minus(1, 2));
                Console.WriteLine(Minus(1));
                Console.WriteLine(Minus(i: 8, j: 9));
                Console.WriteLine(Minus(j: 8, i: 9));
                Console.WriteLine(Minus());
            }
            static int Minus(int i = 0, int j = 0)
            {
                return i - j;
            }
        }
    }*/
}
