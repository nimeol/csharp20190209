using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace p117_queue
{
    public class SamplesQueue
    {
        public static void Main()
        {
            Queue myQ = new Queue();
            myQ.Enqueue("H");
            myQ.Enqueue("W");
            myQ.Enqueue("!");

            Console.WriteLine("myQ");
            Console.WriteLine($"\tcount : {myQ.Count}");
            Console.WriteLine("\tValues");
            PrintValues(myQ);
        }
        public static void PrintValues(IEnumerable mycollection)
        {
            foreach (Object obj in mycollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}
