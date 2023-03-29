// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
//  длинна которых меньше либо рвана 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. при решении не рекомендуется пользоваться коллекциями,
//   лучше обойтись исключительно массивами.

// Примеры:

// ["hello", "2", "world", ":-)"] --> ["2", ":-)"] ["1234", "1567", "-2", "computer science"] --> ["-2"] ["Russia", "Denmark", "Kazan"] --> []

// Ссылка на блоксхему: ![image] https://user-images.githubusercontent.com/119668494/219852808-14f60289-dc70-4e23-9dda-ca0f81f97ed9.png


Console.WriteLine("Введите размер массива: ");
string userInput = Console.ReadLine() ?? "";
int sizeArr1 = int.Parse(userInput);
int i = 0;
int sizeArr2 = 0;

string[] array1 = GetArray1(sizeArr1);
SizeArr2(array1);
string[] array2 = GetArray2(sizeArr1, array1);
if (sizeArr1 > 0)
{
    Console.WriteLine($"[\"{String.Join("\", \"", array1)}\"] --> [\"{String.Join("\", \"", array2)}\"] ");
}
else
{
    Console.WriteLine($"[\"{String.Join("\", \"", array1)}\"] --> [\"Нет нужных строк!\"] ");
}

/////////////////////////////////////////////////////
string[] GetArray1(int sizeArr1)
{

    string[] result = new string[sizeArr1];
    for (i = 0; i < sizeArr1; i++)
    {
        Console.WriteLine("Enter strings:");
        string userInput1 = Console.ReadLine() ?? "";
        result[i] = userInput1;
    }
    return result;
}

int SizeArr2(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            sizeArr2 = sizeArr2 + 1;
        }
    }
    return sizeArr2;
}

string[] GetArray2(int sizeArr2, string[] array1)
{
    string[] array2 = new string[sizeArr2];
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
    }
    return array2;
}