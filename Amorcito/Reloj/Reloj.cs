using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace reloj
{

    public class Program 
    {
        public static void Main()
        {
            DateTime datetime = DateTime.Now;
            Console.WriteLine(datetime);
            Console.ReadKey();
        }
    }
}