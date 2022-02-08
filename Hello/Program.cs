using System;
//NET CORE 6 
// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    internal class Program
    {
      public static  void Pause()
        {
            Console.WriteLine();
            Console.ReadKey();
        }
         public void Main(string[] args)
        {
           Pause();
        }
    }
}