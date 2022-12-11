﻿// Задача 35: 
//1. Задайте одномерный массив из 123 случайных чисел.
//2. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

//Пример для массива из 5 элементов
// [5,18,123,6,2] -> 1
// [1,2,3,6,2] -> 0
// [10,11,12,13,14] -> 5

int[] CreateArrayRndInt(int size, int min, int max) // 1. Метод 
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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
int GetCountElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) count++;
    }
    return count;
}

int[] arr = CreateArrayRndInt(128, 0, 200);
PrintArray(arr);
int result = GetCountElements(arr);
Console.WriteLine($"Количество элементов массива из отрезка [10,99] = {result}");