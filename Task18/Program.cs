// Задача 18: Напишите программу, которая
//1. по заданному номеру четверти, 
//2. показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти плоскости: "); //запрос пользователю
string quater = Console.ReadLine();

string Quarter(string quarterXY)          //тип данных строка-пользователь может набрать текст
{
    if(quarter=="1") return x > 0; y > 0; //проверяем условия координат четвертям
    if(quarter=="2") return x < 0; y > 0; //цифра в кавычках, т.к. это строка, текст
    if(quarter=="3") return x < 0; y < 0; 
    if(quarter=="4") return x > 0; y < 0;
    return($"Введены некорректные данные");  
}
string xy = Quarter(quarterXY);
Console.Write($"Диапазон возможных координат {quarter}: ");
Console.WriteLine(xy);