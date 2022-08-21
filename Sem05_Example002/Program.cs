// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях

//функция задания массива
int[] AddArr(int size)
{
    int[] array = new int[size];
    Random value = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = value.Next(1, 10);
    }
    return array;
}
// функция  вывода массива на печать 
void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

//сумма нечетных элементов

int SumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i=i+2) //первый является нулевым, если нет, то i=1
    {
        sum += array[i];
    }
    return sum;
}

Console.WriteLine("Исходный массив: ");
int[] TempArr = AddArr(10);
PrintArr(TempArr);
int TempSum = SumOdd(TempArr);
Console.WriteLine("\nСумма элементов на нечетных позициях: " + TempSum);