Console.Clear();
Console.WriteLine("Введите число: ");
int num = Int32.Parse(Console.ReadLine());
Console.WriteLine($"Вторым числом является: {(num / 10) % 10}");


