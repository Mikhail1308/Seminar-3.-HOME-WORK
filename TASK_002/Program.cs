// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double dotX1 = InputInt("Введите точку Х1: ");
double dotY1 = InputInt("Введите точку Y1: ");
double dotZ1 = InputInt("Введите точку Z1: ");
double dotX2 = InputInt("Введите точку X2: ");
double dotY2 = InputInt("Введите точку Y2: ");
double dotZ2 = InputInt("Введите точку Z2: ");
double lengthBetwPoints = FindDistance(dotX1, dotX2, dotY1, dotY2, dotZ1, dotZ2);
Console.WriteLine($"Расстояние между точками в пространстве = {lengthBetwPoints:F2}");
double InputInt(string message)
{
    Console.WriteLine(message);
    string? inputValue = Console.ReadLine();
    double result = Convert.ToDouble(inputValue);
    return result;
}
double FindDistance(double xOne, double xTwo, double yOne, double yTwo,  double zOne, double zTwo)
{
    double FindDistance = Math.Sqrt(Math.Pow(xTwo - xOne, 2) + Math.Pow(yTwo - yOne, 2) + Math.Pow(zTwo - zOne, 2));
    return FindDistance;
}
Console.WriteLine();