// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int Recurs(int m, int n)
{
    if (m == 0)
    {
        return (n * (n + 1)) / 2;
    }
    if (n == 0)
    {
        return (m * (m + 1)) / 2;
    }
    if (m == n)
    {
        return m;
    }
    if (m < n)
    {
        return n + Recurs(m, n - 1);
    }
    if (m > n)
    {
        return n + Recurs(m, n + 1);
    }
    return Recurs(m, n);
}

Console.WriteLine(Recurs(M, N));

