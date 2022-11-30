// Задача 50: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента
// в массиве нет   

// Console.WriteLine("Введите номер строки двумерного массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца двумерного массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {

//      Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)  //3 строки - 3 иттерации
//     {
//         for (int j = 0; j < array.GetLength(1); j++) //4 столбца
//         {
//             array[i, j] = rnd.Next(min, max + 1); //max+1 чтобы в диапазон вошли все числа
//         }
//     }
//     return array;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],5} |"); //5 элементов-форматирование
//             else Console.Write($"{array[i, j],5}");
//         }
//         Console.WriteLine("|");
//     }
// }

// void SearchNumber(int m, int n, int[,] array)
// {
//     int[,] array = new int[m, n];
//     if (m < array.GetLength(0) && n < array.GetLength(1))
//     {
//         Console.Write($"Значение искомого элемента = {array[m, n]}");
//     }
//     else Console.WriteLine($"Такого элемента нет в массиве");
// }
// int[,] array2D = CreateMatrixRndInt(5, 5, -10, 10); //диапазон от 0-9

// PrintMatrix(array2D);

Console.Write("Введите номер строки двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[5, 5];
CreateMatrixRndInt(array);
Console.WriteLine();

if (n > array.GetLength(0) && m > array.GetLength(1))
{
    Console.WriteLine("Такого элемента нет в массиве");
}
else Console.WriteLine($"Значение искомого элемента строки {n} и столбца {m} -> {array[n - 1, m - 1]}");


void CreateMatrixRndInt(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-100, 100 + 1) / 10;
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3} |"); //форматирование
            else Console.Write($"{array[i, j],3}");
        }
        Console.WriteLine("|");
    }
}
PrintArray(array);
