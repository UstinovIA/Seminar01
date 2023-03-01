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