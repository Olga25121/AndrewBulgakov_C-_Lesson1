// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа или 
// 2. сообщает, что третьей цифры нет

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());

// int a = number;

// if (a >= 100)
// {
//     while (a > 999)
//     {
//         a = a / 10;
//     }
//     int thirdDigit = a % 10;
//     Console.WriteLine($"Третья цифра числа = {thirdDigit}");
// }
// else
// {
//     Console.WriteLine("третьей цифры нет");
// }

//метод
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number;

if (a >= 100)
{
    int ThirdDigNum(int num)
    {
        while (a > 999)
        {
            a = a / 10;
        }

        int thirdDigit = a % 10;
        return thirdDigit;
    }
    int result = ThirdDigNum(number);
    Console.WriteLine($"Третья цифра числа => {result}");
}
else Console.WriteLine("третьей цифры нет");
