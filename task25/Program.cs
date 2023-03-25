Console.Clear();
Console.Write("Введите число A: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int num_b = Convert.ToInt32(Console.ReadLine());
int num_c = 1;

while (num_b != 0){
    num_c = num_c * num_a;
    num_b = num_b - 1;
}

Console.Write($"Число A в натуральной степени B равно: {num_c}");