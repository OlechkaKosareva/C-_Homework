//Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
int a = new Random().Next(100,999);
Console.WriteLine(a);
int value1 = a%100;
int value2 = value1/10;
Console.WriteLine(value2);


