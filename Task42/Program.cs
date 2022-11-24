// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

// 1.

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int ConvertToBin(int num)
// {
//     int result = 0;
//     while (num > 9 || num > 0)
//     {
//         int dig1 = num % 2;
//         result += dig1;
//         result *= 10;
//         num /= 2;
//     }
//     return result;
// }

// int RevertNumber(int par)
// {
//     int result = 0;
//     while (par > 9)
//     {
//         result += par % 10;
//         result *= 10;
//         par /= 10;
//     }
//     result += par % 10;
//     return result;
// }

// Console.WriteLine(RevertNumber(ConvertToBin(number)));

// 2.
// int ReverseNumber(int num2)
// {
//     int result = default;

//     while (num2 > 9 || num2 > 0)
//     {
//         result += num2 % 10;
//         result *= 10;
//         num2 /= 10;
//     }
//     result += num2 % 10;

//     return result;
// }

// Console.WriteLine("Введите число десятичной системы исчисления");
// int number10 = Convert.ToInt32(Console.ReadLine());

// int ConvertToBin(int num10)
// {
//     int num2 = default;

//     while (num10 > 0)
//     {
//         num2 += num10 % 2;
//         num2 *= 10;
//         num10 /= 2;
//         ConvertToBin(num10);
//     }

//     return num2;
// }

// int number2Rev = ConvertToBin(number10);
// int number2 = ReverseNumber(number2Rev);
// Console.WriteLine(number2);
//  string

Console.WriteLine(" введите число в десятичной системе");
int number = Convert.ToInt32(Console.ReadLine());

int Binare(int num)
{
    string st = "";
    while (num > 0)
    {
        string temp = Convert.ToString(num % 2);
        st = temp + st;
        num = num / 2;
    }

    int bin = Convert.ToInt32(st);
    return bin;
}
System.Console.WriteLine($"Число {number} в двоичной системе выглядит {Binare(number)}");