using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
          int i = 0;
          while(i < 10000) {
            i++;
            Console.WriteLine("CONTAR=" + " " + i);
          }
          Console.ReadKey();
        }
    }
}