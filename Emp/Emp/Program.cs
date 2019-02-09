using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//상속
namespace Emp
{
    class Emp
    {
        string name;
        void GotoOffice() { }
    }
    class Programmer : Emp { }
    //programmer 가 emp에게 상속 emp 부모
    //programmer is a emp = 참

    class Emptest
    {
        static void Main()
        {
            Emp e = new Emp();
            Programmer p = new Programmer();
            Emp e1 = p as Emp;//왼쪽 것을 오른족으로 형변환, 상위타입으로 형변환은 가능, 변환이 안되면 null
            Emp e2 = (Emp)p;//컴파일도중 죽어버림.

        }
        /*static void Main()
        {
            Programmer p = new Programmer();
            if(p is Emp)
            {
                Console.WriteLine("test1");
            }
            else
            {
                Console.WriteLine("test2");
            }
            if (p is Emp)
            {
                Console.WriteLine("test1");
            }
            else
            {
                Console.WriteLine("test2");
            }
        }*/
    }
}