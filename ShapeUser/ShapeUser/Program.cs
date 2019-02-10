using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace ShapeUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(1.0F);
            Console.WriteLine("Area of Circle(1.0) is {0}", c.Area());
        }
    }
}
//참조추가 - using 추가 - 함수 사용