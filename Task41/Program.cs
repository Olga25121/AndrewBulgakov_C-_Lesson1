// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел для ввода: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[num];

void InputNumbers(int num)
{


    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i + 1} числo через Enter: ");
        arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }

}
void PrintArray(int[] array)                        //Выводим его в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},"); //условие для удаления запятой в конце массива
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
int ComparingNumbers(int[] massNumbers)
{
    int count = 0;
    for (int i = 0; i < massNumbers.Length; i++)
    {
        if (massNumbers[i] > 0) count = count + 1;
    }
    return count;
}
InputNumbers(num);
Console.WriteLine();
PrintArray(arrayNumbers);
Console.WriteLine();
Console.WriteLine($"Вы ввели чисел больше 0 -> {ComparingNumbers(arrayNumbers)} ");

