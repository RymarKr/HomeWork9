﻿/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите M: ");
int NumberN = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int i = int.Parse(Console.ReadLine());

Console.WriteLine($"{Method(NumberN)} - Это сумма в промежутке от M до N");
int Method(int NumberN)
{
    if (NumberN > i)
    {
        return 0;
    }

    return NumberN + Method(NumberN+1);

}