﻿// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите энное кол-во чисел: ");
int[] arraу = Array.ConvertAll(Console.ReadLine(). Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arraу.Length; i++)
{
    if (arraу[i] > 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Кол-во элементов больше 0: {count}");