using System;
//NET CORE 6 
// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string str;
            Console.WriteLine("введите превое число");
            str = Console.ReadLine();
            a = int.Parse(str);


            Console.WriteLine("введите второе число");
            str = Console.ReadLine();
            b = int.Parse(str);

            c = a + b; 
            Console.WriteLine("result" + " " + a + "+"+b +"="+c); 

            Console.ReadLine(); 
        }
    }
}