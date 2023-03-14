Console.Clear();
Console.WriteLine("Введите число: ");
int num = Int32.Parse(Console.ReadLine()!);
int result = -1; 
if (num >= 100){
    while (num > 999){
        num = num / 10;
}
result = num % 10;
Console.WriteLine($"Третье число: {result}");
}   
else {
Console.WriteLine($"Третьей цифры нет");
}