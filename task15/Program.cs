Console.Clear();
Console.WriteLine("Введите цифру: ");
int num = Int32.Parse(Console.ReadLine()!);

if (num == 6 || num == 7)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");