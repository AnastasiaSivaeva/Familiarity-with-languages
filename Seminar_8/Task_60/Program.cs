// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

int[,,] GetArray( int X, int Y, int Z, int minValue, int maxValue)
{
    int[,,] result = new int [X, Y, Z];

    for (int i = 0; i < X; i++)
    { 
        for (int j = 0; j < Y; j++)
        {
          for (int k = 0; k < Z; k++)
          {
              result [i, j, k] = new Random().Next(minValue, maxValue);
          }
        }
        
    }
    return result;
}

void ElArray( int[,,] array)
{
    int[] result = new int [array.GetLength(0)*array.GetLength(1)*array.GetLength(2)];

    for (int i = 0; i <array.GetLength(0) ; i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            if (result[i] == result[j])
            {
                result[i] = new Random().Next(10, 100);
                j = 0;
            }
           for (int k = 0; k < array.GetLength(2); k++)
           {
             if (result[i] == result[k])
             {
                 result[i] = new Random().Next(10, 100);
                k = 0;
             }
           }
        }
        
    }
}


void PrintArray(int [,,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
    { 
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
          for (int k = 0; k < arr2.GetLength(2); k++)
          {
             Console.Write($" {arr2[i, j, k]} ({i} {j} {k})");
          }
        }
        Console.WriteLine();
    }
   
}




Console.WriteLine("Введите размер массива X, Y, Z ");
Console.WriteLine("Введите X: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z: ");
int z = int.Parse(Console.ReadLine());


int[,,] MyArray = GetArray(x, y, z, 10, 99);
ElArray(MyArray);
PrintArray(ElArray);