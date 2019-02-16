using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 델리게이트 - 함수 포인터와 유사
 */
namespace p147_delegate
{
    public class Delegate1
    {
        private delegate int OnjSum(int i, int j); //1. 선언
        public static void Main(string[] args)
        {
            //Action<int, int> myMethod = new Action<int, int>(Delegate1.Sum);//new Action<int, int> 생략가능
            Action<int, int> myMethod = Sum;
            //2. 생성, 메소드이름을 인자로
            //OnjSum myMethod = new OnjSum(Sum); //2. 생성
            //OnjSum myMethod = Sum; //2. 생성, 
            //Console.WriteLine("두수 합 : {0}", myMethod(10, 30));
            myMethod(10, 30);
            myMethod.Invoke(10, 30);
            //invoke 생략가능
        }
        static void Sum(int i, int j)
        {
            System.Console.WriteLine(i + j);
        }
    }
}
//값을 return x - 'action' , 값 return - func