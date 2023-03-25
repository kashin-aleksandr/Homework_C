void Array_nums(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Array_nums(array);
Console.WriteLine($"Созданный массив: [{string.Join(", ", array)}]");

int sum = 0;
for (int i = 1; i < array.Length; i+=2)
sum = sum + array[i];

Console.WriteLine($"Сумма элементов на нечетных позициях ровняется: {sum} ");
