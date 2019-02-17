using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace p218_interrupt
{
    public class ThreadTest2
    {
        bool sleep = false;

        //차단기가 내려간 상태
        static AutoResetEvent autoEvent = new AutoResetEvent(false);
        public void FirstWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("F{0}", i);
                if (i == 5)
                {
                    sleep = true;
                    Console.WriteLine("");
                    Console.WriteLine("first 쉼...");
                    autoEvent.WaitOne();
                }
            }
        }
        public static void Main()
        {
            ThreadTest2 t = new ThreadTest2();
            Thread first = new Thread(new ThreadStart(t.FirstWork));
            first.Start();
            while (t.sleep == false) { }
            Console.WriteLine("first를 깨웁니다...2초후 깨어 납니다.");
            Thread.Sleep(2000);
            autoEvent.Set();
        }
    }

    /* p218
    class Program
    {
        public static Thread sleeperThread;

        public static void Main(string[] args)
        {
            sleeperThread = new Thread(new ThreadStart(ThreadToSleep));
            sleeperThread.Start();
            sleeperThread.Interrupt();
        }
        private static void ThreadToSleep()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("[Sleeper :" + i++ + "]");
                if(i==9)
                {
                    try
                    {
                        Console.WriteLine("9초");
                        Thread.Sleep(1000);//error 발생
                    }
                    catch(ThreadInterruptedException e)
                    {
                        Console.WriteLine("ThreadInterruptedException");
                        Environment.Exit(0);//종료
                    }
                }
            }
        }
    }
    */
}
