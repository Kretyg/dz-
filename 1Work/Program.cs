// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.Write("введите значение b1 = ");
double b1 = int.Parse(Console.ReadLine()!);
Console.Write("введите число k1 = ");
double k1 = int.Parse(Console.ReadLine()!);
Console.Write("введите значение b2 = ");
double b2 = int.Parse(Console.ReadLine()!);
Console.Write("введите число k2 = ");
double k2 = int.Parse(Console.ReadLine()!);

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");