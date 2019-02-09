using System; //system namespce를 사용한다.

namespace Helloworld
{
    class Program
    {
        int i; //class member(멤버), 필드, 인스턴스 변수
        static int j;//멤버, 변수, 클래스 변수
                     //static - new 연산자를 안붙이고 사용가능, 공유 변수 
        static void Main(string[] args)//MAIN - 시작점, 전역변수, 
            //void - return 이없다.
            //멤버, 메소드
            //class - 구조 설계 , 객체 - instance 실물(구체화 된것)
        {
            string name = "최동환";
            int k = 99;
            Console.WriteLine($"hello {name}"); //$사용, system : namespace BCL - 분류(소속)
            Console.WriteLine("hello" + name); 
            Console.WriteLine("hello{0}{1}", name, k); //{0} <- name, {1} <- k
        }
    }
}
