Console.Write("Выберите номер задания: ");
int task_number = Convert.ToInt32(Console.ReadLine());

switch (task_number)
{
    case 2:
        Task2();
        break;
    case 4:
        Task4();
        break;
    case 6:
        Task6();
        break;
    case 8:
        Task8();
        break;
    default:
        Console.WriteLine($"Задание с номером {task_number} не найдено!");
        break;
}


static void Task2()
{
    Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

    List<int> values = new();
    Console.Write("Введите 1-ое число: ");
    values.Add(Convert.ToInt32(Console.ReadLine()));

    Console.Write("Введите 2-ое число: ");
    values.Add(Convert.ToInt32(Console.ReadLine()));

    Console.WriteLine($"Большее число: {values.Max()}\nМеньшее число: {values.Min()}");
}

static void Task4()
{
    Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

    List<int> values = new();

    Console.Write("Введите 1-ое число: ");
    values.Add(Convert.ToInt32(Console.ReadLine()));

    Console.Write("Введите 2-ое число: ");
    values.Add(Convert.ToInt32(Console.ReadLine()));

    Console.Write("Введите 3-ое число: ");
    values.Add(Convert.ToInt32(Console.ReadLine()));

    Console.WriteLine($"Максимальное число: {values.Max()}");
}

static void Task6()
{
    Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

    Console.Write("Введите число: ");
    int value = Convert.ToInt32(Console.ReadLine());
    if (value % 2 == 0) Console.WriteLine("Четное");
    else Console.WriteLine("Нечетное");
}

static void Task8()
{
    Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

    Console.Write("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    if (N > 1) Enumerable.Range(1, N).ToList().Where(val => val % 2 == 0).ToList().ForEach(Console.WriteLine);
    else Enumerable.Range(N, N * -1 + 1).ToList().Where(val => val % 2 == 0).ToList().ForEach(Console.WriteLine);
}