// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

int[,] GetArray( int M, int N, int minValue, int maxValue)
{
    int[,] result = new int [M, N];

    for (int i = 0; i < M; i++)
    { 
        for (int j = 0; j < N; j++)
        {
           result [i, j] = new Random().Next(minValue, maxValue);
        }
        
    }
    return result;
}

void PrintArray(int [,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
    { 
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
           Console.Write($"{arr2[i, j]} ");
        }
        Console.WriteLine();
    }
   
}

double AverageNum(int [,] arr3, int m1, int n1)
{
    int[,] arr = new int [m1, n1];
    double sum = 0;
    for (int j = 0; j < arr3.GetLength(1); j++)
    { 
        sum = 0;
        for (int i = 0; i < arr3.GetLength(0) ; i++)
        {
           sum = (sum + arr3[i, j]);
        }
        sum = sum / m1;
        Console.Write($"{sum:f2} ");
    }
    return sum;
}

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество стобцов: ");
int n = int.Parse(Console.ReadLine());



int[,] MyArray = GetArray(m, n, -10, 10);
PrintArray(MyArray);
double result = AverageNum(MyArray, m, n);
Console.WriteLine(String.Join("; ",(result)));