// Задача 22: Напишите программу, которая
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу квадратов чисел от 1 до N

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void SquareTable(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++) //квадрат чисел от 1 и до <= N
        {
            Console.WriteLine($"|{i,4} | {i*i,4}|"); //{ ,4}-отступ на 4 шага и выравнивание, | | - таблица
        }
    }   
    else Console.WriteLine($"Введите значение больше 0");
}
SquareTable(n);
