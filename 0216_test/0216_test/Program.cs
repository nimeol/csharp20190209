using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0216_test
{
    delegate void MyDelegate(int i);

    class Eventpublisher
    {
        public event MyDelegate DoEvent;
        public void Do(int num)
        {
            if (num % 2 == 0) DoEvent(num);
        }
    }
    class Eventsub
    {
        public static void Main()
        {
            Eventpublisher p = new Eventpublisher();
            p.DoEvent += new MyDelegate(Caller);
            int[] iArr = Array.ConvertAll(
                (Console.ReadLine()).Split(','),
                i => int.Parse(i));
            foreach(int i in iArr)
            {
                p.Do(i);
            }
        }
        static void Caller(int num)
        {
            Console.WriteLine($"{num} : 짝");
        }

    }
    
}