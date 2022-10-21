/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.*/

Console.WriteLine("Введите число n: ");
int number = int.Parse(Console.ReadLine());

string Recurs(int number)
{
    if (number==1)
    {
        return number.ToString();
    }
    return (number+" "+Recurs(number-1));
}

Console.WriteLine(Recurs(number));