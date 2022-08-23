//Напишите программу, которая выводит третью цифру (слева направо) заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int a = num;
if (a > 99)
{
    int res = (a / 100) % 10;
    Console.WriteLine($"{res}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}