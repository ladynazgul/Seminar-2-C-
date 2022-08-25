// Программа проверяет пятизначное число на палиндром.

Console.WriteLine("Введите пятизначное число: ");
string a = Console.ReadLine() ?? "0";

if (a[0] == a[4] && a[1] == a[3])
{
    Console.WriteLine("Данное число является палиндромом");
}
else
{
    Console.WriteLine("Данное число не является палиндромом");
}

Console.ReadKey();