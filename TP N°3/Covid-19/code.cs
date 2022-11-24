using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Media;

namespace coivd19
{
    public class Program 
    {
        public static void Main()
        {
          Random r= new Random ();
          var edad = r.Next(0,86);

          if(edad >= 62) {
            Console.WriteLine("                                       ");
            Console.WriteLine("           PACIENTE DE RIESGO          ");
            Console.WriteLine("              DE COVID-19              ");
            Console.WriteLine("           Edad: " + edad + ".         ");
            Console.WriteLine("                                       ");
            Console.ReadKey();
          } else {
            Console.WriteLine("                                       ");
            Console.WriteLine("         PACIENTE FUERA DE RIESGO      ");
            Console.WriteLine("            PERO DEBE CUIDARSE         ");
            Console.WriteLine("              Edad: " + edad + " años. ");
            Console.WriteLine("                                       ");
            Console.ReadKey();
          }
        }
    }
}
