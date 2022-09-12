// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

double XCoord(int B1, int K1, int B2, int K2)
{
     double x = 0;
     double x1 = 0;
     double x2 = 0;
    
      x1 = (B2 - B1);
      x2 = (K1 - K2);
      x = x1 / x2;
    return x;
}

double YCoord(int B1, int K1, double x1)
{
     double y = 0;
    
      y = (K1*x1) + B1;
    return y;
}




Console.WriteLine("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine());

double result1 = XCoord(b1, k1, b2, k2);
double result2 = YCoord(b1, k1, result1);
Console.WriteLine(String.Join(", ",result1, result2));
