using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace TP1
{

    public static class TP1 
    {
        public static void Main() 
        {
double meses = 0;
double años = 0;
Console.Write("Ingresá la edad de la persona: ");
años = double.Parse(Console.ReadLine());//
meses = años * 12;
Console.Clear();
Console.WriteLine("La persona tiene " + meses + " meses de edad.");
Console.ReadKey();
        }
    }
}