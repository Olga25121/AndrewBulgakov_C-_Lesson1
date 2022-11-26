// Задача 43: Напишите программу, которая
// 1. найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 2. значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double[]FindPointOfIntersectionLines (double b11, double k11, double b22, double k22)
{
    double[] array = new double[2];
    double x = (b22-b11) / (k11-k22);
    double y = k11*x + b11;
    array[0] = x;
    array[1] = y;
     return array;
}                            

void PrintArray(double[]array)
{
     for(int i = 0; i < array.Length; i++)
    {
        
        array[i] = Math.Round(array[i], 1); //округление до десятых
        if (i < array.Length - 1) Console.Write($"Точка пересечения двух прямых -> ({array[i]}; "); 
        else Console.Write($"{array[i]})");
    }
}
double[] nameArray = FindPointOfIntersectionLines(b1, k1, b2, k2);
PrintArray(nameArray);






