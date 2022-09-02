// Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран

int [] NewArray(int size, int A, int B)
{
    int[] arr = new int [size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(A, B);
    }
    return arr;
}

void PrintArray(int [] arr2)
{
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write($"{arr2[i]}, ");
    }
}


Console.WriteLine("Введите число,обозначающее начало диапазона: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число, обозначающее конец диапазона: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество чисел в массиве: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine(String.Join(", ", NewArray(N, a, b)));