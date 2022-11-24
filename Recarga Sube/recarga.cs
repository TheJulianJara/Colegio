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

            int recarga;
            int saldoAnt;
            int saldoFinal;
            int nroTarjeta;
            DateTime datetime = DateTime.Now;
    
        Console.Write("Obteniendo número de tarjeta.");
        Thread.Sleep(500);
        Console.Clear();
        Console.Write("Obteniendo número de tarjeta..");
        Thread.Sleep(500);
        Console.Clear();
        Console.Write("Obteniendo número de tarjeta...");
        Thread.Sleep(500);
        Console.Clear();
        Console.Write("Obteniendo número de tarjeta.");
        Thread.Sleep(500);
        Console.Clear();
        Console.Write("Obteniendo número de tarjeta..");
        Thread.Sleep(500);
        Console.Clear();
        Console.Write("Obteniendo número de tarjeta...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.Write("Ingresá el saldo a recargar: $");
        recarga = Console.Read();
        Console.Clear();
        Console.Write("Por favor espere.");
        Thread.Sleep(500);
        Console.Clear();
        Console.Write("Por favor espere..");
        Thread.Sleep(500);
        Console.Clear();
        Console.Write("Por favor espere...");
        Thread.Sleep(1000);
        Console.Clear();

        Random r= new Random ();
        saldoAnt = (r.Next (0, 201));
        saldoFinal = saldoAnt + recarga;
        nroTarjeta = (r.Next (100, 1000));
        Console.WriteLine("       SUBE - RETIRO ");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("RECARGA $" + recarga);
        Console.WriteLine(datetime + " PV: " + r.Next(1000, 10000) + " LEG: " + r.Next(10000, 100000));
        Console.WriteLine("TICKET N° :" + r.Next(10000000, 100000000) + " ESTACION: RETIRO");
        Console.WriteLine("SALDO ANT: $" + saldoAnt + " SALDO ACT: $" + saldoFinal);
        Console.WriteLine("TARJETA SUBE N°: XXXX XXXX XXXX " + nroTarjeta + "X");
        Console.WriteLine("EL PRESENTE TICKET NO POSEE VALOR FISCAL");
        Console.WriteLine("----------------------------------------");
        
        Console.ReadKey();
        }
    }
}