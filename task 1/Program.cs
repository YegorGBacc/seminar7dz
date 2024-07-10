// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int M = ReadInt("Введите натуральное число M: ");
    int N = ReadInt("Введите натуральное число N: ");
    if (M <= 0 | N <= 0)
    {
        Console.Write("Введено некорректное число");
    }
    else if (M > N)
    {
        PrintNumber2(M, N);
        Console.Write(N);
    }
    else
    {
        PrintNumber(M, N);
        Console.Write(N);
    }
}

// Метод для случая, когда первое введённое число больше второго.
void PrintNumber2(int M, int N)
{
    if (N < M)
    {
        Console.Write(M + ", ");
        PrintNumber2(M - 1, N);
    }
}

// Метод для случая, когда первое введённое число меньше второго.
void PrintNumber(int M, int N)
{
    if (M < N)
    {
        Console.Write(M + ", ");
        PrintNumber(M + 1, N);
    }
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();