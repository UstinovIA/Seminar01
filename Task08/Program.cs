// 8.Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    Console.Write($"{num} -> ");
    int count = 2;
    while (num >= count)
    {
        Console.Write($"{count} ");
        count += 2;
    }
}
else
{
    Console.WriteLine("Вы ввели не натуральное число");
}