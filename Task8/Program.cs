Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 1)
{
    for (int i = 1; i <= N; i++)
    {
        if (i % 2 == 0) Console.Write($"{i} ");
    }
}
else
{
    while (N < 1)
    {
        if (N % 2 == 0) Console.Write($"{N} ");
        N++;
    }
}