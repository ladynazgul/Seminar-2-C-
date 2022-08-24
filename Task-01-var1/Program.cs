// Это вариант решения задачи на проверку кратности с использованием метода

bool IsDivisible( int x, int n )
{
   return (x % n) == 0;
}
 
Console.WriteLine("Введите заданное число: ");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число-делитель: ");
int n = int.Parse(Console.ReadLine() ?? "0");

bool result = IsDivisible( x, n );

Console.WriteLine(result);
