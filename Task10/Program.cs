// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и
// 2. на выходе показывает вторую цифру этого числа

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//     int secondDigit = (number / 10) % 10; 
//     Console.WriteLine($"Вторая цифра числа = {secondDigit}");
// }
// else Console.WriteLine("Введите трёхзначное число!");


// //Метод
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int FindSecDigit(int num)
    {
        int secondDigit = (num / 10) % 10;
        return secondDigit;
    }
    int result = FindSecDigit(number);
    Console.WriteLine($"Вторая цифра числа = {result} ");
}
else Console.WriteLine("Введите трёхзначное число!");

