// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int M = ReadInt("Введите число M: ");
    int N = ReadInt("Введите число N: ");
    PrintNumber(M, N);
}

void PrintNumber(int M, int N)
{
    if (M <= N)
    {
        Console.Write(M + " ");
        PrintNumber(M + 1, N);
    }
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();