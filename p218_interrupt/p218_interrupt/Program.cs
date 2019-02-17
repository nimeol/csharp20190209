using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace p218_interrupt
{
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
}
