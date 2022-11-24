using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Media;

namespace terremoto
{

    public class Program 
    {
        public static void Main()
        {
        Random r= new Random ();
        var parteDecimal = r.NextDouble();
        var parteEntera = r.Next(0,10);
        var magnitud = (parteEntera + parteDecimal);
        
        if(magnitud >= 4.9){
          Console.BackgroundColor = ConsoleColor.Red;
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine("                                       ");
          Console.WriteLine("           PELIGRO TERREMOTO.          ");
          Console.WriteLine("     Magnitud de " + magnitud + ".     ");
          Console.WriteLine("                                       ");
          SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\a\Music\alarma.wav");
          simpleSound.Play();
          Console.ReadKey();
            } else  {
              Console.WriteLine("                                       ");
              Console.WriteLine("          FUERA DE PELIGRO.            ");
              Console.WriteLine("     Magnitud de " + magnitud + ".     ");
              Console.WriteLine("                                       ");
              Console.ReadKey();
            }
        }
    }
}