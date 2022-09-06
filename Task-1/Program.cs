// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if ( ( number == 6 ) || ( number == 7 ) )
    Console.WriteLine("Это выходной день");

if (number <= 5)
    Console.WriteLine("Будний день");

else
    Console.WriteLine("В неделе только 7 дней, идиот!");