// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int SumNum(int M, int N)
{
    int sum = 0;
    if (M < N)
    {
        for (int i = M; i <= N; i++)
        {
           sum = sum + i;
        }
         Console.Write($"{sum} ");
    }
    else
    {
        Console.Write($"{0} ");
    }
    return sum;
}



Console.WriteLine("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = int.Parse(Console.ReadLine());
SumNum(m, n);

