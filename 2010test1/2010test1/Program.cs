using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(j:10, i:20));//명명 안하면 순서대로
            Console.WriteLine(Sum(j:10));
            Console.WriteLine(Sum(20));
        }
        static int Sum(int i=0, int j=0)//method, 인수값이 안들어오면 0으로 계산
        {
            return i * j;
        }
        /*
        static int Sum(int i)//method
        {
            return i + 0;
        }
        과거 인수값이 안들어올경우를 생각해 같은 함수를 여러개 만들었으나,
        Sum(int i=0, int j=0)로 사용
        */
    }
}
