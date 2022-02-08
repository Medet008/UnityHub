

string name, lastName;
int age, growth, weight;

string str;

Console.WriteLine("введите имя ?");
str = Console.ReadLine(); 
name = str.Trim();
Console.WriteLine("введите фамилию ?");
str = Console.ReadLine();
lastName = str.Trim();
Console.WriteLine("ваше возрост ?");
str = Console.ReadLine();
age = int.Parse(str);
Console.WriteLine("ваше рост ?");
str = Console.ReadLine();
growth = int.Parse(str);
Console.WriteLine("ваше вес ?");
str = Console.ReadLine();
weight = int.Parse(str);


Console.WriteLine("Ваше данные");
Console.WriteLine("имя:" + name+ " "+ "фамилия:" + lastName + "  "+ "возрост: " + age + " " + "рост:" + growth +  " " + " вес:" + weight);
string output = string.Format("  имя : {0}  фамилия: {1} возрост: {2} рост: {3} вес: {4} ", name, lastName, age, growth, weight);
Console.WriteLine(output); 
Console.WriteLine($"{"имя"}:{name},{"фамилия"},{lastName}, {"возрост"}:{age},{"рост"}:{growth},{"вес"}:{weight}");

Console.ReadKey(); 



