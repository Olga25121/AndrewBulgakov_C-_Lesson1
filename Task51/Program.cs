// Задача 51: Задайте двумерный массив. Найдите сумму 
// элементов, находящихся на главной диагонали (с индексами 
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)  //3 строки - 3 иттерации
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //4 столбца
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5} |"); //5 элементов-форматирование
            else Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine();
}

int CalcSummDiagonal(int[,] matrix) //меняем исходный массив
{
    int sum = 0;
    int size = matrix.GetLength(1);
    if (matrix.GetLength(0) < matrix.GetLength(1))
    {
        size = matrix.GetLength(0);
    }
    for (int i = 0; i < size; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}
int[,] result = CreateMatrix(3, 5, -10, 10); //диапазон от 0-9
PrintMatrix(result);
Console.WriteLine();
int sum = CalcSummDiagonal(result);
Console.WriteLine($"Сумма элементов на главной диагонали = {sum}");

