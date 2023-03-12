Console.Clear();
Console.WriteLine("Введите число: ");
int num = Int32.Parse(Console.ReadLine()!);

if (num > 99 && num < 999)
    Console.WriteLine($"Третья цифра: {num % 10}");
else if (num > 999 && num < 9999)
    Console.WriteLine($"Третья цифра: {num / 10 % 10}");
else if (num > 9999)
    Console.WriteLine($"Треть цифра: {num / 100 % 10}");
else
    Console.WriteLine("Третьей цифры нет");