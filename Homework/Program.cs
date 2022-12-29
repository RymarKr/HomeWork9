/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.Write("Введите натуральное число: ");
int NumberN = int.Parse(Console.ReadLine());
Console.Write($"{NumberN}");

Method();

void Method(int n = 1)
{
    NumberN--;
    if (n > NumberN)
    {
        return;
    }

    Console.Write($", {NumberN}");

    Method(n);
}