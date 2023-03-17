//Решение задачи через массив и метод reverse
Console.Clear();
Console.WriteLine("Введите число: ");
string? num = Console.ReadLine()!;
char [] array_num = num.ToCharArray();
Array.Reverse(array_num);
string final_num = new string(array_num);

if (num == final_num)
    Console.WriteLine($"{num} является палиндромом");
else
    Console.WriteLine($"{num} не является палиндромом");
