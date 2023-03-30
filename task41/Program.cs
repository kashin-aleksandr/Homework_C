Console.Write("Введите числа через пробел: ");
int[] array_numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int counter = 0;
 
for (int i = 0; i < array_numbers.Length; i++)
{
    if (array_numbers[i] > 0)
        counter++;
}
Console.WriteLine($"Чисел больше нуля: {counter}");