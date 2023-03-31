void ArrayWithRandomNumbers(double[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} \t");
        }
        Console.Write("|");
        Console.WriteLine("");
    }
}

Console.Clear();
Console.Write("Введите количество строк (m): ");
int m_lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов (n): ");
int n_columns = Convert.ToInt32(Console.ReadLine());
double[,] nums = new double[m_lines, n_columns];
ArrayWithRandomNumbers(nums);
PrintArray(nums);