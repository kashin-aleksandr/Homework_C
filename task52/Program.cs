Console.Write("Укажите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[lines, colums];

void FillArrayRandomNumbers(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array){

    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

FillArrayRandomNumbers(nums);
PrintArray(nums);
Console.WriteLine();

for (int j = 0; j < nums.GetLength(1); j++){
    double value = 0;
    for (int i = 0; i < nums.GetLength(0); i++){
        value = (value + nums[i, j]);
    }
    value = value / colums;
    Console.Write(value + "; ");
}


