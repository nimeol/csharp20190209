using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p90_swap
{
    class Program
    {
        static void swap(ref int a,ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            //stack frame 할당 stack 메모리는 임시 메모리 끝나면 사라진다
            Console.WriteLine($"a={a}, b= {b}");
            swap(ref a, ref b); //주소값을 바꿈, 초기화가 반드시 필요
            //swap(out a, out b);//주소로 바뀜, 초기화가 안되어있을 경우
            Console.WriteLine($"a={a}, b= {b}");
        }
    }
}
