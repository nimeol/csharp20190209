using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p169_lambda
{

    class Program
    {
        //delegate int Sum(int[] arg);
        
        static void Main(string[] args)
        {
            Func<int[], int> sumdeli = (arg) =>
            //func - 값을 반환, action - 값을 반환x
            //Sum sumdeli = (arg) =>
            {
                int mySum = 0;
                foreach (int i in arg)
                    mySum += i;
                return mySum;
            };
            int sum = sumdeli(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("1+2+3+4+5 = " + sum);
        }
    }
   /*식람다
    class Program
    {
        static bool MyWhere(int n) { return n % 2 == 1; }
        static void Main(string[] args)
        {
            int[] scores = { 30, 54, 64, 54, 99, 11 };
            int oddScodreSum = scores.Where(n => n % 2 == 1).Sum();
            Console.WriteLine("{0} 홀수의 합", oddScodreSum);

            int oddCount = scores.Where(n => n % 2 == 1).Count();
            Console.WriteLine("{0} 홀수의 개수", oddCount);

            int Count = scores.Where(n => n > 50).Count();
            Console.WriteLine("{0} 50 초과 개수", oddCount);

            int Max = scores.Max();
            Console.WriteLine("{0} 배열의 최대값", Max);

            int Min = scores.Min();
            Console.WriteLine("{0} 배열의 최소값", Min);

        }
    }*/
}
