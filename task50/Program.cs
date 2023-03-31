int m_lines = 3;
int n_colums = 4;
int [,] array = new int [m_lines, n_colums];

void FillArray (int [,] arrayToFill) {

    for (int i = 0; i < arrayToFill.GetLength(0); i++) {

        for (int j = 0; j < arrayToFill.GetLength(1); j++) {
            array [i,j] = new Random().Next(0, 10);
            Console.Write(array [i, j] + " ");
        }
        Console.WriteLine();
    }

}
void FindNuminArray (int [,] findnumber, int usernum) {
    bool check = false;
    for (int i = 0; i < findnumber.GetLength(0); i++) {

        for (int j = 0; j < findnumber.GetLength(1); j++) {
            if (findnumber [i, j] == usernum){
                Console.WriteLine($"Значение находится по координатам: номер строки: {i}, номер столбца: {j}");
                check = true;
            }
        }

    }
    if (check == false)
    Console.WriteLine("Такой позиции нет");
}

Console.Write("Введите значение: ");
int number = Convert.ToInt32(Console.ReadLine());
FillArray (array);
FindNuminArray(array, number);