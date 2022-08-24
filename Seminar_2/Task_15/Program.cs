//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Введите число: ");
int day_number = int.Parse(Console.ReadLine());
int a = day_number;
if (a < 8)
{
    if (a == 6 || a == 7)
    {
        Console.WriteLine("{выходной}");
    }
    else
    {
         Console.WriteLine("{нет}");
    }
}
else
{
     Console.WriteLine("{такого дня недели нет}");
}