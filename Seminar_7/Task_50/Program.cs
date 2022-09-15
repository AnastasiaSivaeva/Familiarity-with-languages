// Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, и возвращает индексы этого элемента или же указание, что такого элемента нет



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

int IndNumber(int[,] arr3, int num)
{ 
     for (int i = 0; i < arr3.GetLength(0); i++)
    { 
        for (int j = 0; j < arr3.GetLength(1); j++)
        {
           if (num != arr3[i, j])
           {
             Console.WriteLine("Такого элемента нет");
           }
           else
           {
            Console.WriteLine("Индексы элемента: {0}", String.Join(", ",i, j));
           }
        }
    }
    return 0;
}

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество стобцов: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());


int[,] MyArray = GetArray(m, n, -10, 5);
PrintArray(MyArray);
int result = IndNumber(MyArray, number);
Console.WriteLine(String.Join(", ",result));