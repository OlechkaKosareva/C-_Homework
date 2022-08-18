// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит 
//их на экран.
//int[] array = {1,2,3,4,5,6,7,8};

int size = 8;
int[] func1 (int size){ 

  int[] array = new int[size];    
  Random value = new Random();

    for (int i = 0; i < size; i++){
    array[i]=value.Next(0,10);
    }
    return array;
}
// функция  вывода массива на печать 
void func2 (int[] array){
  for (int i=0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
}
  func2(func1(size));
  