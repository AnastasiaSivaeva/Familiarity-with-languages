// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int Expon(int numberA, int numberB)
{
   int result = 1;
   for (int i = 1; i <= numberB; i++)
   {
    result = result * numberA;
   }
   return result;
   
}

Console.WriteLine("Введите число A: ");
int num_a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int num_b = int.Parse(Console.ReadLine());
Console.WriteLine($"{Expon(num_a, num_b)}");