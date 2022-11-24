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
 string nombre;  double saldo_ca_pesos = 0; 
 double saldo_ca_dolares = 0; 
 double valor_dolar = 210;
 
 Console.Write("Ingrese el nombre de la persona: "); 
 nombre = Console.ReadLine(); 
 Console.Clear();
 Console.Write("Por favor ingresar el saldo de una ca en pesos: $");
 saldo_ca_pesos = double.Parse(Console.ReadLine());  saldo_ca_dolares = saldo_ca_pesos / valor_dolar; 
 Console.Clear(); 
 Console.Write("El saldo de la ca en dólares es U$D " + saldo_ca_dolares);  
 Console.ReadKey(); 
        }
    }
}
