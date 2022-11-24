using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Robot
{

    public static class Robot 
    {
        public static void Main() 
        {
            DateTime FechaNac = new DateTime(2020, 9, 3, 0, 0, 0);
            DateTime fechaNacimiento;
            DateTime fechaActual;
            string nombreRobot = "Wall-e";
            int version = 1;

            fechaNacimiento = FechaNac.Date;
            fechaActual = DateTime.Now;
            var TimeSpan = (fechaActual - fechaNacimiento);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("  //////////////////////  ");
            Console.WriteLine(" ------------------------ ");
            Console.WriteLine("|                        |");
            Console.WriteLine("|     O            O     |");
            Console.WriteLine("|                        |");
            Console.WriteLine("|            &           |");
            Console.WriteLine("|                        |");
            Console.WriteLine("|   °                °   |");
            Console.WriteLine("|    °°°°°°°°°°°°°°°°    |");
            Console.WriteLine(" ------------------------ ");
            Console.WriteLine("             █            ");
            Console.WriteLine("|------------------------|");
            Console.WriteLine("|Mi nombre es " + nombreRobot + "     |");
            Console.WriteLine("|Versión: " + version + "              |");
            Console.WriteLine("|Mi edad es " + (int)TimeSpan.TotalDays + " dia/s    |");
            Console.WriteLine("|Mi edad es " + (int)TimeSpan.TotalDays/365 + " año/s      |");
            Console.WriteLine("|Mi edad es " + (int)TimeSpan.TotalDays/30 + " mes/es    |");
            Console.WriteLine("|Fecha " + fechaActual.ToShortDateString() + "         |");
            Console.WriteLine("|Hora " + fechaActual.ToShortTimeString() + "              |");
            Console.WriteLine("|------------------------|");
            Console.WriteLine("        [[]]   [[]]       ");
            Console.WriteLine("        [[]]   [[]]       ");
            Console.WriteLine("        [[]]   [[]]       ");
            Console.WriteLine("        [[]]   [[]]       ");
            Console.WriteLine("        [[]]   [[]]       ");
            Console.WriteLine("        [[]]   [[]]       ");
            Console.WriteLine("        [[]]   [[]]       ");
            Console.WriteLine("   #########   #########  ");
            Console.WriteLine("   #########   #########  ");
            Console.ReadKey();
        }
    }
}