// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Укажите x: ");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Укажите y: ");
int y = int.Parse(Console.ReadLine() ?? "0");
if ((x > 0) && (y > 0))
{
    Console.WriteLine("1st quarter");
}
else if ((x > 0) && (y < 0))
{
    Console.WriteLine("4th quarter");
}
else if ((x < 0) && (y > 0))
{
    Console.WriteLine("2nd quarter");
}
else
{
    Console.WriteLine("3d quarter");
}