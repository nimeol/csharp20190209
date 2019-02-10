using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p83_finalize
{
    class Garbage : IDisposable
    {
        private bool isDispose = false;
        private string name;

        public Garbage(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}객체 생성됨");
        }
        ~Garbage()
        {
            if (!isDispose) { Dispose(); }
        }
        public void Dispose()
        {
            isDispose = true;//리소스 해제
            Console.WriteLine($"{name}객체의 리소스 해제 ok");
            GC.SuppressFinalize(this);
        }
    }

    class GarbageTest1
    {
        static void Main()
        {
            Garbage g1 = new Garbage("1번객체");
            Garbage g2 = new Garbage("2번객체");
            Garbage g3 = new Garbage("3번객체");
            Garbage g4 = new Garbage("4번객체");
            g1.Dispose();
            GC.SuppressFinalize(g2);
        }
    }
}
