
/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2   */

int[] array = GetRandomArray(10, 100, 1000);
Console.WriteLine($"[{String.Join(", ", array)}]");
EvenNumbers(array);

/////////////////////////////////////////////
// Генератор случайных чисел в заданном диапазоне.
int[] GetRandomArray(int size, int minValue, int maxValue)
{
	int[] result = new int[size];
	var rnd = new Random();
	for(int i = 0; i < size; i++)
	{
		result[i] = rnd.Next(minValue, maxValue);
	}
	return result;
}

// Проверка чисел массива.
int EvenNumbers(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)  sum += 1;
    }
    Console.Write(sum);
    return(sum); 
}
// Функция должна делать возврат, поэтому и Console.Write и return использую.
