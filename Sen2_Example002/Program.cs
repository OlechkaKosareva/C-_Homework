// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
int value = new Random().Next();
string str = value.ToString();
Console.WriteLine(str);
int n = str.Length;
Console.WriteLine(n);
if (n > 2)
  Console.WriteLine("третья цифра -> " + str[2]);
if (value<99)
Console.WriteLine(" -> " + "нет третьего числа");
