using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalAnd
{
    
    public class Bitoper
    {
        public static void Main(string[]args)
        {
            int i = 10;
            int j = 20;
            int a;
            a = i & j;
            i = i >> 3;
            j = i << 3;
            Console.WriteLine("a={0},i={1},j{2}", a, i, j);
            Console.ReadLine();
        }
}
    /*
    class LogicalAnd
    {
        static void Main()
        {
            Console.WriteLine("정상적인 AND:");
            if (Method1() & Method2()) //비트연산
                Console.WriteLine("both methods return ture");
            else
                Console.WriteLine("둘중 하나의 메소드는 fasle");
            Console.WriteLine("\n short-circuit AND :");
            if (Method1() && Method2()) //논리연산, short-circuit AND, method1이 거짓일 경우 method2를 호출하지않음.
                Console.WriteLine("both methods return true");
            else
                Console.WriteLine("둘중 하나의 메소드는 false");
            
            Console.WriteLine("0x{0:x}", 0xf8 & 0x3f);//???
        }
        static bool Method1 ()
        {
            Console.WriteLine("메소드1");
            return false;
        }
        static bool Method2()
        {
            Console.WriteLine("메소드2");
            return true;
        }
    }*/
    /*
    class Program
    {
        static void Main(string[] args)
        {
            //int? a = null; ? - null을 허용함. ? 없을시 오류
            object a = null;
            object b = "abc";
            // ??-null이 아닌것 출력, 둘다 0일경우 앞에것 출력

        }
    }
    */
}
