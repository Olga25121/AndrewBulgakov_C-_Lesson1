// Задача 21.Напишите программу, которая 
// 1. принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double DistBetwPoints(int x11, int y11, int z11, int x21, int y21, int z21)
{
int distanceX = x11 - x21;
int distanceY = y11 - y21;
int distanceZ = z11 - z21;
double distPonts = Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
return distPonts;
}

double result = DistBetwPoints(x1,y1,z1,x2,y2,z2);
Console.Write($"А ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");
