void ArrayWithRandomNums(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(1, 31);
        }
    }
}

void SortNumbers(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int t = 0; t < array.GetLength(1) - 1; t++){
                if (array[i, t] < array[i, t + 1]){
                    int temp = array[i, t + 1];
                    array[i, t + 1] = array[i, t];
                    array[i, t] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,] ColumsRaws = new int[3, 4];
ArrayWithRandomNums(ColumsRaws);
PrintArray(ColumsRaws);
SortNumbers(ColumsRaws);
Console.WriteLine();
PrintArray(ColumsRaws);