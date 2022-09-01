// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int temp = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = temp;
                }
            }
            Console.Write(matr[i, j] + "\t  ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите размеры массива");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine($"\nОтсортированный массив по строкам: ");
SortArray(matrix);