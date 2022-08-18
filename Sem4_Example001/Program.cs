// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// int a = new Random().Next(1,10);    по ошибке начала решать задачу в лоб (без цикла)
// int b = new Random().Next(1,10);
// Console.WriteLine($"{a} {b}");
// double degree = Math.Pow(a,b);
// Console.WriteLine(degree);

int funcExp(int A, int B)
{
int value = 1; //переменная, в которую будет записываться произведение а в степени b
for(int i=1; i <= B; i++)
{
        value = value * A;
}
        return value;
}
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
  int functExp = funcExp(A, B);
  Console.WriteLine(functExp);
