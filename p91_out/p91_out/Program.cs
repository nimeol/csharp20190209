using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p91_out
{
    class OnjOutTest
    {
        static void FillArray1(out int[] arr)
        {
            arr = new int[3] { 5, 4, 1 };
        }
        static void FillArray2(ref int[] arr)
        {
            if(arr == null)
            {
                arr = new int[3];
                arr[0] = 1111;
                arr[1] = 2222;
            }
        }
        static void Main()
        {
            int[] onjArray;
            FillArray1(out onjArray);//주소로 받는다
            Console.WriteLine("배열(out parameter :");
            for(int i = 0; i<onjArray.Length;i++)
            {
                Console.Write(onjArray[i] + " ");
            }
            Console.WriteLine("press any key to next1");
            Console.ReadKey();
            FillArray2(ref onjArray);

            Console.WriteLine("배열(ref parameter) : ");
            for (int i = 0; i < onjArray.Length; i++)
            { Console.Write(onjArray[i] + " "); }
            Console.WriteLine("press any key to next2");
            Console.ReadKey();
            FillArray2(ref onjArray);
        }

    }
}
