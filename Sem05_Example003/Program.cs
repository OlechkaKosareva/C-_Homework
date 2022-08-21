// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] arrayDouble = {1.5,1.9,0.4,2.7,9.5,12.4};

// функция  вывода массива на печать 
void PrintArr(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
//нахождение разницы между макисмальным и минимальным значениями массива
double DeltaMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    double delta = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }        
    delta = max - min;
    return delta;
}
Console.WriteLine("Исходный массив: ");
PrintArr(arrayDouble);
Console.WriteLine("\nРазница между максимальным и минимальным значениями: ");
Console.WriteLine(DeltaMaxMin(arrayDouble));