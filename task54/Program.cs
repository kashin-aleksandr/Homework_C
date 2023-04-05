Console.Clear();
Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите диапазон чисел в массиве от 1 до: ");
int range = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[lines, colums];
CreateArray(array);
Console.WriteLine();
Console.WriteLine("Первоначальный список: ");
WriteArray(array);
SortNumbers(array);
Console.WriteLine();
Console.WriteLine("Отсортированный список: ");
PrintArray(array);

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


void CreateArray(int[,] array){
  for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array){
  for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
