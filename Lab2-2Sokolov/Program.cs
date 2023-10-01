Console.WriteLine("Введите x");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y");
double y = double.Parse(Console.ReadLine());
if (y * y + (x - 1) * (x - 1) == 1) Console.WriteLine("Входит");
else Console.WriteLine("Не входит");