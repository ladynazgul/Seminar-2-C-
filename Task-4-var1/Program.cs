﻿// Вариант решения задачи с использованием методов. Но так ОЧЕНЬ длинно получается:))))

int numPlan = 2;            // количество осей координат
int min = -20;               // минимальное значение диапазона для выбора случайных чисел
int max = 20;                // максимальное значение диапазона ...

int[] GetPointCoords(int numPlan)
{
    int[] coords = new int[numPlan];
    for (int i = 0; i < numPlan; i++)
    {
        coords[i] = new Random().Next(min, max);
    }
    return coords;
}

void PrintCoords(int[] array)
{
    System.Console.Write($"(");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine($"{array[array.Length - 1]})");
}

double FindDistance(int[] arr1, int[] arr2) // этот метод вычисляет расстояние между точками
{
    int sum = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        sum = sum + (arr1[i] - arr2[i]) * (arr1[i] - arr2[i]);
    }
    double result = Math.Sqrt(sum);
    return result;
}

int[] PointA = GetPointCoords(numPlan);
int[] PointB = GetPointCoords(numPlan);

System.Console.Write($"Координаты точки А: ");
PrintCoords(PointA);
System.Console.Write($"Координаты точки B: ");
PrintCoords(PointB);

System.Console.WriteLine($"Расстояние между точками А и В: {FindDistance(PointA, PointB)}");