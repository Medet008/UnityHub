

double m; 
double h;
double i;

string str;
Console.WriteLine("ввести вес");
str = Console.ReadLine();
m = double.Parse(str);
Console.WriteLine("ввести рост");
str = Console.ReadLine();
h = double.Parse(str);
i = m / (h * h);
Console.WriteLine("result" + i);