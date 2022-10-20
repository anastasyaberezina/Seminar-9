// Задать значение n. Вывести все цифры в промежутке от 1 до n.

Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());

string Recurs(int minValue, int n)
{
    if (minValue == n)
    {
        return n.ToString();
    }
    return (minValue + " " + Recurs(minValue + 1, n));
}

Console.WriteLine(Recurs(1,n));