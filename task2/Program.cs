Console.Clear();
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

if (a > b)
{
    Console.WriteLine($"{a} - max, {b} - min");
}
else if (a < b)
{
    Console.WriteLine($"{b} - max, {a} - min");
}    
else if (a == b)
{
    Console.WriteLine($"{a} и {b} равны");
}
    
