// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите количесево чисел: "); // Количество чисел определяет пользователь.
string userInput = Console.ReadLine() ?? "";     // Это число станет размером массива.
int m = int.Parse(userInput);
int min = int.MinValue;   // Ввел константы минимума и максимума,
int max = int.MaxValue;   // чтоб не ставить рамок.
int[] array = GetUserArray(m, min, max);
Console.WriteLine($"[{String.Join(", ", array)}]");
PositivNum(array);

/////////////////////////////////////////////////////////////

// В цикл внёс обращение к пользователю на введение каждого числа.
int[] GetUserArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число: ");
        string userInput = Console.ReadLine() ?? "";
        int num = int.Parse(userInput);
        result[i] = num;
    }
    return result;
}

//Собственно определение количества положительных чисел.
int PositivNum(int []array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if(array[i] > 0) sum++;
    }
    Console.WriteLine(sum);
    return sum;
}