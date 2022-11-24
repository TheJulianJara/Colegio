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
          double calificacion_final;
          string apellido_estudiante;
          string asignatura;
          string nombre;
          double edad;

          Console.Write("Ingrese el nombre del estudiante: ");
          nombre = Console.ReadLine();
          Console.Clear();
          Console.Write("Ingresar apellido del estudiante: ");
          apellido_estudiante = Console.ReadLine();
          Console.Clear();
          Console.Write("Ingrese la edad del estudiante: ");
          edad = double.Parse(Console.ReadLine());
          Console.Clear();
          Console.Write("Ingresar asignatura: ");
          asignatura = Console.ReadLine();
          Console.Clear();
          Console.Write("Ingresar calificación final: ");
          calificacion_final = double.Parse(Console.ReadLine());
          Console.Clear();

          if (calificacion_final >= 6)
            {
              Console.WriteLine("APROBADO");
            } else {
                      Console.WriteLine("RECUPERAR EN DICIEMBRE");
                    }
                  Console.ReadKey();
        }
    }
}