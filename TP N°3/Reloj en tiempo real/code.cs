using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Media;

namespace reloj
{
  
      public class Program 
      {
          public static void Main()
          {
          TimerCallback timerCallback = new TimerCallback(ShowTime);
          Timer timer = new Timer(timerCallback, null, 0, 1000);
          Console.ReadKey();
          }
          
          public static void ShowTime(object state)
          {
          Console.Clear();
          Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
          }
      }
}