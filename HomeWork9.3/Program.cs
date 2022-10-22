// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int AkkerRecurs(int m, int n)
{
    if (m == 0)
    {
        return (n + 1);
    }
    if ((m > 0) && (n == 0))
    {
        return AkkerRecurs(m - 1, 1);
    }
    if ((m > 0) && (n > 0))
    {
        return AkkerRecurs(m - 1, AkkerRecurs(m, n - 1));
    }
    return AkkerRecurs(m - 1, AkkerRecurs(m, n - 1));
}

Console.WriteLine(AkkerRecurs(M, N));