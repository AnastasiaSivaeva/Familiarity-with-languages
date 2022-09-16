// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

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

int SumNum(int [,] arr3, int m1, int n1)
{
    int[,] arr = new int [m1, n1];
    int sum = 0;
    int index = 0;
    int temp = 0;
    for (int i = 0; i < arr3.GetLength(0); i++)
    { 
        sum = 0;
        for (int j = 0; j < arr3.GetLength(1) ; j++)
        {
           sum = (sum + arr3[i, j]);
        }
        Console.Write($"{sum} ");
        if (sum < temp)
       {
        temp = sum;
        index = i;
       }
    }
    return index;
}

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество стобцов: ");
int n = int.Parse(Console.ReadLine());



int[,] MyArray = GetArray(m, n, -10, 10);
PrintArray(MyArray);
int result = SumNum(MyArray, m, n);
Console.WriteLine("Индекс строки: {0}", String.Join(", ",(result)));