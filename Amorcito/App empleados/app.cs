using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace appsueldo
{

    public class Program 
    {
        public static void Main()
        {
            string nombre;
            int edad;
            double sueldoAnterior;
            double aumento;
            double sueldoActual;
            DateTime datetime = DateTime.Now;
            
            Console.Write("Ingresá el nombre del empleado: ");
            nombre = Console.ReadLine();                   
            Console.Write("Ingresá la edad: ");
            edad = Int32.Parse(Console.ReadLine());
            Console.Write("Ingresá tu sueldo anterior: $");
            sueldoAnterior = Int32.Parse(Console.ReadLine());
            Console.Write("Ingresá el aumento: $");
            aumento = Int32.Parse(Console.ReadLine());
			Console.Clear();
            
                        //      GENERADOR DE COMPROBANTE       //
            
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("         Comprobante de cobro                    ");
            Console.WriteLine(datetime);
            Console.WriteLine("  Nombre: " + nombre);
            Console.WriteLine("  Último sueldo: $" + sueldoAnterior);
            sueldoActual = sueldoAnterior + aumento;
            Console.WriteLine("  Tu sueldo actual sería de $" + sueldoActual);
            Console.WriteLine("-------------------------------------");
            Console.ReadKey();
    
            
        }
    }            
}