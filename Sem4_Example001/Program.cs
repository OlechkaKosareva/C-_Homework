// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
int a = new Random().Next(1,10);
int b = new Random().Next(1,10);
Console.WriteLine($"{a} {b}");
double degree = Math.Pow(a,b);
Console.WriteLine(degree);