// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты (X Y Z) первой точки А разделяя числа пробелами: ");

string xyz = Console.ReadLine()!;
string[] parts = xyz.Split(' ');
int xA = int.Parse(parts[0]);
int yA = int.Parse(parts[1]);
int zA = int.Parse(parts[2]);

Console.WriteLine("Введите координаты (X Y Z) второй точки B разделяя числа пробелами: ");

string xyz2 = Console.ReadLine()!;
string[] parts2 = xyz2.Split(' ');
int xB = int.Parse(parts[0]);
int yB = int.Parse(parts[1]);
int zB = int.Parse(parts[2]);

double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2) );

Console.WriteLine($"Расстояние между этими точками в 3D пространстве равно: {distance:F3} единиц(ы)");

Console.WriteLine($"{distance} - если быть супер точным");