// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = Convert.ToInt32(new Random().Next(0, 10));
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write(matr[i, j] + "\t  ");
        Console.WriteLine();
    }
}

int PositionElements(int[,] matr, int a, int b)
{
    int value = 0;
    if (a > matr.GetLength(0) || b > matr.GetLength(1)) value = -1;
    else value = Convert.ToInt32(matr.GetValue(a,b));
    return value;
}

Console.WriteLine("Введите размеры массива");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
FillArray(matrix);
PrintArray(matrix);


Console.WriteLine("Введите координаты элемента матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int val = PositionElements(matrix, a, b);
if (val < 0) Console.WriteLine("такого элемента не существует");
else Console.WriteLine("Возвращаемое значение: " + val);