using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace Recarga
{

    public static class Program 
    {
        public static void Main() 
        {

            double recarga;
            double saldoAnt;
            double saldoFinal;
            double nroTarjeta;
            DateTime datetime = DateTime.Now;
    
        Console.Write("Ingrese los últimos 4 digitos de la tarjeta: ");
        nroTarjeta = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el saldo anterior: $");
        saldoAnt = double.Parse(Console.ReadLine());
        Console.Write("Ingresá el saldo a recargar: $");
        recarga = double.Parse(Console.ReadLine());
        Console.Clear();

        saldoFinal = saldoAnt + recarga;

        Console.WriteLine("              SUBE - LANÚS ");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("RECARGA $" + recarga);
        Console.WriteLine("TICKET N° : 19812         ESTACION: LANÚS");
        Console.WriteLine("SALDO ANT: $" + saldoAnt + "          SALDO ACT: $" + saldoFinal);
        Console.WriteLine("TARJETA SUBE N°: XXXX XXXX XXXX " + nroTarjeta);
        Console.WriteLine("----------------------------------------");
        
        Console.ReadKey();
        }
    }
}