// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите первое неотрицательное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе неотрицательное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
int akkerman = Akkerman(numberM, numberN);
Console.WriteLine($"Результат вычисления функции Аккермана({numberM},{numberN}) = {akkerman}");