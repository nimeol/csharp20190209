using System;

namespace test
{
    class Emp
    {
       public override string//재정의
       ToString()
        {
            return "Emp";
        }
    }
    class Programmer : Emp { }
    //부모 : emp
    class Program
    {
        static void Main()
        {
            Programmer p = new Programmer();
            Emp e = p as Emp;

            if (e != null)
                System.Console.WriteLine(e.ToString());
        }
    }    


    /*
    class test14
    {
        public static void Main()
        {
            Console.WriteLine(default(int));

            int isize = sizeof(int);
            Console.WriteLine($"int : {isize}");
        }
    }*/
    /*
    class Program
    {
        static void Main(string[] args)
            //args 매개변수 : main 함수로 전달값이 있는 경우
            //void : return 값이 없는 경우
            //Main은 하나
            //static : clr에서 객체 생성없이 바로 메인함수 호출
        {
            Console.WriteLine($"hello {args[0]}, {args[1]}");
        }
    }
    */
    /*
    class Program
    {
        static void Main(string[] args)
        {
            short a = 10;
            int b = a;
            int c = 50000;
            try
            {
                int d = checked((short)c);// overflow 검사
            }
            catch(Exception e)
            {
                Console.WriteLine($"예외 : {e.StackTrace}");
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
    */
    /*
    class test11
    {
        public const double PI = 3.14; //지역상수를 정의, 초기값 필수
        public const int MYAGE = 22;
    }

    class Program2
    {
        static void Main(string[] args)
        {
            double radius = 2;
            double area = test11.PI * (radius * radius);
            Console.WriteLine("Area = {0}, Age={1}", area, test11.MYAGE);
            //test11.MYAGE = 20; //오류
            const string name = "홍길동";
            Console.WriteLine("name : " + name);
            //name = "김길동"; //오류
        }
    }*/

}
