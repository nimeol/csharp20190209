using System;

namespace p42_Property
{
    class Emp :{
        // private int empno; 생략가능
        public int Empno { get; set; }  //자동구현속성 Property
        public override string ToString() // override 재정의
        {
            return $"[사원 : {Empno}]";
        } //없어져도 오류가 안남. 없으면 object(root, 부모)로 감
        /*
        class Emp : Object //object(root)에 상속
    {
        //internal int empno; //동일한 어셈블리 안에서 가능, empno - 객체 상태
        //private int empno; //instance 변수(객체 변수)
        /*public void Setempno(int empno) //setter
        {
            this.empno = empno;
        }//바로 다이렉트로 empno값을 넣으면 객체손상이 우려되므로 한 단계 거친다.
        public int Getempno() //getter, static 추가시 객체변수 선언해야함(new)
        {
            return this.empno;//this 생략가능 지역변수이기 때문에 가능
        }8/
        /*
        public override string ToString() // override 재정의
        {
            return $"[사원 : {empno}]";
        } //없어져도 오류가 안남. 없으면 object(root, 부모)로 감
    }*/
        /*
        public int Empno  //일반속성, property
        {
            get
            {
                return this.empno;
            }
            set
            {
                this.empno = value;
            }
        }*/ //public int Empno { get; set; } 대체가능
    }
    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();//e = 객체참조 변수(객체)
            e.Empno = 999;//객체 상태 손상이 우려
            //e.Setempno(999);
            //Console.WriteLine(e.Getempno());
            Console.WriteLine(e.Empno = 999);//변수처럼 사용가능
            Console.WriteLine(e);
            Console.WriteLine(e.ToString()); // e = e.ToString() 같은의미

        }
    }
}
