// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 49 2
// 5 81 2 9
// 64 4 4 4

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
}

int[,] FindSquare(int[,] matrix) //меняем исходный массив
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)  //только четные строки
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2) //только четные столбцы
        {
            // if (i % 2 == 0 && j % 2 == 0)
            matrix[i, j] *= matrix[i, j];    
        }
    }
    return matrix;
    
}
int[,] result = CreateMatrix(5, 5, -10, 10); //диапазон от 0-9
PrintMatrix(result);
Console.WriteLine();
FindSquare(result);
PrintMatrix(result);

