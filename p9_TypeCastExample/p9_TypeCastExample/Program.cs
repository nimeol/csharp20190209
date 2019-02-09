using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace p9_TypeCastExample
{
    class TypeCastExample
    {
        static void Main(string[] args)
        {

            int iSize = sizeof(int);
            Console.WriteLine("int형 바이트 길이 : {0}", iSize);

            Type myType1 = typeof(int);
            Console.WriteLine("typeof(int) : {0}", myType1);

            int i = 10;
            Type mytype2 = i.GetType();
            Console.WriteLine("i.Getype() : {0}", mytype2);

            int j = 99;
            Console.WriteLine("size ofj : {0}", Marshal.SizeOf(j)); //변수의 길이 구할수 있다.


        }
    }
    /*
    public static void Main() //p9
    {
        short a = 10; //system.int16
        int b = a; //system.int32
        //CTS - common type system
        int c = 50000;
        try
        {
            short d = checked((short)c);//casting 연산 (형변환) -오버플루우
            Console.WriteLine("Short : {0}", d);
            Console.WriteLine($"Short : {d}");
            Console.WriteLine(b);
            Console.WriteLine($"test : {a},{b}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
        }
    }*/
    /* //상속
    static void Main()
    {
        Emp e = new Emp();
        Programmer p = new Programmer();
        Emp e1 = p as Emp;//왼쪽 것을 오른족으로 형변환, 상위타입으로 형변환은 가능, 변환이 안되면 null
        Emp e2 = (Emp)p;//컴파일도중 죽어버림.

    }
    static void Main()
    {
        Programmer p = new Programmer();
        if(p is Emp)
        {
            Console.WriteLine("test1");
        }
        else
        {
            Console.WriteLine("test2");
        }
        if (p is Emp)
        {
            Console.WriteLine("test1");
        }
        else
        {
            Console.WriteLine("test2");
        }
    }*/
}
