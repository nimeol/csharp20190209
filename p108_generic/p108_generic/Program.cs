using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericArray
{

    class Stack1
    {
        int top = 0;
        int[] ar = new int[10];
        public void Push(int obj)
        {
            ar[top] = obj;
            top++;
        }
        public int Pop()
        {
            top--;
            return ar[top];
        }
        class Stack2
        {
            int top = 0;
            string[] ar = new string[10];
            public void Push(string obj)
            {
                ar[top] = obj;
                top++;
            }
            public string Pop()
            {
                top--;
                return ar[top];
            }
            class stackTest
            {
                static void Main()
                {
                    Stack1 s1 = new Stack1();
                    s1.Push(1);
                    Stack2.Push(2);
                    s1.Push(3);
                    Console.WriteLine(s1.Pop());
                    Console.WriteLine(s1.Pop());
                    Console.WriteLine(s1.Pop());

                    Stack2 s2 = new Stack2();
                    s2.Push("K");
                    s2.Push("대");
                    s2.Push("서");
                    Console.WriteLine(s2.Pop());
                    Console.WriteLine(s2.Pop());
                    Console.WriteLine(s2.Pop());
                }
            }
        }
    }

    /*예제1
    class MyArray<T>
    {
        private T[] onj;
        public MyArray(int size)
        {
            onj = new T[size];
        }
        public void SetElement(int index, T value)
        {
            onj[index] = value;
        }
        public T GetElement(int index, T value)
        {
            return onj[index];
        }
        public void PrintElements()
        {
            foreach(T o in onj) { Console.WriteLine(o); }
        }
    }
    class MainApp
    {
        public static void Main(string[] args)
        {
            MyArray<string> array = new MyArray<string>(4);
            array.SetElement(0, "java");
            array.SetElement(1,"community");
            array.SetElement(2, "programming.co.kr");
            array.SetElement(3, "oracle");
            array.PrintElements();
        }
    }
    */
}




/*
class SumTest<T>//일반화 클래스
{
    public T Sum(T i, T j)
    {
        return (dynamic)i + (dynamic)j;
        //dynamic은 컴파일 시점에 형식 검사를 무시되며, 런타임시 확인된다.
    }
}
class SumMain
{
    public static void Main()
    {
        SumTest<int> s1 = new SumTest<int>();//원하는 타입 기술
        Console.WriteLine($"합 : {1}+ {2} = {s1.Sum(1, 2)}");

        SumTest<double> s2 = new SumTest<double>();
        Console.WriteLine("실수의 합 : {0:f} + {1:f} = {2:f}",1.0,2.0,s2.Sum(1.5, 2.5));
        Console.WriteLine($"실수의 합 : {1.5} + {2.5} = {s2.Sum(1.5, 2.5)}");
    }
}*/