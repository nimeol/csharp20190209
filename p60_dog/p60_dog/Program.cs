using System;

namespace p60_dog
{
    public abstract class Dog //:Object 생략, 추상 클래스, 틀 정의
    {
        public string name { get; set; }
        public abstract void jitda();
        /*
        public virtual void jitda() //부모 재정의
        {
            Console.WriteLine(name + "가 짖다.");
        }*/
    }
    public class Pudle : Dog
    {
        public override void jitda()//method 재정의
        {
            Console.WriteLine(name + "푸들푸들~");
        }
        public void work() { Console.WriteLine(name + "가 일한다."); }
    }
    public class Jindo : Dog
    {
        public override void jitda()
        {
            Console.WriteLine(name + "진도진도~");
        }
        public void run() { Console.WriteLine(name + "가 달린다."); }
    }
    class DogManger
    {
        static void Main()
        {

            Dog p = new Pudle();
            p.name = "푸들이";
            p.jitda();
            ((Pudle)p).work();

            Dog j = new Jindo();
            j.name = "진도이";
            j.jitda();
            ((Jindo)j).run();

            //같은 Dog 변수에서 같은 jitda를 사용하였으나 다른결과가 나온다 - 다형성
            /*
            Pudle p = new Pudle();
            p.name = "푸들이";
            p.jitda();
            p.work();

            Object m = new Pudle(); //p 지역변수 stack , 변수 선언은 부모 class도 가능
            ((Dog)m).name = "푸들이";
            ((Dog)m).jitda();
            ((Pudle)m).work();//형변환

            Jindo j = new Jindo();
            j.name = "진도이";
            j.jitda();
            j.run();*/
        }
    }
}
