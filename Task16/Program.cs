// Задача16. Напишите программу, которая
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 * num1 == num2 || num2 * num2 == num1)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}