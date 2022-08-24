// Дано число. Проверить кратно ли оно 7 и 23

int number = Convert.ToInt32(Console.ReadLine() ?? "0");
if(number%7 == 0 && number%23 == 0)
    Console.WriteLine("Число кратно и 7 и 23");
else
    Console.WriteLine("Число не кратно 7 или 23");
    
