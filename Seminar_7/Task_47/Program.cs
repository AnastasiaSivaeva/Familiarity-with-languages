// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

double[,] GetArray( int M, int N, int minValue, int maxValue)
{
    double[,] result = new double [M, N];

    for (int i = 0; i < M; i++)
    { 
        for (int j = 0; j < N; j++)
        {
           result [i, j] = new Random().NextDouble() * minValue + maxValue;
        }
        
    }
    return result;
}

void PrintArray(double [,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
    { 
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
           Console.Write($"{arr2[i, j]:f2} ");
        }
        Console.WriteLine();
    }
   
}

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество стобцов: ");
int n = int.Parse(Console.ReadLine());
double[,] MyArray = GetArray(m, n, -10, 10);
PrintArray(MyArray);