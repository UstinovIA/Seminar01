Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numC = Convert.ToInt32(Console.ReadLine());
int max = numA;
if (max < numB)
{
    max = numB;
}
if (max < numC)
{
    max = numC;
}
Console.WriteLine($"Максимальное чило равно -> {max}");