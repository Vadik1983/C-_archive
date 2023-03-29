/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29   */


Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "");

int x = FunccioAccerman(m, n);
Console.Write($"m = {m} n = {n} --> A(m,n) = {x}");

int FunccioAccerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return FunccioAccerman(m - 1, 1);
    if (m > 0 && n > 0) return FunccioAccerman(m - 1, FunccioAccerman(m, n - 1));
    return FunccioAccerman(m, n);
}