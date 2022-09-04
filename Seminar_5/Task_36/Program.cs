// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

int [] GetArray(int size, int minValue, int maxValue)
{
   int[] res = new int[size];

    for (int i = 0; i < size; i++)
    { 
      res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}
int [] SumNumber(int[] array)
{
     int[] sum = new int[1];
    for (int i = 1; i < array.Length; i++)
    {
       if (i % 2 != 0)
       {
          sum[0] += array[i];
          i++;
       }
       else
       {
          i++;
       }
       
    }
    return sum;
}
int[] MyArray = GetArray(6, 1, 100);
Console.WriteLine(String.Join(", ", MyArray));
int[] result = SumNumber(MyArray);
Console.WriteLine(String.Join(", ", result));