using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddrBook
{
    class Log
    {
        public static void WriteLine(string name, string e)
        {
            string filename = @"c:\dotnet\" + name + "_log";
            string logtime = DateTime.Now.ToString();

            FileStream aFile = new FileStream(filename, FileMode.Append, FileAccess.Write);

            StreamWriter awriter = new StreamWriter(aFile, System.Text.Encoding.Default);

            awriter.WriteLine("[" + logtime + "]");
            awriter.WriteLine(e);
            awriter.Flush();
            awriter.Close();
        }
    }
}
