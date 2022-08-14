// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
//сумму цифр в числе.
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

  int Sum(int N)
  {
    int counter = Convert.ToString(N).Length;
    int value1 = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      value1 = N - N % 10;
      result = result + (N - value1);
      N = N / 10;
    }
   return result;
  }

int SumN = Sum(N);
Console.WriteLine("Сумма цифр: " + SumN);
