// Задача 26: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int QuantDigit(int numDigit)
{
    numDigit = Math.Abs(numDigit); //проверка на отрицательные числа
    int count = 0;
    while (numDigit > 0)
    {
        numDigit = numDigit / 10;
        count++;
    }
    return count > 0 ? count : 1; //тернарный тип операции
}
int result = QuantDigit(num);
Console.WriteLine($"Количество цифр в числе = {result}");
