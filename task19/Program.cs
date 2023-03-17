// Данный алгоритм корректно проверяет только шестизначные цифры
Console.Clear();
Console.WriteLine("Введите цифру: ");
int num = Int32.Parse(Console.ReadLine()!);
int result = num / 100;
int temp = 0;

for (int i = 0; i <= result; i++){
    temp += num % 10;
    if (temp == result)
        break;
}

if (temp == result)
    Console.WriteLine($"{num} является палиндромом");
else
    Console.WriteLine($"{num} не является палиндромом");
