// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
int n = new Random().Next(1, 10);
int m = new Random().Next(1, 10);
Random random = new Random();

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matr[i, j],2)}   ");
        }
    Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = random.NextDouble()*100; //от 0 до 100

        }

    }
}
double[,] matrix = new double[n, m];
FillArray(matrix);
PrintArray(matrix);