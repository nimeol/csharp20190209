﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p29_emptest
{
    struct Emp
    {
        public int id;
        public string name;
    }
    class empTest
    {
        public static void Main()
        {
            Emp e;
            e.id = 1;
            e.name = "1길동";
            Console.WriteLine("사번: {0}", e.id);
            Console.WriteLine($"이름: {e.name}");

            Emp e1 = new Emp();
            e1.id = 2;
            e1.name = "2길동";
            Console.WriteLine("사번:{0}", e1.id);
            Console.WriteLine($"이름:{e1.name}");
        }
    }
}