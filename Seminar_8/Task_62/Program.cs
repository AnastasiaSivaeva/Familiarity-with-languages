// Напишите программу, которая заполнит спирально массив 4 на 4

int[,] GetArray( int N)
{
    int[,] result = new int [N, N];
    int num = 01;
    int i = 0;
    int j = 0;
    while (num < N * N )
    {  result[N, N] = num;
       num = num + 01;
      if (i <= j + 1 && i + j < result.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= result.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > result.GetLength(1) - 1)
    j--;
  else
    i--;
    }
    return result;
}

void PrintArray(int [,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
    { 
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
             Console.Write($" {arr2[i, j]}");
        }
        Console.WriteLine();
    }
   
}


Console.WriteLine("Напишите программу, которая заполнит спирально массив 4 на 4");



int[,] MyArray = GetArray(4);
PrintArray(MyArray);