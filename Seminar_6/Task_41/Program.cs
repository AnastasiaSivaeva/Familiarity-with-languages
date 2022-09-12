// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int [] GetArray(int m)
{
   int[] res = new int[m];

    for (int i = 0; i < res.Length; i++)
    { 
      Console.Write($"\nВведите элемент массива под индексом {i}: \t ");
      res[i] = int.Parse(Console.ReadLine());
    }
    return res;
}


int PrintNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
       
    }
    return count;
}

Console.WriteLine("Введите количество элементов в массиве: ");
int M = int.Parse(Console.ReadLine());
int[] MyArray = GetArray(M);
Console.WriteLine(String.Join(", ", MyArray));
int result = PrintNumber(MyArray);
Console.WriteLine(String.Join(", ", result));