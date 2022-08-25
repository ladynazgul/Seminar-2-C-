// Найти расстояние между точками в пространстве 2D

Console.Write("Введите координаты x1: ");
double x1 = Convert.ToDouble(Console.ReadLine() ?? "0");

Console.Write("Введите координаты x2: ");
double x2 = Convert.ToDouble(Console.ReadLine() ?? "0");

Console.Write("Введите координаты y1: ");
double y1 = Convert.ToDouble(Console.ReadLine() ?? "0");

Console.Write("Введите координаты y2: ");
double y2 = Convert.ToDouble(Console.ReadLine() ?? "0");

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
Console.ReadKey();