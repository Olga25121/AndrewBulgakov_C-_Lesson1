// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом 
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого 
// столбца: 4,6; 5,6; 3,6; 3.


// void PrintAverage(double[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length) Console.Write($"{arr[i],5} ");
//         else Console.Write($"{arr[i],5}");
//     }
//     Console.WriteLine("]");
// }
// double[] AverageNumbers(int[,] matrix)
// {
//     double[] avernum = new double[matrix.GetLength(1)];
      
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(0); j++) avernum[i] += matrix[i, j];
//          avernum[i] = Math.Round(avernum[i] / matrix.GetLength(0), 1);  
                
//     }
//     return avernum;  
//   }

// int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10); //диапазон от 0-9
// PrintMatrix(array2D);
// Console.WriteLine();
// Console.WriteLine($"Cреднее арифметическое элементов каждого столбца:  ");
// double[] averagenums = AverageNumbers(array2D);
// PrintAverage(averagenums);
 

// // Console.WriteLine("введите количество строк");
// // int n = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("введите количество столбцов");
// // int m = Convert.ToInt32(Console.ReadLine());

// // int[,] avernum
//  = new int[n, m];
// // FillArrayRandomNumbers(avernum
// );



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        matrix[i, j] = rnd.Next(min, max + 1);
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],6}");
            else Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine("|");
    }
}

double[] AverageNumbers(int[,] matrix)
{
    double[] avernum = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++) 
        {
            avernum[i] += matrix[j, i];
        }
        avernum[i] = Math.Round(avernum[i] / matrix.GetLength(0), 1);
    }
    return avernum;
}
void PrintAverage(double[] arr)
{
    Console.Write("|");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length) Console.Write($"{arr[i],5} ");
        else Console.Write($"{arr[i],5}");
    }
    Console.WriteLine("|");
}
int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);

Console.WriteLine();

double[] averageArrey = AverageNumbers(array2D);
Console.WriteLine($"Cреднее арифметическое элементов каждого столбца: ");
PrintAverage (averageArrey);
