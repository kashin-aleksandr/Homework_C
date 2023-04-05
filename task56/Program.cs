Console.Clear();
Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите диапазон чисел в массиве от 1 до: ");
int range = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[lines, colums];
CreateArray(array);
WriteArray(array);

int SumLineMin = 0;
int SumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++){
  int temp = SumLineElements(array, i);
  if (SumLine > temp){
    SumLine = temp;
    SumLineMin = i;
  }
}

int SumLineElements(int[,] array, int i){
  int SumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++){
    SumLine += array[i,j];
  }
  return SumLine;
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
Console.WriteLine();
Console.WriteLine($"{SumLineMin} строкa, это строка с наименьшей суммой элементов");