Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
Console.WriteLine("Да, первое число является квадратом второго");
}
else
{
Console.WriteLine("Нет, первое число не является квадратом второго");
}
