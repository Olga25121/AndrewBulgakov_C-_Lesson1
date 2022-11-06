// Задача 23. Напишите программу, которая
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите число-> ");
int n = Convert.ToInt32(Console.ReadLine());

void CubeTable(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++) 
        {
            Console.WriteLine($"{i,4} | {Math.Pow(i, 3)}"); //возведение в куб
        }
    }   
    else Console.WriteLine($"Введите значение больше 0");
}
CubeTable(n);