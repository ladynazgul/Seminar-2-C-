// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine() ?? "0");

if (a == b * b)
{
    Console.WriteLine($"Число {a} является квадратом {b}");
}
else if (b == a*a)
{
    Console.WriteLine($"Число {b} является квадратом {a}");
}
else 
{
    Console.WriteLine($"Числа {a} и {b} не является квадратами друг друга");
}