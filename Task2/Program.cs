Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

Console.Write("Введите 1-ое число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-ое число: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine($"Большее число: {x}\nМеньшее число: {y}");
}
else if (x < y)
{
    Console.WriteLine($"Большее число: {y}\nМеньшее число: {x}");
}
else Console.WriteLine("Числа равны");