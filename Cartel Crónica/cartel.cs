using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Cartel
{

    public static class Program 
    {
        public static void Main() 
        {
           DateTime FechaInicio = Convert.ToDateTime("2022-9-22 00:00:00");
           //DateTime FechaInicio = Convert.ToDateTime("2022-4-10 00:00:00");
           DateTime FechaActual = DateTime.Today;
           TimeSpan DiasRestantes = FechaInicio - FechaActual;
           int dias = DiasRestantes.Days;
           String datetime = DateTime.Now.ToString("HH:mm");
           
          
           
           Console.BackgroundColor = ConsoleColor.Red;
           Console.ForegroundColor = ConsoleColor.White;
        
            
            Console.WriteLine("                                 ");
            Console.WriteLine("  " + datetime + "                Cronica   ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            if(dias <= 1 ){
                Console.WriteLine("         Falta " + dias +" dia             ");
            } if(dias > 1){
                Console.WriteLine("       Faltan " + dias +" dias           ");
            }
            Console.WriteLine("      Para la primavera.         ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.ReadKey();

        }
        
    }
}