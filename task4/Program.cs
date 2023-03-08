Console.Clear();
Console.WriteLine("Введите числа:");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int max;

max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;

Console.WriteLine($"Максимальное число: {max}");