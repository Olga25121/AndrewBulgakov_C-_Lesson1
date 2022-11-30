// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];
Random rnd = new Random();


void FillArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { 
            matr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0); 
        }
    }
}
void PrintArray(double[,] matr)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5} |"); //5 элементов-форматирование
            else Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine("|");
    }
}
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);