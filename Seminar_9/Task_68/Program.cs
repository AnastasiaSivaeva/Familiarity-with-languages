// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

int AkkermanFunction(int M, int N)
{
    if (M == 0) return (N + 1);
    if ((M > 0) && (N == 0)) return (AkkermanFunction(M - 1, 1));
    return (AkkermanFunction(M - 1, AkkermanFunction(M, N - 1)));
    
}


Console.WriteLine("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = int.Parse(Console.ReadLine());
int result = AkkermanFunction(m, n);
Console.WriteLine(String.Join("; ",(result)));