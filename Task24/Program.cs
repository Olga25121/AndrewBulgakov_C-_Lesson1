﻿// Задача 24: Напишите программу, которая
// 1. принимает на вход число (А) и 
// 2. выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int sum = default;

    for (int i = 1; i <= number; i++)
    {
        sum = sum + i; //sum +- i;
    }
    return sum;
}
int sumNumbers = SumNumbers(number);
Console.WriteLine(sumNumbers);
