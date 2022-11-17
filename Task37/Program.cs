// Задача 37: 
// 1. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д.
// 2. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max) // 1. Метод 
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)                        //Выводим его в консоль
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},"); //условие для удаления запятой в конце массива
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int[] MultiplicationNumbers(int[] array)
{
    int size = array.Length / 2;  //массив пополам (числа по парам)
    if (array.Length % 2 == 1) size = size + 1; //если массив нечетный
    int[] newArray = new int[size];
    for (int i = 0; i < array.Length / 2; i++) 
    {
        newArray[i] = array[i] * array[array.Length - 1 - i]; //новый массив(умножаем числа с обеих стором и смещаемся в центр на -i)
    }
    if (array.Length % 2 == 1) newArray[newArray.Length - 1] = array[array.Length / 2]; //если массив нечетный => выводить число в середине
    return newArray;
}


int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);

int[] res = MultiplicationNumbers(arr);
PrintArray(res);