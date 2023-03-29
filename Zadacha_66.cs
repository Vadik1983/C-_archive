/*Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30    */

int sum = 0;
Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "");
DisplayNumbers(m, n);
Console.WriteLine("Сумма натуральныех чисел от " + m + " до " + n + " => " + sum + "");

int DisplayNumbers(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    sum = m + DisplayNumbers(m + 1, n);
    return sum;
}