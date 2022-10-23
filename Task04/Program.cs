// Напишите программу, которая
// 1. принимает на вход три числа и 
// 2. выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите три числа: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());
int number_3 = Convert.ToInt32(Console.ReadLine());
int max = number_1;

if (number_2 > max) max = number_2;
if (number_3 > max) max = number_3;
if (number_1 > max) max = number_1;

Console.Write("max = ");
Console.WriteLine(max);
