// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

int [] GetArray(int size, int minValue, int maxValue)
{
   int[] res = new int[size];

    for (int i = 0; i < size; i++)
    { 
      res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int EvenNumber(int[] array)
{
    int res2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] % 2 == 0)
       {
          res2 = res2 + 1;
       }
       else
       {
          i++;
       }
       
    }
    return res2;
}

int[] MyArray = GetArray(5, 100, 1000);
Console.WriteLine(String.Join(", ", MyArray));
int result = EvenNumber(MyArray);
Console.WriteLine(String.Join(", ", result));