// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите целое число: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8)
{
    if (day == 1)
    {
        Console.WriteLine("Понедельник");
    }
    else if (day == 2)
    {
        Console.WriteLine("Вторник");
    }
    else if (day == 3)
    {
        Console.WriteLine("Среда");
    }
    else if (day == 4)
    {
        Console.WriteLine("Четверг");
    }
    else if (day == 5)
    {
        Console.WriteLine("Пятница");
    }
    else if (day == 6)
    {
        Console.WriteLine("Суббота");
    }
    else if (day == 7)
    {
        Console.WriteLine("Воскресенье");
    }

    if (day == 6 || day == 7)
    {
        Console.WriteLine("Этот день является выходным");
    }
    else Console.WriteLine("Этот день не является выходным");
}
else
    {
        Console.WriteLine("Заданное число не соответствует дню недели");
    }
// //Здесь я не поняла как метод использовать компактно,  
// //Метод
// Console.WriteLine("Введите целое число: ");
// int day = Convert.ToInt32(Console.ReadLine());

// int CheckDayWeek(int day);
// {
//     if (day > 0 && day < 8)
//     {
//         int day = day == 1 ? day: dayTue;
//         int day = day == 3 ? dayWen : dayTor;
//         int day = day == 5 ? dayFri : daySat;
//         int day = day == 7 ? daySun : dayMon;

//         if (day == 6 || day == 7)
//         {
//             Console.WriteLine("Этот день является выходным");
//         }
//         else Console.WriteLine("Этот день не является выходным");
//     }
//     else
//     {
//         Console.WriteLine("Заданное число не соответствует дню недели");
//     }
// }