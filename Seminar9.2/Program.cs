// Показать все цифры в промежутке от m до n.

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());

string Recurs(int m, int n)
{
    if (m == n)
    {
        return n.ToString();
    }
    return (m + " " + Recurs(m + 1, n));
}

Console.WriteLine(Recurs(m,n));
