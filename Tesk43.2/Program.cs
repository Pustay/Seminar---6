﻿// Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите число k1 = ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b1 = ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2 = ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2 = ");
var b2 = Convert.ToDouble(Console.ReadLine());

if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1==k2)
{
    Console.WriteLine("Прямые параллельны"); 
}
else
{
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
Console.WriteLine($"Пересечение будет в точке: [{x};{y}]");
}