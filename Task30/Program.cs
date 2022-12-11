// Задача 30: Напишите программу, которая
// 1. выводит массив из 8 элементов, 
// 2. заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

Console.WriteLine("Введите количество элементов массива : ");
int num = Convert.ToInt32(Console.ReadLine());

int[] NameArray(int size)
{
    int[] array = new int[size]; 
    Random rnd = new Random();   //задаем random в теле цикла, чтобы комбинации не повторялись
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2); //массив от 0-1, последняя цифра не учитывается, поэтому надо от 0-2
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i > array.Length - 1) Console.Write(",");
    }
    Console.Write("]");
}

int[] nameArray = NameArray(num);
PrintArray(nameArray);