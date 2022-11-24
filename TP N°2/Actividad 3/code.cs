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

          int pelota;
          int arquero;
          int jugador;

          Console.Write("ejecutar la pelota: ");
          pelota = int.Parse(Console.ReadLine());
          Console.Write("el arquero elige un lugar donde tirarse: ");
          arquero = int.Parse(Console.ReadLine());
          Console.Write("el jugador elige un lugar donde colocar la pelota: ");
          jugador = int.Parse(Console.ReadLine());

          if (pelota > 3) {
            Console.WriteLine("LA PELOTA SE FUE DEVIADA DEL ARCO!!!!");
          } else {
            if (arquero == jugador)
            {
              Console.WriteLine("EL ARQUERO ATAJO EL PENAL!!!!");
            } else {
             Console.WriteLine("GOOOOOOOOOOOOL!!!!");
            }
          }
          Console.ReadKey();
        }
    }
}
// Language: csharp