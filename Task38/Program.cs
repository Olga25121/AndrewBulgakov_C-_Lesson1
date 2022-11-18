// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}
void PrintArray(double[] array)                        //Выводим его в консоль
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; "); //условие для удаления запятой в конце массива
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
double[] arr = CreateArrayRndDouble(6, 1, 10);
PrintArray(arr);

double DiffBetweenMaxMinElem(double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (maxNumber < array[i])
        {
            maxNumber = array[i];
        }
        else if (minNumber > array[i])
        {
            minNumber = array[i];
        }
    }
    double difference = Math.Round(maxNumber - minNumber, 1);
    return difference;
}
double result = DiffBetweenMaxMinElem(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {result}");
