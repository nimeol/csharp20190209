using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p168_lambda
{
    class Program
    {
        delegate int calc(int i, int j);
        
        static void Main(string[] args)
        {
            calc c = new calc(MySum);
            Console.WriteLine("1+2={0}", c(1, 2));
            calc c1 = delegate (int i, int j)
            {
                return i + j;
            };
            Console.WriteLine("3+4={0}", c1(3, 4));
            calc c2 = (int a, int b) => a + b;
            Console.WriteLine("3+4={0}", c2(3, 4));
            calc c3 = (a, b) => a + b;//int 제거 calc 에서 int 가 명시
            Console.WriteLine("3+4={0}", c2(3, 4));
            Func<int, int, int> c4 = (a, b) => a + b;
        }
        static int MySum(int i, int j)
        {
            return i + j;
        }
    }
}
