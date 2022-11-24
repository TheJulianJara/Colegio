using System;
using System.IO;
using System.Linq;
using System.Threading;
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
                        if(nombre.Length < 3) {
                            Console.Clear();
                            Console.WriteLine("Debe introducir el nombre completo.");
                            Console.ReadKey();
            } else {
					Console.Clear();
                    Console.Write("Espere...");
                    Thread.Sleep(3000);
					Console.Clear();
                    Console.Write("Dato cargado correctamente.");
                    Thread.Sleep(1000);
                    Console.Clear();
                        
                    Console.Write("Ingresá la edad: ");
                    edad = Int32.Parse(Console.ReadLine());
                    if(edad < 18){
                        Console.Clear();
                        Console.Write("La persona tiene que ser mayor que 18 años.");
						Thread.Sleep(3000);
						Console.Clear();
						Console.Write("Presione cualquier tecla para reiniciar el programa.");
                        Console.ReadKey();
                    } else if(edad > 99){
                        Console.Clear();
                        Console.WriteLine("La persona no puede tener más de 99 años.");
						Thread.Sleep(3000);
						Console.Clear();
						Console.Write("Presione cualquier tecla para reiniciar el programa.");
                        Console.ReadKey();
                } else {
						Console.Clear();
                    	Console.Write("Espere...");
                    	Thread.Sleep(3000);
						Console.Clear();
                    	Console.Write("Dato cargado correctamente.");
                    	Thread.Sleep(1000);
                    	Console.Clear();
                        Console.Write("Ingresá tu sueldo anterior: $");
                        sueldoAnterior = Int32.Parse(Console.ReadLine());
						Console.Clear();
                    	Console.Write("Espere...");
                    	Thread.Sleep(3000);
						Console.Clear();
                    	Console.Write("Dato cargado correctamente.");
                    	Thread.Sleep(1000);
                    	Console.Clear();
                        if(sueldoAnterior <= 0){
                            Console.Clear();
                            Console.Write("Debes ingresar un valor correcto.");
							Thread.Sleep(3000);
							Console.Clear();
							Console.Write("Presione cualquier tecla para reiniciar el programa.");
                            Console.ReadKey();
                    } else {
                        Console.Write("Ingresá el aumento: $");
                        aumento = Int32.Parse(Console.ReadLine());
						Console.Clear();
                    	Console.Write("Espere...");
                    	Thread.Sleep(3000);
						Console.Clear();
                    	Console.Write("Dato cargado correctamente.");
                    	Thread.Sleep(1000);
                    	Console.Clear();
						Console.Write("Espere mientras se genera el comprobante.");
						Thread.Sleep(1000);
						Console.Clear();
						Console.Write("Espere mientras se genera el comprobante..");
						Thread.Sleep(1000);
						Console.Clear();
						Console.Write("Espere mientras se genera el comprobante...");
						Thread.Sleep(1000);
						Console.Clear();
            
                        //      GENERADOR DE COMPROBANTE       //

                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("         Comprobante de cobro                    ");
                        Console.WriteLine(datetime );
                        Console.WriteLine("  Nombre: " + nombre );
                        Console.WriteLine("  Último sueldo: $" + sueldoAnterior );
                        if(aumento == 0){
                            Console.WriteLine("  No tuviste aumentos en este mes. ");
                        } else if(aumento < 0){
                            Console.WriteLine("  Descuento del sueldo: $" + aumento );
                        } else {
                            Console.WriteLine("  Aumento: $" + aumento );
                        }

                        sueldoActual = sueldoAnterior + aumento;

                        Console.WriteLine("  Tu sueldo actual sería de $" + sueldoActual );
                        Console.WriteLine("-------------------------------------");
                        Console.ReadKey();
    
            
                    }
                }
            
            }
        }
    }
}
