using System;
using System.Threading;

public class ThreadTest3
{
    public string lockString = "hello";
    private object obj = new object();
    private static Mutex mutex = new Mutex();

    public void Print(string rank)
    {
        //lock(obj)
        //Monitor.Enter(obj);
        mutex.WaitOne();
        {
            for(int i = 0; i<5;i++)
            {
                for(int j = 0; j<5;j++)
                {
                    Thread.Sleep(100);
                    Console.Write(",");
                }
                Console.WriteLine($"{rank}{lockString}");
            }
            //Monitor.Exit(obj);
            
        }
        mutex.ReleaseMutex();
    }
    public void FirstWork() { Print("F"); }
    public void SecondWork() { Print("S"); }
}
class TestMaiin
{
    [MTAThread]
    public static void Main()
    {
        ThreadTest3 t = new ThreadTest3();
        Thread first = new Thread(new ThreadStart(t.FirstWork));
        Thread Second = new Thread(new ThreadStart(t.SecondWork));

        first.Start();
        Second.Start();
    }
}