/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] array = GetRandomArray(8, 0, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");

double maxNum = MaxNum(array);
double minNum = MinNum(array);
DiffNun(array);
/////////////////////////////////////////////


double[] GetRandomArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    var rnd = new Random();
    for (double i = 0; i < size; i++)
    {
        result[(int)i] = rnd.Next((int)minValue, (int)maxValue);
    }
    return result;
}

// Находим максимальное значение.
double MaxNum(double[] array)
{
    int i = 0;
    double max = array[i];
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine(max);
    return max;
}

// Находим минимальное значение.
double MinNum(double[] array)
{
    int i = 0;
    double min = array[i];
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine(min);
    return min;
}

// Вычисляем разницу.
double DiffNun(double[] array)
{
    double result = maxNum - minNum;
    Console.WriteLine($"Result = {result}");
    return result;
}
