Console.Clear();
Console.Write("Укажите размер массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (30 - 10) + 10, 2);
Console.WriteLine($"[{string.Join("; ", array)}]");

double min_number = Int32.MaxValue;
double max_number = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max_number)
        {
            max_number = array[i];
        }
    if (array[i] < min_number)
        {
            min_number = array[i];
        }
}

Console.WriteLine($"Максимальное значение в массиве: {max_number}. Минимальное значение в массиве: = {min_number}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {max_number - min_number}");