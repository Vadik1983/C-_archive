/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
Console.Clear();


double b1 = 0.0d;
double k1 = 0.0d;
double b2 = 0.0d;
double k2 = 0.0d;
userNumbers(ref b1, ref k1, ref b2, ref k2);
crossLine(b1, k1, b2, k2);
//Программа принемая дробные числа выдает ошибку по число trу/catch,
// хотя всё гипертрофированно double. Объясните пожалуйста!
void userNumbers(ref double b1, ref double k1, ref double b2, ref double k2)
{
    try
    {
        Console.Write($"Введите число b1: ");
        b1 = double.Parse(Console.ReadLine() ?? "");
        Console.Write($"Введите число k1: ");
        k1 = double.Parse(Console.ReadLine() ?? "");
        Console.Write($"Введите число b2: ");
        b2 = double.Parse(Console.ReadLine() ?? "");
        Console.Write($"Введите число k2: ");
        k2 = double.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода!", exc);
    }
}

static void crossLine(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * (b2 - b1) / (k1 - k2) + b1;
        Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2} --> Прямые пересекаются в точке: ({x};{y})");
    }
    else
    {
        Console.WriteLine($"Прямые не пересекаются!");
    }

}