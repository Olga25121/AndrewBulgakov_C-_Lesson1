// Напишите программу, которая 
// 1. на вход принимает два числа и 
// 2. выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

int a,b;
Console.Write("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} - большее число");
    Console.WriteLine($"{b} - меньшее число");
}
else 
{
    Console.WriteLine($"{b} - большее число");
    Console.WriteLine($"{a} - меньшее число");
}
