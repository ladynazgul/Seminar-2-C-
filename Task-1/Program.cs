// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if ( number > 5 )
    Console.WriteLine("Это выходной день");

else
    Console.WriteLine("Будний день");