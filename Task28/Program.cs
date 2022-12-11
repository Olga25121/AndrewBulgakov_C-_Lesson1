// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и 
// 2. выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Factorial(int number)
{
    int multiply = 1;  //=1, тк умножение на 0 = 0, default=0

    for (int i = 1; i <= number; i++) 
    {
        multiply = multiply * i; //multiply *= i;
    }
    return multiply;
}
int factorial = Factorial(num);
Console.WriteLine($"Произведение чисел от 1 до {num} => {factorial}");