// Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.

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

void AverageColumn(int[,] matr, int n, int m)
{
    int[] sum = new int[m];
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                sum[i] += matr[j, i];
            }
        }
    }
    for (int i = 0; i < m; i++)
    {
        Console.Write((sum[i] / n) + " ");
    }

}
Console.WriteLine("Введите размеры массива");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
FillArray(matrix);
PrintArray(matrix);
AverageColumn(matrix, n, m);
