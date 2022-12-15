// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNaturalElements(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m} ");
        return m + SumNaturalElements(m + 1, n);
    }
    if (m > n)
    {
        Console.Write($"{m} ");
        return m + SumNaturalElements(m - 1, n);
    }
    if (m == n)
    {
        Console.Write($"{m} ");
    }

}
int sumNaturalElements = SumNaturalElements(numberM, numberN);
Console.WriteLine($"Возведение числа {numberM} в степень {numberN} = {sumNaturalElements}");

// Console.Write("Введите первое натуральное число: ");
// int numberM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе натуральное число: ");


// void NaturalNumbers(int m, int n)
// {
//     if (m < n)
//     {
//          Console.Write($"{m} ");
//         NaturalNumbers(m + 1, n);
//     }
//     if (m > n)
//     {
//         Console.Write($"{m} ");
//         NaturalNumbers(m - 1, n);
//     }
//     if (m == n)
//     {
//         Console.Write($"{m} ");
//     }
// }
// NaturalNumbers(numberM, numberN);