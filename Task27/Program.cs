// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigit(int number)
{
    number = Math.Abs(number); //проверка на отрицательные числа
    int sum = 0;
    while (number > 0)
    {
       sum = sum + number % 10;  
       number = number / 10;     
    }
    return sum;
}
int result = SumDigit(num);
Console.WriteLine($"Сумма цифр в числе -> {result}");
