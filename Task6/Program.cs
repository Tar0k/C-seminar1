Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
if (value % 2 == 0) Console.WriteLine("Четное");
else Console.WriteLine("Нечетное");