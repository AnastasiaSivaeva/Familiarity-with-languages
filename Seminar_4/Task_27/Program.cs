// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int SumNum(int number)
{
   int result = 0;
   for (int i = 0; i <= number; i++)
   {
    result = result + number % 10;
    number = number / 10;
   }
   return result;
   
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{SumNum(num)}");
