// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


void Main()
{
    int M = ReadInt("Введите положительное число M: ");
    int N = ReadInt("Введите положительное число N: ");
    if (M > 0 && N > 0)
    {
        int result = AckermannFunction(M, N);
        Console.WriteLine($"A({M},{N}) = {result}");
    }
    else
        Console.Write("Введено некорректное число");
}

int AckermannFunction(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0)
    {
        return AckermannFunction(M - 1, 1);
    }
    else
        return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();