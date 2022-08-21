// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу,которая покажет количество четных числе в массиве.

//int size = 10; //размер массива
//функция задания массива
int[] AddArr(int size)
{
    int[] array = new int[size];
    Random value = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = value.Next(100, 999);
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
//
//PrintArr(AddArr(size));

//определение количества положительных элементов
int EvenNumbers(int[] array)
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            countEven++;
    }
    return countEven;
}



int[] ArrEven = AddArr(10);
Console.WriteLine("Исходный массив: ");
PrintArr(ArrEven);//выводим исходный массив
Console.WriteLine("\nКоличество четных элементов: ");
EvenNumbers(ArrEven);
Console.WriteLine(EvenNumbers(ArrEven));