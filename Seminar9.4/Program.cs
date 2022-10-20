// Принимает A и B. Возводит число A в степень B.

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B= int.Parse(Console.ReadLine());

int RecPow(int m, int n)
{
  if(n==0)
  {
    return 1;
  }
  return m * RecPow(m, n-1);
}

Console.WriteLine(RecPow(A,B));
