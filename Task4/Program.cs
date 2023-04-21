Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

Console.Write("Введите 1-ое число: ");
int val1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-ое число: ");
int val2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 3-ое число: ");
int val3 = Convert.ToInt32(Console.ReadLine());

int max = val1;
if (val2 > max) max = val2;
if (val3 > max) max = val3;

Console.WriteLine($"Максимальное число: {max}");