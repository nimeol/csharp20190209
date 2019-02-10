using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p69_console8
{
    class MyBaseClass
    {
        public MyBaseClass()
        {
            Console.WriteLine
                (">>>MyBaseClass()");
        }
        public MyBaseClass(int i)
        {
            Console.WriteLine(">>>MyBaseClass(int i)");
        }
    }
    class Myclass:MyBaseClass
    {
        public Myclass()
        {
            Console.WriteLine(">>>Myclass()");//부모로감
        }
        public Myclass(int i):base(i)
        {
            //////base(부모) 먼저 실행
            Console.WriteLine(">>>MyClass(int i)");
        }
        public Myclass(int i, int j)
        {
            ////////부모의 기본으로
            Console.WriteLine(">>>MyClass(int i, int j");
        }
        public Myclass(int i, int j, int k)  :base(i)
        {
            /////base(i)로 이동
            Console.WriteLine(">>>MyClass(int i, int j, int k");
        }
        public Myclass(int i, int j, int k, int l) : this(i, j) //자기자신의 생성자 2개짜리로 이동
        {
            Console.WriteLine(">>>MyClass(int i, int j int k, int l");
        }
    }
    class Test
    {
        static void Main()
        {
            Myclass m1 = new Myclass();
            Myclass m2 = new Myclass(1);
            Myclass m3 = new Myclass(1, 2);
            Myclass m4 = new Myclass(1, 2, 3);
            Myclass m5 = new Myclass(1, 2, 3, 4);
        }
    }
}
