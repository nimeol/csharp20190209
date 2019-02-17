/*using System; 예제 1
using System.Threading;
public class ThreadTest
{
    public void FirstWork()
    {
        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(1); //밀리세컨드 단위
            Console.Write("F{0} ", i);
        }
    }
    public void SecondWork()
    {
        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(1);
            Console.Write("S{0} ", i);
        }
    }
    [MTAThread]
    public static void Main()
    {
        ThreadTest t = new ThreadTest();
        //Thread는 생성자에 ThreadStart형 Delegate를 인자로 받는다.
        Thread first = new Thread(t.FirstWork);
        Thread second = new Thread(new ThreadStart(t.SecondWork));
        first.Priority = ThreadPriority.Lowest;//우선순위부여
        second.Priority = ThreadPriority.Highest;
        first.Start(); second.Start();
    }
}*/
using System;//6-2
using System.Threading;
public class ThreadTest2
{
    public bool sleep = false;
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
                Thread.CurrentThread.Suspend();
            }
        }
    }
    public static void Main()
    {
        ThreadTest2 t = new ThreadTest2();
        Thread first = new Thread(new ThreadStart(t.FirstWork));
        first.Start();
        while (t.sleep == false) { }//hold
        Console.WriteLine("first를 깨웁니다...2초후 깨어 납니다.");
        Thread.Sleep(2000);
        first.Resume();
    }
}