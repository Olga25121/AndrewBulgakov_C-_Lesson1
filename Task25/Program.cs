// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 1)
{
    Console.WriteLine("Введите целое положительное число В");
}
else
{
    int numDegree = NumDegree(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени {numberB} => {numDegree}");
}

int NumDegree(int numA, int numB)
{
    int count = 1;
    int numC = 1;
    while (count <= numB)
    {
        numC = numC * numA;
        count++;
    }

    return numC;
}
