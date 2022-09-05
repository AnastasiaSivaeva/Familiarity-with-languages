// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

double [] GetArray(int size, double minValue, double maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    { 
      res[i] = new Random().NextDouble() * (maxValue - minValue);
    }
    return res;
}

double MaxNumber(double[] array)
{
     double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
       if (array[i] > max)
       {
          max = array[i];
          i++;
       }
       else
       {
          i++;
       }
       
    }
    return max;
    
}

double MinNumber(double[] array2)
{
     double min = array2[0];
    for (int i = 1; i < array2.Length; i++)
    {
       if (array2[i] < min)
       {
          min = array2[i];
          i++;
       }
       else
       {
          i++;
       }
       
    }
    return min;
    
}


double[] MyArray = GetArray(6, 1, 10);
Console.WriteLine(String.Join(" ",  MyArray));
double result = MaxNumber(MyArray);
Console.WriteLine(String.Join(", ", result));
double result2 = MinNumber(MyArray);
Console.WriteLine(String.Join(", ", result2));
Console.WriteLine(String.Join(", ", +(result - result2)));