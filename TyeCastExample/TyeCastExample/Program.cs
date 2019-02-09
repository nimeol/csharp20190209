using System;

class TypeCastExample1
{
    public static void Main()
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
    }
}