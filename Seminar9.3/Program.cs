// Принимает число, возвращает сумму его чисел.

Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());

int RecSumNumbers(int n)
{
  if(n==0)
  {
    return 0;
  }
  return n%10 + RecSumNumbers(n/10);
}

Console.WriteLine(RecSumNumbers(n));
