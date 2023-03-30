Console.Clear();
Console.Write("Введите числа через пробел: ");
int[] array_numbers = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int counter = 0;
 
for (int i = 0; i < array_numbers.Length; i++)
{
    if (array_numbers[i] > 0)
        counter++;
}
Console.WriteLine($"Чисел больше нуля: {counter}");