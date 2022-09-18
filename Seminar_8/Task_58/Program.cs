// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц


int[,] Matrix1( int M, int N, int minValue, int maxValue)
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

void PrintMatrix1(int [,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    { 
        for (int j = 0; j < mat.GetLength(1); j++)
        {
           Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
   
}

int[,] Matrix2( int N, int P, int minValue, int maxValue)
{
    int[,] result = new int [N, P];

    for (int i = 0; i < N; i++)
    { 
        for (int j = 0; j < P; j++)
        {
           result [i, j] = new Random().Next(minValue, maxValue);
        }
        
    }
    return result;
}

void PrintMatrix2(int [,] mat2)
{
    for (int i = 0; i < mat2.GetLength(0); i++)
    { 
        for (int j = 0; j < mat2.GetLength(1); j++)
        {
           Console.Write($"{mat2[i, j]} ");
        }
        Console.WriteLine();
    }
   
}


int[,] MatrixProd(int [,] mat, int [,] mat2)
{
    int[,] result = new int [mat.GetLength(0), mat2.GetLength(1)];

      for (int i = 0; i < result.GetLength(0); i++)
    {  
        for (int j = 0; j < result.GetLength(1) ; j++)
        {  
            result[i, j] = 0;
            for (int k = 0; k < mat.GetLength(1); k++)
            {
                result[i, j] += mat[i,k] * mat2[k,j];
            } 
        }
    }
    return result;
}


Console.WriteLine("Введите количество строк 1 матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество стобцов 1 матрицы (количество строк 2 матрицы): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество стобцов 2 матрицы: ");
int p = int.Parse(Console.ReadLine());

int[,] MyMatrix1 = Matrix1(m, n, 1, 5);
PrintMatrix1(MyMatrix1);
Console.WriteLine(" ");
int[,] MyMatrix2 = Matrix2(n, p, 1, 5);
PrintMatrix2(MyMatrix2);
int[,] result = MatrixProd(MyMatrix1, MyMatrix2);
Console.WriteLine("Произведение матриц: ");
PrintMatrix2(result);
