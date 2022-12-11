// Задача 34: 
// 1. Задайте массив, заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max) // 1. Массив псевдослучайных чисел
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] array)                        //Выводим его в консоль
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},"); //условие для удаления запятой в конце массива
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int GetCountElements(int[] array)  //Метод: количество четных элементов массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++; 
    }
    return count;
}

int[] arr = CreateArrayRndInt(4, 100, 999);
PrintArray(arr);
int countNum = GetCountElements(arr);
Console.WriteLine($"Количество чётных чисел в массиве {countNum}");