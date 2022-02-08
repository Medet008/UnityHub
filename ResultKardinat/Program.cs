using System; 


namespace ConsoleApp1
{
    internal class Program
    {
        public static int Kardinat(int x1, int x2, int y1, int y2, int y21)
        {
            return (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
            static void Main(string[] args)
        {
            Console.WriteLine("введите x1");
           int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите x2");
           int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ввудите y1 ");
           int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" введите y2");
           int y2 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("ресультат кардината" + " " + Kardinat(x1, x2, x2, y1, y2));   
        }
    }
}