// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

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

int[,] MaxNum(int [,] arr3)
{
    int[,] arr = new int [arr3.GetLength(0), arr3.GetLength(1)];
    int temp = 0;
    for (int i = 0; i < arr3.GetLength(0); i++)
    {   
        temp = 0;
        for (int j = 0; j < arr3.GetLength(1) -1 ; j++)
        {
               if (arr3 [i, j] < arr3 [i, j + 1])
              {
               temp = arr3[i, j + 1];
               arr3[i, j + 1] = arr3[i, j];
               arr3[i, j] =  temp;
              }
        }
    }
    return arr;
}



Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество стобцов: ");
int n = int.Parse(Console.ReadLine());

int[,] MyArray = GetArray(m, n, -10, 5);
PrintArray(MyArray);
int[,] Array2 = MaxNum(MyArray);
Console.WriteLine("Массив: ");
PrintArray(Array2);
