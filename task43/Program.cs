Console.Clear();
Console.Write("Укажите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых: {x}; {y}");