void Array_nums(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Array_nums(array);
Console.WriteLine($"Созданный массив: [{string.Join(", ", array)}]");

int count = 0;
for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
count++;

Console.WriteLine($"В массиве {count} четных числа");

