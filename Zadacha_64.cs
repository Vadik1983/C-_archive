/*Задача 64: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"   */

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Натуральные числа от " + n + " до 1: ");
DisplayNumbers(n);

void DisplayNumbers(int n)
{
    int i = 0;
    if (n >= 1)
    {
        DisplayNumbers(i);
        for(i = n; i > 0; i--)
        Console.Write(i + " ");
    }
}