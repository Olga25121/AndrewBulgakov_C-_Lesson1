// Задача 36:
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int GetSumNegativePosElem(int[]array)
{
    int sum = 0;
     for (int i = 1; i < array.Length; i+=2) //индекс элементов от 1 с шагом +2 (1,3,5...)
     {
        sum = sum + array[i];
     }
    return sum;
}
int[] array = CreateArrayRndInt(4, -1, 100);
PrintArray(array);
int sumNum = GetSumNegativePosElem(array);
Console.WriteLine($"Сумма элементов на нечётных позициях = {sumNum}");