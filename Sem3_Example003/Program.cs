// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int n = new Random().Next(0,10);
Console.WriteLine(n);
int i = 0;
int cube = 0;
while (i<=n) 
{
    cube = i*i*i;
    i++;
Console.WriteLine("{0}\t{1}",i,cube);
}


