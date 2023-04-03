int ListNumbers (int UserNumber, int LastNumber)
{
    if (UserNumber == LastNumber)
        return UserNumber;
    else
        Console.Write($"{ListNumbers(UserNumber, LastNumber + 1)}, ");
    return LastNumber;
}

int LastNumber = 1;
Console.Write("Введите натуральное число: ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ListNumbers(UserNumber, LastNumber));

