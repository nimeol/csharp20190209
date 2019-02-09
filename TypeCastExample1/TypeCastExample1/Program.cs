using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TypeCastExample1
{
    class TypeCastExample1
    {
        static void Main(string[] args)
        {

            int iSize = sizeof(int);
            Console.WriteLine("int형 바이트 길이 : {0}", iSize);
            
            Type myType1 = typeof(int);
            Console.WriteLine("typeof(int) : {0}", myType1);
            
            int i = 10;
            Type mytype2 = i.GetType();
            Console.WriteLine("i.Getype() : {0}", mytype2);
            
            int j = 99;
            Console.WriteLine("size ofj : {0}", Marshal.SizeOf(j) ); //변수의 길이 구할수 있다.
            

        }
    }
}
