// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int a = num;
int b = 0;
if (num > 9999 && num < 100000)
{
while (a > 0)
{
    int c = a % 10;
    b = b * 10 + c;
    a = a / 10;
    
}
Console.WriteLine($"{b}");
    if (b == num)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else 
{
    Console.WriteLine("Неверное число");
}