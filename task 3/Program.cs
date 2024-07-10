// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 0, 10);
    PrintArray(array);
    Console.WriteLine();
    ReverseArray(array, arraySize);
}

int ReverseArray(int[] array, int arraySize)
{
    int temp = arraySize;
    if (temp == 0)
        return array[temp];
    Console.Write($"{array[temp - 1]}" + " ");
    return ReverseArray(array, temp - 1);
}

void PrintArray(int[] arrayForPrint)
{
    Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue);
    return tempArray;
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();