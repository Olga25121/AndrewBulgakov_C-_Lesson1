// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите количество строк двумерного массива : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива : ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
            if (j < matrix.GetLength(1) - 1) Console.Write(" |");
        }
        Console.WriteLine(" ]");
    }
}
void SortElemInDescendingOrder(int[,] matrix)
{
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                {
                    if (matrix[i, k] < matrix[i, k + 1])
                    {
                        int temp = matrix[i, k+1];
                        matrix[i, k+1] = matrix[i, k];
                        matrix[i, k] = temp;
                    }
                }
            }
        }
    }
}

int[,] newMatrixRndInt = CreateMatrixRndInt(m, n, 1, 10);
Console.WriteLine();
Console.WriteLine("Массив, заполненный случайными целыми числами");
PrintMatrix(newMatrixRndInt);
Console.WriteLine();
SortElemInDescendingOrder(newMatrixRndInt);
Console.WriteLine("Массив, заполненный числами по убыванию в каждой строке массива");
PrintMatrix(newMatrixRndInt);