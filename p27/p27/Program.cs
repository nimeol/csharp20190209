using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p27
{
    enum Day1//열거형 = int형 상속
    {
        monday,thesday, wednesday, thursday, friday, saturday, sunday
    }
    enum Day2 : byte //byte형 상속
    {
        monday = 11, thesday, sednesday, thursday, friday, saturday, sunday = monday +100
    }//숫자 지정 가능

    public class Program
    {
        static void Main()
        {
            Day1 whatDay = Day1.sunday;
            Console.WriteLine("{0}", whatDay);
            Console.WriteLine("{0}", (int)whatDay);

            whatDay = (Day1)6; //6을day1 타입으로 출력
            Console.WriteLine("{0}", whatDay);

            Day2 whatDay2 = Day2.monday;
            Console.WriteLine("{0}", whatDay2);
            Console.WriteLine("{0}", (byte)whatDay2);

            whatDay2 = (Day2)111;
            Console.WriteLine("{0}", whatDay2);

        }
    }
}
