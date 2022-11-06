// Задача 19.Напишите программу, которая
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void CheckPalindrom(int num)
{
    if (num > 9999 && num < 100000)
    {
        int num1 = num /10000;
        int num5 = num % 10;
        int num2 = num / 1000;
        int num4 = num % 100;
        if (num1 == num5 || num2 == num4)
        {
            Console.WriteLine($"Число {number} является палиндромом");
        }
        else
        {
            Console.WriteLine($"{number} - не палиндром");
        }
    }
    else   Console.WriteLine("Введите пятизначное число!");
}
CheckPalindrom(number);
