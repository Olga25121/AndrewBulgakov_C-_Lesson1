// Задача 29: Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int [] array = new int [8];
Random rnd = new Random();
for (int i=0; i<array.Length; i++)
{
    array[i] = rnd.Next(-100, 100);
}
                                      // Console.WriteLine(string.Join(", ", array)); можно вывести в линию

void PrintArray(int[] numbers)
{
    Console.Write("[");
    for(int i =0; i < array.Length; i++)
    {
      Console.Write(numbers[i] + ","); //как убрать последнюю запятую?
    }
    Console.Write("]");
}
int[] nameArray = array;
PrintArray(nameArray);