// 9. Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа

// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");

// int firstDigit = number / 10; // 78 / 10 = 7  целоцисленное деление
// int secondDigit = number % 10; // 78 % 10 = 8  остаток деления на 10

// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа равна {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа равна {secondDigit}");

// // Условный оператор (расшифровка тернарного)
// int result = default;
// if(firstDigit > secondDigit) result = firstDigit;
// else result = secondDigit;
// Console.WriteLine($"Наибольшая цифра числа равна {result}");

// //Тернарный оператор 1
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; 
// Console.WriteLine($"Наибольшая цифра числа равна {secondDigit}");

// //Тернарный оператор 2 -без переменной
// Console.Write($"Наибольшая цифра числа {number} равна ");           
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

//Метод
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");

int MaxDigit(int num)
{
    int firstDigit = num / 10; 
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");
