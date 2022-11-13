// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB < 1)
{
    Console.WriteLine("Введите целое положительное число В");
}
else
{
    int numDegree = NumDegree(numA, numB);
    Console.WriteLine($"Число {numA} в степени {numB} => {numDegree}");
}

int NumDegree(int numberA, int numberB)
{
    int count = 1;
    int numberC = 1;
    while (count <= numberB)
    {
        numberC = numberC * numberA;
        count++;
    }

    return numberC;
}
