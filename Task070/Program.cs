// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При 
// решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("Введите массив : ");

string[] CreaterArray(int length)
{
    string[] arr = new string[length];
    for (int i = 0; i < length; i++)
    {
      arr[i] = Convert.ToString(Console.ReadLine())!;
    }
    return arr;
}

string[] FilteredArray(string[] arr)
{
    int strLen = 3;
    string[] newarr = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        int arrLen = arr[i].Length;
        if (arrLen <= strLen)
        {
            newarr[i] = arr[i];
        }
    }
    return newarr;
}

void PrintArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr.Length -1 == i)
        {
            Console.Write($"“{arr[i]}” ");
        }
        else
        {
            Console.Write($"“{arr[i]}” ," );
        }
    }
    Console.Write("]");
}


int arraySize = 4;
string[] array = CreaterArray(arraySize);
string[] newArray = FilteredArray(array);
//
var temp = new List<string>();
foreach (var s in newArray)
{
    if (!string.IsNullOrEmpty(s)) // Помогает убрать из вывода пустые индексы
        temp.Add(s);
}
newArray = temp.ToArray();
//
PrintArray(array);
Console.Write(" -> ");
PrintArray(newArray);


