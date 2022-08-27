// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите координату x первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки: ");
int z2 = int.Parse(Console.ReadLine());

int a = (x2 - x1) * (x2 - x1);
int b = (y2 - y1) * (y2 - y1);
int c = (z2 - z1) * (z2 - z1);
int sum = a + b + c;
double dis = Math.Sqrt(sum);

Console.WriteLine($"{dis:f2}");