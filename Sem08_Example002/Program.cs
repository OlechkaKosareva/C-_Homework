// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Исходный массив: ");
int n = 5;
int m = 3;
int[,] matrix = new int[n, m];
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = Convert.ToInt32(new Random().Next(0, 5));
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

int minSumR = 0;
int sumR = SumRowsElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumR = SumRowsElements(matrix, i);
  if (sumR > tempSumR)
  {
    sumR = tempSumR;
    minSumR = i;
  }
}
Console.WriteLine($"\n{minSumR+1} - строкa с наименьшей суммой ({m}) элементов ");

int SumRowsElements(int[,] matr, int i) //нахождение минимальной суммы строки
{
  int sumR = matr[i,0];
  for (int j = 1; j < matr.GetLength(1); j++)
  {
    sumR += matr[i,j];
  }
  return sumR;
}

// 

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Минимальная сумма строки: ");
Console.WriteLine(SumRowsElements(matrix,5));



