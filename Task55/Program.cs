// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.
int[,]CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,]matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
           matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write ("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1)-1) Console.Write($"{matrix[i, j], 5} |");
            else Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine ("|");
    }
}
int[,] ReplaceRowsToColumns(int[,] matrix)
{
    int[,]newMatrix = new int [matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           newMatrix[i, j] = matrix[j, i];
        }
    }

    return newMatrix;
}
int[,]array2d = CreateMatrixRndInt(4, 4, -10, 10);
if(array2d.GetLength(0) == array2d.GetLength(1))
{
    PrintMatrix(array2d);
    Console.WriteLine();
    int[,]newArray2D = ReplaceRowsToColumns(array2d);
    PrintMatrix(newArray2D);
}
else Console.WriteLine("Введите массив с равным количеством столбцов и строк");

// int[,] ReplaceRowsToColumns(int[,] matrix)
// {
//     int temp = default;

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i; j < matrix.GetLength(1); j++)
//         {
//             temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }

//     return matrix;
// }
// if (matrixRnd.GetLength(0) == matrixRnd.GetLength(1))
// {
//     int[,] replaceMatrix = ReplaceRowsToColumns(matrixRnd);
//     PrintMatrix(matrixRnd);
// }
// else Console.WriteLine("Вводите массив с равным количеством столбцов и строк");
