/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0  */

int[] array = GetRandomArray(10, -10, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");
SumNumbers(array);
/////////////////////////////////////////////

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
// Находим сумму элементов на нечётных позициях.
int SumNumbers(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++ )
    { 
        if  (i % 2 == 0) sum = sum + array[i];
    }
    Console.Write(sum);
    return(sum);
}