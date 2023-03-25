int sum_numbers(int num){
    int result = 0;
    for (int i = 0; i <= num; i++){
        result += num % 10; 
        num = num / 10; 
}
    return result;
    }

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = sum_numbers(num);
Console.WriteLine($"Cумма цифр в числе {num} = " + res);