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
          string nombre;
          double metros = 0;
          double centimetros = 0;

          Console.Write("Ingrese el nombre de la persona: ");
          nombre = Console.ReadLine();
          Console.Clear();
          Console.Write("Ingrese la altura de la persona: ");
          centimetros = double.Parse(Console.ReadLine());
          Console.Clear();
          metros = centimetros / 100;
          Console.WriteLine("Nombre: " + nombre);
          Console.WriteLine("Altura: " + metros + " metros");
          Console.ReadKey();
        }
    }
}