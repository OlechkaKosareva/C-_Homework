// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int a = new Random().Next(10000,99999);
string str = a.ToString();
if (str[0]==str[4]||str[1]==str[3])
Console.WriteLine(a + "   является палиндромом");
else
Console.WriteLine(a + "   не является палиндромом");

