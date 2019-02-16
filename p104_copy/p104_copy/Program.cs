using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p104_copy
{
    class CreditCard
    {
        public string name;
    }
}

class CreditCard//참조형 regerance
{
    public string name;
}
class Customer :ICloneable // "I" 가붙으면 인터페이스 의미
{
    public int age;
    public CreditCard card;//class형 변수
    public object Clone()//깊은 복사
    {
        Customer c = new Customer();
        c.age = this.age;
        c.card = new CreditCard();
        c.card.name = this.card.name;
        return c;
    }
}

class ArrayTest
{
    static void Main()
    {
        Customer c1 = new Customer();
        c1.age = 20;
        c1.card = new CreditCard();
        c1.card.name = "비씨";
        Customer c2 = (Customer)c1.Clone();
        c2.card.name = "bc";

        Console.WriteLine("c1.card.name = " + c1.card.name);
        Console.WriteLine("c2.card.name = " + c2.card.name);
    }
}




/* 얕은복사
class CreditCard//참조형 regerance
{
    public string name;
}
class Customer
{
    public int age;
    public CreditCard card;//class형 변수
    public object ShallowCopy()
    {
        return this.MemberwiseClone();//this-> Customer
        //얕은복사 
    }
}

class ArrayTest
{
    static void Main()
    {
        Customer c1 = new Customer();
        c1.age = 20;
        c1.card = new CreditCard();
        c1.card.name = "비씨";
        Customer c2 = (Customer)c1.ShallowCopy();
        c2.card.name = "bc";

        Console.WriteLine("c1.card.name = " + c1.card.name);
        Console.WriteLine("c2.card.name = " + c2.card.name);
    }
}*/
